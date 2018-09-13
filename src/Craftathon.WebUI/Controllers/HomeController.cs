using Microsoft.AspNetCore.Mvc;

namespace Craftathon.WebUI.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("../Index");
        }
    }
}