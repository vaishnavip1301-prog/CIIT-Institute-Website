using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class JavaTrainingController : Controller
    {
        [Route("Java-Training-With-Live-Project")]
        public IActionResult Java()
        {
            return View();
        }
        [Route("Java-Full-Strack-Development-Training-With-Live-Project")]
        public IActionResult JavaFullStrackDevelopment()
        {
            return View();
        }
        [Route("Java-Full-Strack-Development-With-Aws-Training-With-Live-Project")]
        public IActionResult JavaFullStrackDevelopmentWithAws()
        {
            return View();
        }
        [Route("Java-Full-Strack-Development-With-Aws-Ai-Training-With-Live-Project")]
        public IActionResult JavaFullStrackDevelopmentWithAwsAi()
        {
            return View();
        }
        [Route("Java-Training")]
        
        public IActionResult JavaTraining()
        {
            return View();
        }
        [Route("Advance-Java-Training")]
        public IActionResult AdvanceJavaTraining()
        {
            return View();
        }
        [Route("SpringBoot-With-ReactJs-Training-With-Live-Project")]
        public IActionResult SpringBootWithReactJs()
        {
            return View();
        }
        [Route("SpringBoot-With-Angular-Training-With-Live-Project")]
        public IActionResult SpringBootWithAngular()
        {
            return View();
        }
    }
}
