using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class PythonTrainingController : Controller
    {
        [Route("Python-Training-With-Live-Project")]
        public IActionResult Python()
        {
            return View();
        }
        [Route("Python-Full-Stack-Development-Training-With-Live-Project")]
        public IActionResult PythonFullStrackDevelopoment()
        {
            return View();
        }
        [Route("Python-Full-Stack-Development-With-Aws-Training-With-Live-Project")]
        public IActionResult PythonFullStrackDevelopomentWithAws()
        {
            return View();
        }
        [Route("Python-Full-Stack-Development-With-Aws-AI-Training-With-Live-Project")]
        public IActionResult PythonFullStrackDevelopomentWithAwsAi()
        {
            return View();
        }

        [Route("Python-Django-FastApi-Training-For-Working-Professionals")]
        public IActionResult PythonWebTraining()
        {
            return View();
        }
        [Route("Python-DJango-FastApi-With-React-Training")]
        public IActionResult DjangoFlaskReactJs()
        {
            return View();
        }
        [Route("Python-DJango-FastApi-With-Angular-Training")]
        public IActionResult DjangoFlaskAngular()
        {
            return View();
        }

    }
}
