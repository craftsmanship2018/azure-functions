using Microsoft.AspNetCore.Mvc;

namespace Craftathon.WebUI.Controllers
{
    public class AboutController : Controller
    {
        [Route("/about")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("../About");
        }
    }
}