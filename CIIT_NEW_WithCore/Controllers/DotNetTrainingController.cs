using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DotNetTrainingController : Controller
    {
        [Route("Dot-Net-Training-With-Live-Project")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Dot-Net-Full-Strack-Development-Training-With-Live-Project")]
        public IActionResult FullStackDevelopment()
        {
            return View();
        }
        [Route("Dot-Net-Full-Strack-Development-With-Azure-Training-With-Live-Project")]
        public IActionResult FullStackDevelopmentWithAzure()
        {
            return View();
        }
        [Route("Dot-Net-Full-Strack-Development-With-Azure-Ai-Training-With-Live-Project")]
        public IActionResult FullStackDevelopmentWithAzureAi()
        {
            return View();
        }
        [Route("Dot-Net-Full-Training")]
        public IActionResult DotNetTraining()
        {
            return View();
        }
        [Route("Advance-Dot-Net-Full-Training-For-Professionals")]
        public IActionResult AdvanceDotNetTraining()
        {
            return View();
        }
        [Route("Dot-Net-With-Angular-Training")]
        public IActionResult DotNetTrainingAngular()
        {
            return View();
        }
        [Route("Dot-Net-With-React-Training")]
        public IActionResult DotNetTrainingReact()
        {
            return View();
        }
    }
}
