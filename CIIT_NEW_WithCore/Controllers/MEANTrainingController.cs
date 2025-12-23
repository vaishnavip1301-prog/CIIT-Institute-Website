using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class MEANTrainingController : Controller
    {
        [Route("MEARN-Stack-Training-With-Live-Project")]
        public IActionResult MEAN()
        {
            return View();
        }
        [Route("MEARN-Stack-Development-Training-With-Live-Project")]
        public IActionResult MEANFullStackDevelopment()
        {
            return View();
        }
        [Route("MEARN-Full-Stack-Development-With-AWS-Training-With-Live-Project")]
        public IActionResult MEANFullStackDevelopmentWithAws()
        {
            return View();

        }
        [Route("MEARN-Full-Stack-Development-AWS-And-AI-Training-With-Live-Project")]
        public IActionResult MEANFullStackDevelopmentWithAwsAi()
        {
            return View();

        }
        [Route("NodeJs-Training-With-Live-Project")]
        public IActionResult NodeJs()
        {
            return View();

        }
    }
}
