namespace global

open FSharp.Data

// NOTE: see helper functions below.  Dammit SBOL, why did you decide to wrap
// every XML tag inside another XML tag...

type SBOLProvider =
    FSharp.Data.XmlProvider<"""
<gbom:gbom xmlns:gbom="http://www.amyris.com/xmlns/gbom/v0.2.0" xmlns:sbol="http://sbols.org/v2#" xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#" xmlns:dcterms="http://purl.org/dc/terms/" xmlns:prov="http://www.w3.org/ns/prov#">
  <sbol:ComponentDefinition rdf:about="http://amyris.com/GBoM/Component#156">
    <dcterms:title>parent</dcterms:title>
    <dcterms:description>a description</dcterms:description>
    <sbol:sequence rdf:resource="http://amyris.com/GBoM/ComponentSequence#120"/>
    <sbol:type rdf:resource="http://www.biopax.org/release/biopax-level3.owl#DnaRegion"/>
    <sbol:role rdf:resource="http://amyris.com/GBoM/Role#Rabit"/>
    <sbol:role rdf:resource="http://amyris.com/GBoM/Role#Stitch"/>
    <sbol:role rdf:resource="http://amyris.com/GBoM/Role#Megastitch"/>
    <sbol:component>
      <sbol:Component rdf:about="http://amyris.com/GBoM/SubcomponentLink#158">
        <sbol:access rdf:resource="http://sbols.org/v2#private"/>
        <sbol:definition rdf:resource="http://amyris.com/GBoM/Component#157"/>
      </sbol:Component>
    </sbol:component>
    <sbol:component>
      <sbol:Component rdf:about="http://amyris.com/GBoM/SubcomponentLink#159">
        <sbol:access rdf:resource="http://sbols.org/v2#private"/>
        <sbol:definition rdf:resource="http://amyris.com/GBoM/Component#158"/>
      </sbol:Component>
    </sbol:component>
    <sbol:component>
      <sbol:Component rdf:about="http://amyris.com/GBoM/SubcomponentLink#160">
        <sbol:access rdf:resource="http://sbols.org/v2#private"/>
        <sbol:definition rdf:resource="http://amyris.com/GBoM/Component#158"/>
      </sbol:Component>
    </sbol:component>
    <sbol:component>
      <sbol:Component rdf:about="http://amyris.com/GBoM/SubcomponentLink#161">
        <sbol:access rdf:resource="http://sbols.org/v2#private"/>
        <sbol:definition rdf:resource="http://amyris.com/GBoM/Component#158"/>
      </sbol:Component>
    </sbol:component>
    <sbol:component>
      <sbol:Component rdf:about="http://amyris.com/GBoM/SubcomponentLink#162">
        <sbol:access rdf:resource="http://sbols.org/v2#private"/>
        <sbol:definition rdf:resource="http://amyris.com/GBoM/Component#158"/>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Rabit"/>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Stitch"/>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Primer_5prime"/>
      </sbol:Component>
    </sbol:component>
    <sbol:sequenceAnnotation>
      <sbol:SequenceAnnotation rdf:about="http://amyris.com/GBoM/SequenceAnnotation#159">
        <sbol:component rdf:resource="http://amyris.com/GBoM/SubcomponentLink#159"/>
        <sbol:location>
          <sbol:Range rdf:about="http://amyris.com/GBoM/Range#159">
            <sbol:start>1</sbol:start>
            <sbol:end>2</sbol:end>
            <sbol:orientation rdf:resource="http://sbols.org/v2#inline"/>
          </sbol:Range>
        </sbol:location>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Rabit"/>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Stitch"/>
      </sbol:SequenceAnnotation>
    </sbol:sequenceAnnotation>
    <sbol:sequenceAnnotation>
      <sbol:SequenceAnnotation rdf:about="http://amyris.com/GBoM/SequenceAnnotation#160">
        <sbol:component rdf:resource="http://amyris.com/GBoM/SubcomponentLink#160"/>
        <sbol:location>
          <sbol:Range rdf:about="http://amyris.com/GBoM/Range#160">
            <sbol:start>2</sbol:start>
            <sbol:end>3</sbol:end>
            <sbol:orientation rdf:resource="http://sbols.org/v2#inline"/>
          </sbol:Range>
        </sbol:location>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Rabit"/>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Stitch"/>
      </sbol:SequenceAnnotation>
    </sbol:sequenceAnnotation>
    <sbol:sequenceAnnotation>
      <sbol:SequenceAnnotation rdf:about="http://amyris.com/GBoM/SequenceAnnotation#161">
        <sbol:component rdf:resource="http://amyris.com/GBoM/SubcomponentLink#161"/>
        <sbol:location>
          <sbol:Range rdf:about="http://amyris.com/GBoM/Range#161">
            <sbol:start>3</sbol:start>
            <sbol:end>4</sbol:end>
            <sbol:orientation rdf:resource="http://sbols.org/v2#inline"/>
          </sbol:Range>
        </sbol:location>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Rabit"/>
        <gbom:role rdf:resource="http://amyris.com/GBoM/Role#Stitch"/>
      </sbol:SequenceAnnotation>
    </sbol:sequenceAnnotation>
    <sbol:sequenceConstraint>
      <sbol:SequenceConstraint rdf:about="http://amyris.com/GBoM/SequenceConstraint#159">
        <sbol:restriction rdf:resource="http://sbols.org/v2#precedes"/>
        <sbol:subject rdf:resource="http://amyris.com/GBoM/SubcomponentLink#159"/>
        <sbol:object rdf:resource="http://amyris.com/GBoM/SubcomponentLink#158"/>
      </sbol:SequenceConstraint>
    </sbol:sequenceConstraint>
    <sbol:sequenceConstraint>
      <sbol:SequenceConstraint rdf:about="http://amyris.com/GBoM/SequenceConstraint#160">
        <sbol:restriction rdf:resource="http://sbols.org/v2#precedes"/>
        <sbol:subject rdf:resource="http://amyris.com/GBoM/SubcomponentLink#160"/>
        <sbol:object rdf:resource="http://amyris.com/GBoM/SubcomponentLink#161"/>
      </sbol:SequenceConstraint>
    </sbol:sequenceConstraint>
    <sbol:sequenceConstraint>
      <sbol:SequenceConstraint rdf:about="http://amyris.com/GBoM/SequenceConstraint#161">
        <sbol:restriction rdf:resource="http://sbols.org/v2#precedes"/>
        <sbol:subject rdf:resource="http://amyris.com/GBoM/SubcomponentLink#161"/>
        <sbol:object rdf:resource="http://amyris.com/GBoM/SubcomponentLink#162"/>
      </sbol:SequenceConstraint>
    </sbol:sequenceConstraint>
    <gbom:gslProgram>
      <gbom:gslSource>GSL ; GSL; GSL</gbom:gslSource>
      <gbom:gslVersion>1.0.0</gbom:gslVersion>
    </gbom:gslProgram>
  </sbol:ComponentDefinition>
  <sbol:ComponentDefinition rdf:about="http://amyris.com/GBoM/Component#157">
    <sbol:type rdf:resource="http://www.biopax.org/release/biopax-level3.owl#DnaRegion"/>
    <sbol:role rdf:resource="http://amyris.com/GBoM/Role#Rabit"/>
  </sbol:ComponentDefinition>
  <sbol:ComponentDefinition rdf:about="http://amyris.com/GBoM/Component#158">
    <dcterms:title>child1</dcterms:title>
    <sbol:sequence rdf:resource="http://amyris.com/GBoM/ComponentSequence#121"/>
    <sbol:type rdf:resource="http://www.biopax.org/release/biopax-level3.owl#DnaRegion"/>
    <sbol:role rdf:resource="http://amyris.com/GBoM/Role#Rabit"/>
    <gbom:gslProgram>
      <gbom:gslSource>VERYSMALLPROGRAM</gbom:gslSource>
      <gbom:gslVersion>1.0.0</gbom:gslVersion>
    </gbom:gslProgram>
  </sbol:ComponentDefinition>
  <sbol:Sequence rdf:about="http://amyris.com/GBoM/ComponentSequence#120">
    <sbol:elements>atcgatcgatcgatcgatcgatcgatcg</sbol:elements>
    <sbol:encoding rdf:resource="http://www.chem.qmul.ac.uk/iubmb/misc/naseq.html"/>
  </sbol:Sequence>
  <sbol:Sequence rdf:about="http://amyris.com/GBoM/ComponentSequence#121">
    <sbol:elements>atcg</sbol:elements>
    <sbol:encoding rdf:resource="http://www.chem.qmul.ac.uk/iubmb/misc/naseq.html"/>
  </sbol:Sequence>
</gbom:gbom>
""">
    //, Global=true>