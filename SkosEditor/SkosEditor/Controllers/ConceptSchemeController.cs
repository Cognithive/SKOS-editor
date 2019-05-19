namespace SkosEditor
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    [Route("/ConceptScheme/")]
    public class ConceptSchemeController : BaseController
    {
        public ConceptSchemeController(ISparqlNamedQueryService sparqlService, IConfiguration config)
            : base(sparqlService, config)
        {
        }

        [HttpGet]
        public ActionResult Index()
        {
            var graph = this.GetSkosDynamicGraph("ConceptScheme", new Dictionary<string, IEnumerable<object>> { { "id", null } });
            return this.View(graph);
        }

        [HttpGet("{id}")]
        public ActionResult Item(string id)
        {
            return this.View(this.GetSkosDynamicGraph("ConceptScheme", new Dictionary<string, IEnumerable<object>> { { "id", new[] { new Uri(this.SubjectBaseUri, id) } } }));
        }
    }
}
