namespace SkosEditor
{
    using System;
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;
    using VDS.RDF.Skos;

    public class SkosDynamicGraph : DynamicGraph
    {
        public SkosDynamicGraph(IGraph graph, Uri subjectBaseUri)
            : base(graph, subjectBaseUri, new Uri(SkosHelper.Namespace))
        {
        }

        public ICollection<Collection> CollectionCollection => new DynamicSubjectCollection<Collection>("rdf:type", this[SkosHelper.Collection] as DynamicNode);

        public ICollection<Concept> ConceptCollection => new DynamicSubjectCollection<Concept>("rdf:type", this[SkosHelper.Concept] as DynamicNode);

        public ICollection<ConceptScheme> ConceptSchemeCollection => new DynamicSubjectCollection<ConceptScheme>("rdf:type", this[SkosHelper.ConceptScheme] as DynamicNode);

        // TODO: support hash URIs
        public string GetId(IUriNode node) => this.SubjectBaseUri.MakeRelativeUri(node.Uri).ToString();
    }
}