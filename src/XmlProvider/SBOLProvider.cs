namespace XmlProvider
{
    public class SBOLProvider
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0", IsNullable = false)]
        public partial class gbom
        {

            private ComponentDefinition[] componentDefinitionField;

            private Sequence[] sequenceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("ComponentDefinition", Namespace = "http://sbols.org/v2#")]
            public ComponentDefinition[] ComponentDefinition
            {
                get
                {
                    return this.componentDefinitionField;
                }
                set
                {
                    this.componentDefinitionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("Sequence", Namespace = "http://sbols.org/v2#")]
            public Sequence[] Sequence
            {
                get
                {
                    return this.sequenceField;
                }
                set
                {
                    this.sequenceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://sbols.org/v2#", IsNullable = false)]
        public partial class ComponentDefinition
        {

            private string titleField;

            private string descriptionField;

            private ComponentDefinitionSequence sequenceField;

            private ComponentDefinitionType typeField;

            private ComponentDefinitionRole[] roleField;

            private ComponentDefinitionComponent[] componentField;

            private ComponentDefinitionSequenceAnnotation[] sequenceAnnotationField;

            private ComponentDefinitionSequenceConstraint[] sequenceConstraintField;

            private gslProgram gslProgramField;

            private string aboutField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/terms/")]
            public string title
            {
                get
                {
                    return this.titleField;
                }
                set
                {
                    this.titleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://purl.org/dc/terms/")]
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }

            /// <remarks/>
            public ComponentDefinitionSequence sequence
            {
                get
                {
                    return this.sequenceField;
                }
                set
                {
                    this.sequenceField = value;
                }
            }

            /// <remarks/>
            public ComponentDefinitionType type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("role")]
            public ComponentDefinitionRole[] role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("component")]
            public ComponentDefinitionComponent[] component
            {
                get
                {
                    return this.componentField;
                }
                set
                {
                    this.componentField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("sequenceAnnotation")]
            public ComponentDefinitionSequenceAnnotation[] sequenceAnnotation
            {
                get
                {
                    return this.sequenceAnnotationField;
                }
                set
                {
                    this.sequenceAnnotationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("sequenceConstraint")]
            public ComponentDefinitionSequenceConstraint[] sequenceConstraint
            {
                get
                {
                    return this.sequenceConstraintField;
                }
                set
                {
                    this.sequenceConstraintField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0")]
            public gslProgram gslProgram
            {
                get
                {
                    return this.gslProgramField;
                }
                set
                {
                    this.gslProgramField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string about
            {
                get
                {
                    return this.aboutField;
                }
                set
                {
                    this.aboutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequence
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionType
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionRole
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionComponent
        {

            private ComponentDefinitionComponentComponent componentField;

            /// <remarks/>
            public ComponentDefinitionComponentComponent Component
            {
                get
                {
                    return this.componentField;
                }
                set
                {
                    this.componentField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionComponentComponent
        {

            private ComponentDefinitionComponentComponentAccess accessField;

            private ComponentDefinitionComponentComponentDefinition definitionField;

            private role[] roleField;

            private string aboutField;

            /// <remarks/>
            public ComponentDefinitionComponentComponentAccess access
            {
                get
                {
                    return this.accessField;
                }
                set
                {
                    this.accessField = value;
                }
            }

            /// <remarks/>
            public ComponentDefinitionComponentComponentDefinition definition
            {
                get
                {
                    return this.definitionField;
                }
                set
                {
                    this.definitionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("role", Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0")]
            public role[] role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string about
            {
                get
                {
                    return this.aboutField;
                }
                set
                {
                    this.aboutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionComponentComponentAccess
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionComponentComponentDefinition
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0", IsNullable = false)]
        public partial class role
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceAnnotation
        {

            private ComponentDefinitionSequenceAnnotationSequenceAnnotation sequenceAnnotationField;

            /// <remarks/>
            public ComponentDefinitionSequenceAnnotationSequenceAnnotation SequenceAnnotation
            {
                get
                {
                    return this.sequenceAnnotationField;
                }
                set
                {
                    this.sequenceAnnotationField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceAnnotationSequenceAnnotation
        {

            private ComponentDefinitionSequenceAnnotationSequenceAnnotationComponent componentField;

            private ComponentDefinitionSequenceAnnotationSequenceAnnotationLocation locationField;

            private role[] roleField;

            private string aboutField;

            /// <remarks/>
            public ComponentDefinitionSequenceAnnotationSequenceAnnotationComponent component
            {
                get
                {
                    return this.componentField;
                }
                set
                {
                    this.componentField = value;
                }
            }

            /// <remarks/>
            public ComponentDefinitionSequenceAnnotationSequenceAnnotationLocation location
            {
                get
                {
                    return this.locationField;
                }
                set
                {
                    this.locationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("role", Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0")]
            public role[] role
            {
                get
                {
                    return this.roleField;
                }
                set
                {
                    this.roleField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string about
            {
                get
                {
                    return this.aboutField;
                }
                set
                {
                    this.aboutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceAnnotationSequenceAnnotationComponent
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceAnnotationSequenceAnnotationLocation
        {

            private ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRange rangeField;

            /// <remarks/>
            public ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRange Range
            {
                get
                {
                    return this.rangeField;
                }
                set
                {
                    this.rangeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRange
        {

            private byte startField;

            private byte endField;

            private ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRangeOrientation orientationField;

            private string aboutField;

            /// <remarks/>
            public byte start
            {
                get
                {
                    return this.startField;
                }
                set
                {
                    this.startField = value;
                }
            }

            /// <remarks/>
            public byte end
            {
                get
                {
                    return this.endField;
                }
                set
                {
                    this.endField = value;
                }
            }

            /// <remarks/>
            public ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRangeOrientation orientation
            {
                get
                {
                    return this.orientationField;
                }
                set
                {
                    this.orientationField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string about
            {
                get
                {
                    return this.aboutField;
                }
                set
                {
                    this.aboutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceAnnotationSequenceAnnotationLocationRangeOrientation
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceConstraint
        {

            private ComponentDefinitionSequenceConstraintSequenceConstraint sequenceConstraintField;

            /// <remarks/>
            public ComponentDefinitionSequenceConstraintSequenceConstraint SequenceConstraint
            {
                get
                {
                    return this.sequenceConstraintField;
                }
                set
                {
                    this.sequenceConstraintField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceConstraintSequenceConstraint
        {

            private ComponentDefinitionSequenceConstraintSequenceConstraintRestriction restrictionField;

            private ComponentDefinitionSequenceConstraintSequenceConstraintSubject subjectField;

            private ComponentDefinitionSequenceConstraintSequenceConstraintObject objectField;

            private string aboutField;

            /// <remarks/>
            public ComponentDefinitionSequenceConstraintSequenceConstraintRestriction restriction
            {
                get
                {
                    return this.restrictionField;
                }
                set
                {
                    this.restrictionField = value;
                }
            }

            /// <remarks/>
            public ComponentDefinitionSequenceConstraintSequenceConstraintSubject subject
            {
                get
                {
                    return this.subjectField;
                }
                set
                {
                    this.subjectField = value;
                }
            }

            /// <remarks/>
            public ComponentDefinitionSequenceConstraintSequenceConstraintObject @object
            {
                get
                {
                    return this.objectField;
                }
                set
                {
                    this.objectField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string about
            {
                get
                {
                    return this.aboutField;
                }
                set
                {
                    this.aboutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceConstraintSequenceConstraintRestriction
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceConstraintSequenceConstraintSubject
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class ComponentDefinitionSequenceConstraintSequenceConstraintObject
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.amyris.com/xmlns/gbom/v0.2.0", IsNullable = false)]
        public partial class gslProgram
        {

            private string gslSourceField;

            private string gslVersionField;

            /// <remarks/>
            public string gslSource
            {
                get
                {
                    return this.gslSourceField;
                }
                set
                {
                    this.gslSourceField = value;
                }
            }

            /// <remarks/>
            public string gslVersion
            {
                get
                {
                    return this.gslVersionField;
                }
                set
                {
                    this.gslVersionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://sbols.org/v2#", IsNullable = false)]
        public partial class Sequence
        {

            private string elementsField;

            private SequenceEncoding encodingField;

            private string aboutField;

            /// <remarks/>
            public string elements
            {
                get
                {
                    return this.elementsField;
                }
                set
                {
                    this.elementsField = value;
                }
            }

            /// <remarks/>
            public SequenceEncoding encoding
            {
                get
                {
                    return this.encodingField;
                }
                set
                {
                    this.encodingField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string about
            {
                get
                {
                    return this.aboutField;
                }
                set
                {
                    this.aboutField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://sbols.org/v2#")]
        public partial class SequenceEncoding
        {

            private string resourceField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/1999/02/22-rdf-syntax-ns#")]
            public string resource
            {
                get
                {
                    return this.resourceField;
                }
                set
                {
                    this.resourceField = value;
                }
            }
        }
    }
}