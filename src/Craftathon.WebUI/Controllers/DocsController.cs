using Microsoft.AspNetCore.Mvc;

namespace Craftathon.WebUI.Controllers
{
    public class DocsController : Controller
    {
        [Route("/docs/continuous-integration")]
        [HttpGet]
        public IActionResult ContinuousIntegration()
        {
            return View("../Docs/ContinuousIntegration");
        }

        [Route("/docs/continuous-deployment")]
        [HttpGet]
        public IActionResult ContinuousDeployment()
        {
            return View("../Docs/ContinuousDeployment");
        }
    }
}