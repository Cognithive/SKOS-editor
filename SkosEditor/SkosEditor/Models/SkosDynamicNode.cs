namespace SkosEditor
{
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;
    using VDS.RDF.Skos;

    /// <summary>
    /// Dynamic access to all properties defined by skos with no specific domain.
    /// Lexical labels skos:prefLabel, skos:altLabel and skos:hiddenLabel:
    /// - are instances of owl:AnnotationProperty
    /// - are sub-properties of rdfs:label
    /// - have the class of RDF plain literals for rdfs:range
    /// - have the rdfs:Resource, the class of all resources for rdfs:domain
    /// - are pairwise disjoint properties
    ///
    /// A resource has no more than one value of skos:prefLabel per language tag.
    /// TODO: Add resource identifier access.
    /// </summary>
    public class SkosDynamicNode : DynamicNode
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SkosDynamicNode"/> class.
        /// </summary>
        /// <param name="node">The node to wrap.</param>
        public SkosDynamicNode(INode node)
            : base(node, new Uri(SkosHelper.Namespace))
        {
        }

        public ICollection<string> AltLabel => new DynamicObjectCollection<string>(this, "altLabel");

        public ICollection<string> HiddenLabel => new DynamicObjectCollection<string>(this, "hiddenLabel");

        public ICollection<ILiteralNode> PrefLabel => new DynamicObjectCollection<ILiteralNode>(this, "prefLabel");
    }
}