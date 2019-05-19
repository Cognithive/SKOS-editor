namespace SkosEditor
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Configuration;

    public class BaseController : Controller
    {
        public BaseController(ISparqlNamedQueryService sparqlService, IConfiguration config)
        {
            this.SubjectBaseUri = new Uri(config.GetSection("Graph")["SubjectBaseUri"]);
            this.SparqlService = sparqlService;
        }

        public Uri SubjectBaseUri { get; }

        public ISparqlNamedQueryService SparqlService { get; }

        public SkosDynamicGraph GetSkosDynamicGraph(string name, IDictionary<string, IEnumerable<object>> parameters = null) => new SkosDynamicGraph(this.SparqlService.GetGraph($"SkosEditor.SPARQL.{name}.sparql", parameters), this.SubjectBaseUri);
    }
}