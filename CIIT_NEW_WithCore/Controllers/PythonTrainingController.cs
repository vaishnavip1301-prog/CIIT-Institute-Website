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
        [Route("Python-Full-Stack-Development--With-Aws-Training-With-Live-Project")]
        public IActionResult PythonFullStrackDevelopomentWithAws()
        {
            return View();
        }
        [Route("Python-Full-Stack-Development--With-Aws-Ai-Training-With-Live-Project")]
        public IActionResult PythonFullStrackDevelopomentWithAwsAi()
        {
            return View();
        }

        [Route("Python-Web-Training")]
        public IActionResult PythonWebTraining()
        {
            return View();

        }
        [Route("Python-Dejango-Flask-Reactjs-Web-Training")]
        public IActionResult DjangoFlaskReactJs()
        {
            return View();

        }
        [Route("Python-Dejango-Flask-Angular-Web-Training")]
        public IActionResult DjangoFlaskAngular()
        {
            return View();

        }

    }
}
