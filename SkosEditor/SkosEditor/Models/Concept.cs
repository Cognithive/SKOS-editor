namespace SkosEditor
{
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class Concept : SkosDynamicNode
    {
        public Concept(INode node)
            : base(node)
        {
        }

        public ICollection<Concept> Broader => new DynamicObjectCollection<Concept>(this, "broader");

        public ICollection<string> Definition => new DynamicObjectCollection<string>(this, "definition");

        public ICollection<string> EditorialNote => new DynamicObjectCollection<string>(this, "editorialNote");

        public ICollection<string> HistoryNote => new DynamicObjectCollection<string>(this, "historyNote");

        public ICollection<ConceptScheme> InScheme => new DynamicObjectCollection<ConceptScheme>(this, "inScheme");

        public ICollection<Concept> Narrower => new DynamicObjectCollection<Concept>(this, "narrower");

        public ICollection<string> Notation => new DynamicObjectCollection<string>(this, "notation");

        public ICollection<Collection> Parent => new DynamicSubjectCollection<Collection>("member", this);

        public ICollection<Concept> Related => new DynamicObjectCollection<Concept>(this, "related");

        public ICollection<string> ScopeNote => new DynamicObjectCollection<string>(this, "scopeNote");

        public ICollection<ConceptScheme> TopConceptOf => new DynamicObjectCollection<ConceptScheme>(this, "topConceptOf");
    }
}