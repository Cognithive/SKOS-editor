namespace SkosEditor
{
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;
    using VDS.RDF.Skos;

    public class SkosDynamicNode : DynamicNode
    {
        public SkosDynamicNode(INode node)
            : base(node, new Uri(SkosHelper.Namespace))
        {
        }

        // This doesn't work because the Graph of the dynamic node is not the dynamic graph
        // public new SkosDynamicGraph Graph => base.Graph as SkosDynamicGraph;

        // TODO: Support for hash URIs
        // public string Id => this.Graph.SubjectBaseUri.MakeRelativeUri(((IUriNode)this).Uri).ToString();

        public ICollection<ILiteralNode> PrefLabel => new DynamicObjectCollection<ILiteralNode>(this, "prefLabel");
    }
}