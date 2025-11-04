using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class MEANTrainingController : Controller
    {
        [Route("MEAN-Stack-Training-With-Live-Project")]
        public IActionResult MEAN()
        {
            return View();
        }
        [Route("MEAN-Full-Stack-Development-Training-With-Live-Project")]
        public IActionResult MEANFullStackDevelopment()
        {
            return View();
        }
        [Route("MEAN-Full-Stack-Development-Aws-Training-With-Live-Project")]
        public IActionResult MEANFullStackDevelopmentWithAws()
        {
            return View();

        }
        [Route("MEAN-Full-Stack-Development-Aws-Ai-Training-With-Live-Project")]
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
