namespace SkosEditor
{
    using System.Collections.Generic;
    using VDS.RDF;
    using VDS.RDF.Dynamic;

    public class ConceptScheme : SkosDynamicNode
    {
        public ConceptScheme(INode node)
            : base(node)
        {
        }

        public ICollection<string> Definition => new DynamicObjectCollection<string>(this, "definition");

        public ICollection<string> EditorialNote => new DynamicObjectCollection<string>(this, "editorialNote");

        public ICollection<Concept> HasTopConcept => new DynamicObjectCollection<Concept>(this, "hasTopConcept");

        public ICollection<string> Notation => new DynamicObjectCollection<string>(this, "notation");

        public ICollection<string> ScopeNote => new DynamicObjectCollection<string>(this, "scopeNote");
    }
}