using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DevOpsController : Controller
    {
        [Route("Azure-DevOps-With-AI-Training")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("AWS-DevOps-With-AI-Training")]
        public IActionResult AWSDevOps()
        {
            return View();
        }
        [Route("Google-Cloud-With-AI-DevOps-Training")]
        public IActionResult GCPDevOps()
        {
            return View();
        }
        //[Route("Google-Cloud-DevOps-Training")]
        //public IActionResult GCPDevOps()
        //{
        //    return View();
        //}
    }
}
