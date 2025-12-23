using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class CloudComputingController : Controller
    {
        [Route("Azure-DevOps-Engineering")]
        public IActionResult AzureDevOps()
        {
            return View();
        }
        [Route("AWS-DevOps-Engineering")]
        public IActionResult AWSDevOps()
        {
            return View();
        }
      
        [Route("Google-DevOps-Engineering")]
        public IActionResult GoogleDevOps()
        {
            return View();
        }
    }
}
