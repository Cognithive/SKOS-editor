namespace SkosEditor
{
    using Microsoft.AspNetCore.Mvc;

    [Route("/Collection/")]
    public class CollectionController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
