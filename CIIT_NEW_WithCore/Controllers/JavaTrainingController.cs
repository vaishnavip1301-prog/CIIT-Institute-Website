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
        [Route("Java-Full-Stack-Development-Training-With-Live-Project")]
        public IActionResult JavaFullStrackDevelopment()
        {
            return View();
        }
        [Route("Java-Full-Stack-Development-With-Aws-Training-With-Live-Project")]
        public IActionResult JavaFullStrackDevelopmentWithAws()
        {
            return View();
        }
        [Route("Java-Full-Stack-Development-With-Aws-Ai-Training-With-Live-Project")]
        public IActionResult JavaFullStrackDevelopmentWithAwsAi()
        {
            return View();
        }
        [Route("Java-Training")]
        
        public IActionResult JavaTraining()
        {
            return View();
        }
        [Route("Advance-Java-Training-For-Professionals")]
        public IActionResult AdvanceJavaTraining()
        {
            return View();
        }
        [Route("Spring-Boot-With-ReactJs-Training-With-Live-Project")]
        public IActionResult SpringBootWithReactJs()
        {
            return View();
        }
        [Route("Spring-Boot-With-Angular-Training-With-Live-Project")]
        public IActionResult SpringBootWithAngular()
        {
            return View();
        }
    }
}
