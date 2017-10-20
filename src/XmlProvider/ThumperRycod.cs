namespace rycodExample
{
    public static partial class ThumperRycod
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://thumper.amyris.local", IsNullable = false)]
        public partial class ryseComponentRequest
        {

            private ryseComponentRequestRabitSpec[] rabitSpecField;

            private ryseComponentRequestStitchSpec[] stitchSpecField;

            private ryseComponentRequestMegastitchSpec[] megastitchSpecField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("rabitSpec")]
            public ryseComponentRequestRabitSpec[] rabitSpec
            {
                get
                {
                    return this.rabitSpecField;
                }
                set
                {
                    this.rabitSpecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("stitchSpec")]
            public ryseComponentRequestStitchSpec[] stitchSpec
            {
                get
                {
                    return this.stitchSpecField;
                }
                set
                {
                    this.stitchSpecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("megastitchSpec")]
            public ryseComponentRequestMegastitchSpec[] megastitchSpec
            {
                get
                {
                    return this.megastitchSpecField;
                }
                set
                {
                    this.megastitchSpecField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestRabitSpec
        {

            private ryseComponentRequestRabitSpecDnaElementSpec[] dnaElementSpecField;

            private string nameField;

            private string breedField;

            private string upstreamLinkField;

            private string downstreamLinkField;

            private string directionField;

            private string idField;

            private string creatorField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("dnaElementSpec")]
            public ryseComponentRequestRabitSpecDnaElementSpec[] dnaElementSpec
            {
                get
                {
                    return this.dnaElementSpecField;
                }
                set
                {
                    this.dnaElementSpecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string breed
            {
                get
                {
                    return this.breedField;
                }
                set
                {
                    this.breedField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string upstreamLink
            {
                get
                {
                    return this.upstreamLinkField;
                }
                set
                {
                    this.upstreamLinkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string downstreamLink
            {
                get
                {
                    return this.downstreamLinkField;
                }
                set
                {
                    this.downstreamLinkField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string direction
            {
                get
                {
                    return this.directionField;
                }
                set
                {
                    this.directionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string creator
            {
                get
                {
                    return this.creatorField;
                }
                set
                {
                    this.creatorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestRabitSpecDnaElementSpec
        {

            private ryseComponentRequestRabitSpecDnaElementSpecUpstreamPrimerSpec upstreamPrimerSpecField;

            private ryseComponentRequestRabitSpecDnaElementSpecDownstreamPrimerSpec downstreamPrimerSpecField;

            private string dnaSequenceField;

            private ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpec quickChangeSpecField;

            private string speciesVariantField;

            /// <remarks/>
            public ryseComponentRequestRabitSpecDnaElementSpecUpstreamPrimerSpec upstreamPrimerSpec
            {
                get
                {
                    return this.upstreamPrimerSpecField;
                }
                set
                {
                    this.upstreamPrimerSpecField = value;
                }
            }

            /// <remarks/>
            public ryseComponentRequestRabitSpecDnaElementSpecDownstreamPrimerSpec downstreamPrimerSpec
            {
                get
                {
                    return this.downstreamPrimerSpecField;
                }
                set
                {
                    this.downstreamPrimerSpecField = value;
                }
            }

            /// <remarks/>
            public string dnaSequence
            {
                get
                {
                    return this.dnaSequenceField;
                }
                set
                {
                    this.dnaSequenceField = value;
                }
            }

            /// <remarks/>
            public ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpec quickChangeSpec
            {
                get
                {
                    return this.quickChangeSpecField;
                }
                set
                {
                    this.quickChangeSpecField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string speciesVariant
            {
                get
                {
                    return this.speciesVariantField;
                }
                set
                {
                    this.speciesVariantField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestRabitSpecDnaElementSpecUpstreamPrimerSpec
        {

            private string tailField;

            private string bodyField;

            /// <remarks/>
            public string tail
            {
                get
                {
                    return this.tailField;
                }
                set
                {
                    this.tailField = value;
                }
            }

            /// <remarks/>
            public string body
            {
                get
                {
                    return this.bodyField;
                }
                set
                {
                    this.bodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestRabitSpecDnaElementSpecDownstreamPrimerSpec
        {

            private string tailField;

            private string bodyField;

            /// <remarks/>
            public string tail
            {
                get
                {
                    return this.tailField;
                }
                set
                {
                    this.tailField = value;
                }
            }

            /// <remarks/>
            public string body
            {
                get
                {
                    return this.bodyField;
                }
                set
                {
                    this.bodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpec
        {

            private ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpecForwardPrimerSpec forwardPrimerSpecField;

            private ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpecReversePrimerSpec reversePrimerSpecField;

            /// <remarks/>
            public ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpecForwardPrimerSpec forwardPrimerSpec
            {
                get
                {
                    return this.forwardPrimerSpecField;
                }
                set
                {
                    this.forwardPrimerSpecField = value;
                }
            }

            /// <remarks/>
            public ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpecReversePrimerSpec reversePrimerSpec
            {
                get
                {
                    return this.reversePrimerSpecField;
                }
                set
                {
                    this.reversePrimerSpecField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpecForwardPrimerSpec
        {

            private string tailField;

            private string bodyField;

            /// <remarks/>
            public string tail
            {
                get
                {
                    return this.tailField;
                }
                set
                {
                    this.tailField = value;
                }
            }

            /// <remarks/>
            public string body
            {
                get
                {
                    return this.bodyField;
                }
                set
                {
                    this.bodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestRabitSpecDnaElementSpecQuickChangeSpecReversePrimerSpec
        {

            private string tailField;

            private string bodyField;

            /// <remarks/>
            public string tail
            {
                get
                {
                    return this.tailField;
                }
                set
                {
                    this.tailField = value;
                }
            }

            /// <remarks/>
            public string body
            {
                get
                {
                    return this.bodyField;
                }
                set
                {
                    this.bodyField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestStitchSpec
        {

            private ryseComponentRequestStitchSpecRabitRef[] rabitRefField;

            private string idField;

            private string creatorField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("rabitRef")]
            public ryseComponentRequestStitchSpecRabitRef[] rabitRef
            {
                get
                {
                    return this.rabitRefField;
                }
                set
                {
                    this.rabitRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string creator
            {
                get
                {
                    return this.creatorField;
                }
                set
                {
                    this.creatorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestStitchSpecRabitRef
        {

            private string rabitSpecField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string rabitSpec
            {
                get
                {
                    return this.rabitSpecField;
                }
                set
                {
                    this.rabitSpecField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestMegastitchSpec
        {

            private ryseComponentRequestMegastitchSpecStitchRef[] stitchRefField;

            private string idField;

            private string creatorField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("stitchRef")]
            public ryseComponentRequestMegastitchSpecStitchRef[] stitchRef
            {
                get
                {
                    return this.stitchRefField;
                }
                set
                {
                    this.stitchRefField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string creator
            {
                get
                {
                    return this.creatorField;
                }
                set
                {
                    this.creatorField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://thumper.amyris.local")]
        public partial class ryseComponentRequestMegastitchSpecStitchRef
        {

            private string stitchSpecField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string stitchSpec
            {
                get
                {
                    return this.stitchSpecField;
                }
                set
                {
                    this.stitchSpecField = value;
                }
            }
        }
    }
}
