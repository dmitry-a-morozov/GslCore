
namespace rycodExample

module ThumperRycod = 

    type RyseComponentRequest = rycodExample.ThumperRycod.ryseComponentRequest

namespace global 

[<AutoOpen>]
module ThumperRycodExntensions = 

    type rycodExample.ThumperRycod with 
        static member Parse(text: string) =
            Unchecked.defaultof<_>
    
    type rycodExample.ThumperRycod.ryseComponentRequest with    
        member this.RabitSpecs = this.rabitSpec
    
    type rycodExample.ThumperRycod.ryseComponentRequestRabitSpec with    
        member this.DnaElementSpecs = this.dnaElementSpec    

    type rycodExample.ThumperRycod.ryseComponentRequestRabitSpecDnaElementSpec with    
        member this.DnaSequence = this.dnaSequence    

    type rycodExample.ThumperRycod.ryseComponentRequestRabitSpec with    
        member this.Name = this.name    
        member this.Id = this.id
        member this.UpstreamLink = this.upstreamLink
        member this.DownstreamLink = this.downstreamLink
        member this.Direction = this.direction
        member this.Breed = this.breed
        
    type System.String with
        member this.String = Option.ofObj this

[<AutoOpen>]
module SBOLProvider =
    type XmlProvider.SBOLProvider.Sequence with 
        member this.About = this.about 
        
    type Sequence2(about, elements, encoding) = 
        inherit XmlProvider.SBOLProvider.Sequence(
            about = about,
            elements = elements,
            encoding = encoding
        )
        
    type ComponentDefinition(about, title, description, sequence, ``type``, roles, ``component``, sequenceAnnotation, sequenceConstraint, gslProgram) =
        inherit XmlProvider.SBOLProvider.ComponentDefinition(
            about = about,
            title = defaultArg title null,
            description = defaultArg description null,
            sequence = defaultArg sequence null,
            ``type`` = ``type``,
            ``component`` = ``component``,
            role = roles,
            sequenceAnnotation = sequenceAnnotation,
            sequenceConstraint = sequenceConstraint,
            gslProgram = defaultArg gslProgram null
        )


type SBOLProvider = 

    static member Restriction(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraintRestriction(resource = resource)
    
    static member SequenceConstraint2(about, restriction, subject, object) =
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraint(
            about = about,
            restriction = restriction, 
            subject = subject, 
            object = object
        ) 
    
    static member Subject(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraintSubject(resource = resource)
        
    static member Object(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraintObject(resource = resource)
        
    static member SequenceConstraint(sequenceConstraint) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraint(SequenceConstraint = sequenceConstraint)
    
    static member Role3(resource) = 
        XmlProvider.SBOLProvider.role(resource = resource)
                     
    static member Role(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionRole(resource = resource)
        
    static member Role2(resource) = 
        XmlProvider.SBOLProvider.role(resource = resource)
        
    static member SequenceAnnotation2(about, ``component``, location, roles) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotation(
            about = about,
            ``component`` = ``component``,
            location = location,
            role = roles
        )
    
    static member SequenceAnnotation(xs) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotation(SequenceAnnotation = xs)
    
    static member Orientation(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRangeOrientation(resource = resource)
    
    static member Encoding(resource) = 
        XmlProvider.SBOLProvider.SequenceEncoding(resource = resource)
        
    static member Range(about, start: int, ``end``: int, orientation) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRange(
            about = about,
            start = byte start,
            ``end`` = byte ``end``,
            orientation = orientation
        )
             
    static member Location(range) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationLocation(Range = range)
             
    static member Sequence(about) =
        XmlProvider.SBOLProvider.ComponentDefinitionSequence(resource = about)
        
    static member Component3(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationComponent(resource = resource)
        
    static member Component2(about, access, definition, roles) = 
        XmlProvider.SBOLProvider.ComponentDefinitionComponentComponent(
            about = about,
            access = access,
            definition = definition,
            role = roles
        )
    
    static member Component(``component``) = 
        XmlProvider.SBOLProvider.ComponentDefinitionComponent(Component = ``component``)
      
    static member Type(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionType(resource = resource)

    static member Access(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionComponentComponentAccess(resource = resource)

    static member Definition(resource) = 
        XmlProvider.SBOLProvider.ComponentDefinitionComponentComponentDefinition(resource = resource)
        
    static member GslProgram(gslSource, gslVersion) = 
        XmlProvider.SBOLProvider.gslProgram(gslSource = gslSource, gslVersion = gslVersion)
        
    static member Gbom(componentDefinition, sequence) = 
        XmlProvider.SBOLProvider.gbom(ComponentDefinition = componentDefinition, Sequence = sequence)
        
        

//namespace SBOLProvider
//
//open XmlProvider
//
//type Restriction(resource) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraintRestriction(resource = resource)
//    
//type SequenceConstraint2(about, restriction: Restriction, subject, object) =
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraint(
//        about = about,
//        restriction = restriction, 
//        subject = subject, 
//        object = object
//    ) 
//    
//type Subject(resource) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraintSubject(resource = resource)
//    
//type Object(resource) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraintSequenceConstraintObject(resource = resource)
//    
//type SequenceConstraint(sequenceConstraint) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceConstraint(SequenceConstraint = sequenceConstraint)
//
//type Role3(resource) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionRole(resource = resource)
//                 
//type SequenceAnnotation2(about, ``component``, location, roles) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotation(
//        about = about,
//        ``component`` = ``component``,
//        location = location,
//        role = roles
//    )
//
//type SequenceAnnotation(xs) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotation(SequenceAnnotation = xs)
//
//type Orientation(resource) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRangeOrientation(resource = resource)
//
//type Encoding(resource) = 
//    inherit XmlProvider.SBOLProvider.SequenceEncoding(resource = resource)
//    
//type Range(about, start: int, ``end``: int, orientation) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRange(
//        about = about,
//        start = byte start,
//        ``end`` = byte ``end``,
//        orientation = orientation
//    )
//         
//type Location(range) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationLocation(Range = range)
//         
//type Sequence2(about, elements, encoding) =
//    inherit XmlProvider.SBOLProvider.Sequence(
//        about = about,
//        elements = elements,
//        encoding = encoding
//    )
//    
//type ``component``3(resource) = 
//    inherit XmlProvider.SBOLProvider.ComponentDefinitionSequenceAnnotationSequenceAnnotationComponent(resource = resource)
//    
//type ``component``Definition(about, title, description, sequence, ``type``, roles, ``component``, sequenceAnnotation, sequenceConstraint, gslProgram) =
//    inherit XmlProvider.SBOLProvider.ComponentDefinition(
//        about = about,
//        title = defaultArg title null,
//        description = defaultArg description null,
//        sequence = defaultArg sequence null,
//        ``type`` = ``type``,
//        ``component`` = ``component``,
//        role = roles,
//        sequenceAnnotation = sequenceAnnotation,
//        sequenceConstraint = sequenceConstraint,
//        gslProgram = defaultArg gslProgram null
//    )
//    
//      