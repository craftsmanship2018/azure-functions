using Microsoft.AspNetCore.Mvc;

namespace Craftathon.WebUI.Controllers
{
    public class ExampleController : Controller
    {
        [Route("/example/http-trigger")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("../Examples/HttpTrigger");
        }
    }
}