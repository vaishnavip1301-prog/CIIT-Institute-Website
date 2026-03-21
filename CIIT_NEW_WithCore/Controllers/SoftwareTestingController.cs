using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class SoftwareTestingController : Controller
    {
        [Route("diploma-in-software-testing")]
        public IActionResult DiplomaInSoftwareTesting()
        {
            return View();
        }
        [Route("selenium-testing-with-ai-and-devops")]
        public IActionResult SeleniumTestingWithAIAndDevOps()
        {
            return View();
        }
        [Route("playwright-testing-with-ai-and-devops")]

        public IActionResult PlaywrightTestingWithAIAndDevOps()
        {
            return View();
        }
        [Route("manual-testing")]

        public IActionResult ManualTesting()
        {
            return View();
        }
    }
}
