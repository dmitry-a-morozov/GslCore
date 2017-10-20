module sbolExample
open Amyris.Bio.utils
open Amyris.Dna
open uri

// --- Helper items for generating XML objects ---

let defaultEncoding = "http://www.chem.qmul.ac.uk/iubmb/misc/naseq.html"

type Restriction = | Precedes | SameOrientationAs | OppositeOrientationAs

let restrictionObj restriction =
    match restriction with 
    | Precedes -> SBOLProvider.Restriction("http://sbols.org/v2#precedes")
    | SameOrientationAs -> SBOLProvider.Restriction("http://sbols.org/v2#sameOrientationAs")
    | OppositeOrientationAs -> SBOLProvider.Restriction("http://sbols.org/v2#oppositeOrientationAs")

let SequenceConstraint (uri:Uri) restriction (subj_uri:Uri) (obj_uri:Uri) =
    let innerSC =
        SBOLProvider.SequenceConstraint2(
            uri,
            (restrictionObj restriction),
            SBOLProvider.Subject(subj_uri),
            SBOLProvider.Object(obj_uri))
    SBOLProvider.SequenceConstraint(innerSC)

let SequenceAnnotation (uri:Uri) (componentUri:Uri) location (roleUris:seq<Uri>) =
    let roles = [|for ruri in roleUris -> SBOLProvider.Role3(ruri) |]
    let innerSA =
        SBOLProvider.SequenceAnnotation2(
            uri,
            (SBOLProvider.Component3(componentUri)),
            location,
            roles)
    SBOLProvider.SequenceAnnotation(innerSA)

let dnaType = "http://www.biopax.org/release/biopax-level3.owl#DnaRegion"
let rnaType = "http://www.biopax.org/release/biopax-level3.owl#RnaRegion"

/// Create a properly-wrapped Component reference
let Component (uri:Uri) (refCompUri:Uri) (roles:Uri list) =
    SBOLProvider.Component(
        SBOLProvider.Component2(
            uri,
            SBOLProvider.Access("http://sbols.org/v2#private"),
            SBOLProvider.Definition(refCompUri),
            roles |> List.map SBOLProvider.Role2 |> Array.ofList))

type TopLevel =
    | CompDef of SBOLProvider.ComponentDefinition
    | Seq of SBOLProvider.Sequence2

// --- Helper types for working at a higher level ---
// Ideally, nothing outside this module should actually touch SBOLProvider,
// as its generated types will change if we expand the trainer example.
// The types below represent a higher-level interface which can be expaneded
// into SBOL.

type Identity =
   {identity:Uri;
    name:string option;
    description:string option;}

type Orientation = | FWD | REV
    with
    member x.toString() = match x with | FWD -> "FWD" | REV -> "REV"
    member x.toChar() = match x with | FWD -> '0' | REV -> '1' 

type RangeLocation = {start:int; stop:int; orient:Orientation}
    with
    member x.emit() =
        SBOLProvider.Location(
            SBOLProvider.Range(
                uri.createTempUri(),
                x.start,
                x.stop,
                SBOLProvider.Orientation(
                    match x.orient with
                    | FWD -> "http://sbols.org/v2#inline"
                    | REV -> "http://sbols.org/v2#reverseComplement")))


type Sequence = {id:Identity; elements:string}
    with
    member x.emit() =
        SBOLProvider.Sequence2(x.id.identity, x.elements, SBOLProvider.Encoding(defaultEncoding))

/// Create a new Sequence type from dna.
let seqFromDna (dna: Dna) =
    {id = {identity = uri.createTempUri(); name = None; description = None};
     elements = dna.str}

type Location =
    | Range of RangeLocation
    | Precede of SubcomponentIntegration

and ComponentDefinition =
   {id:Identity;
    roles:Uri list;
    sequence:Sequence option;
    subcomponents:SubcomponentIntegration list;
    gslProg:string option}
    with
    /// Emit all top-level SBOL XML objects representing this entity.
    member x.emit() =
        // create all of the references and annotations
        let (compRefs, seqAnns, seqCons) =
            x.subcomponents |> List.fold (fun (cr, sa, sc) subcomp ->
                let cR, sAs, sCs = subcomp.emit()
                cR::cr, sAs@sa, sCs@sc)
                ([], [], [])

        let maybeCompSeq =
            match x.sequence with
            | Some(s) -> Some(s.emit())
            | None -> None
             
        let comp =
            SBOLProvider.ComponentDefinition(
                x.id.identity,
                x.id.name,
                x.id.description,
                (match maybeCompSeq with
                 | Some(s)-> Some(SBOLProvider.Sequence(s.About))
                 | None -> None),
                SBOLProvider.Type(dnaType),
                (x.roles |> Seq.map SBOLProvider.Role |> Array.ofSeq),
                compRefs |> Array.ofList,
                seqAnns |> Array.ofList,
                seqCons |> Array.ofList,
                // TODO: actually retrieve a GSL language version string!
                (match x.gslProg with
                 | Some(p) -> Some(SBOLProvider.GslProgram(p, "TODO VERSION STRING"))
                 | None -> None))
        match maybeCompSeq with
        | Some(s)-> [Seq(s); CompDef(comp)]
        | None -> [CompDef(comp)]
        

    /// Helper function to create a subcomponent reference to this CD.
    member x.asSubcomponent(locations, roles) =
        {identity = uri.createTempUri();
         compRef = x;
         locations = locations;
         roles = roles}

     
and SubcomponentIntegration =
   {identity:Uri;
    compRef:ComponentDefinition;
    locations:Location list;
    roles:Uri list}
    with
    /// Emit all SBOL objects needed to represent this subcomponent integration.
    member x.emit() =
        // build up lists of sequence annotations and constraints as necessary
        let mutable seqAnns, seqCons = [], []
        for location in x.locations do
            match location with
            | Range(rl) ->
                seqAnns <-
                    (SequenceAnnotation (uri.createTempUri()) x.identity (rl.emit()) (x.roles))
                    ::seqAnns
            | Precede(si) ->
                seqCons <-
                    (SequenceConstraint (uri.createTempUri()) Precedes (x.identity) (si.identity))
                    ::seqCons
        // only put roles on the Component if there are no SequenceAnnotations
        let compRoles = if seqAnns.IsEmpty then x.roles else []
        let comp = Component x.identity (x.compRef.id.identity) compRoles
        (comp, seqAnns, seqCons)

/// Convert a pile o' ComponentDefinitions into a full-blown GBoM.
let compileGbom (compDefs:seq<ComponentDefinition>) =
    let topLevels = compDefs |> Seq.collect (fun cd -> cd.emit()) |> List.ofSeq
    let rec collectTopLevels (tls:TopLevel list) seqs cds =
        match tls with
        | tl::tail ->
            match tl with
            | CompDef(cd) -> collectTopLevels tail seqs (cd::cds)
            | Seq(s)-> collectTopLevels tail (s::seqs) cds
        | [] -> seqs, cds
    let seqs, cds = collectTopLevels topLevels [] []
    SBOLProvider.Gbom( [| for x in cds -> upcast x|] , [| for x in seqs -> upcast x |])



// --- Roles ---

let roleUriBase = unwrap (addNamespaces uri.amyrisUriBase ["Role"])

let addTermToNamespaceStatic ns term = unwrap (addTermToNamespace ns term)

// --- static URI definitions ---
let ryseLinkerRoleUri = addTermToNamespaceStatic roleUriBase "RYSELinker"
let fivePrimeLinkerRoleUri = addTermToNamespaceStatic roleUriBase "RYSELinker_5prime"
let threePrimeLinkerRoleUri = addTermToNamespaceStatic roleUriBase "RYSELinker_3prime"

let primerTailRoleUri = addTermToNamespaceStatic roleUriBase "PrimerTail"
let primerBodyRoleUri = addTermToNamespaceStatic roleUriBase "PrimerBody"
let ampPrimerRoleUri = addTermToNamespaceStatic roleUriBase "AmplificationPrimer"

let quickchangePrimerRoleUri = addTermToNamespaceStatic roleUriBase "QuickchangePrimer"

let fivePrimePrimerRoleUri = addTermToNamespaceStatic roleUriBase "Primer_5prime"
let threePrimePrimerRoleUri = addTermToNamespaceStatic roleUriBase "Primer_3prime"


// --- legacy top-level-component-related roles

let rabitRoleUri = addTermToNamespaceStatic roleUriBase "Rabit"

let rabitDnaRoleUri = addTermToNamespaceStatic roleUriBase "RabitDNAElement"

let stitchRoleUri = addTermToNamespaceStatic roleUriBase "Stitch"

let stitchRabitRoleUri = addTermToNamespaceStatic roleUriBase "StitchRabit"

let megastitchRoleUri = addTermToNamespaceStatic roleUriBase "Megastitch"

let rabitBreedUriBase = unwrap (addNamespaces roleUriBase ["RabitBreed"])

let rabitBreedRole breed = unwrap (addTermToNamespace rabitBreedUriBase breed)
