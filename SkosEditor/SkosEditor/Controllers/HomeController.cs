namespace SkosEditor
{
    using Microsoft.AspNetCore.Mvc;

    [Route("/")]
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
