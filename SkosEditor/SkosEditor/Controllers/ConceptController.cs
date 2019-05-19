namespace SkosEditor
{
    using Microsoft.AspNetCore.Mvc;

    [Route("/Concept/")]
    public class ConceptController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
