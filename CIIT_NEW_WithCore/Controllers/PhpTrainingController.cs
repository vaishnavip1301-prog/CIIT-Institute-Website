using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class PhpTrainingController : Controller
    {
        [Route("Php-Training-With-Live-Project")]
        public IActionResult Php()
        {
            return View();
        }
        [Route("Php-Full-Stack-Development-Training-With-Live-Project")]
        public IActionResult PhpFullStackDevelopment()
        {
            return View();
        }
        [Route("Php-WordPress-Training-With-Live-Project")]
        public IActionResult PhpWithWordPress()
        {
            return View();

        }
        [Route("Php-Angular-Training-With-Live-Project")]
        public IActionResult PhpWithAngular()
        {
            return View();

        }
        [Route("Php-ReactJs-Training-With-Live-Project")]
        public IActionResult PhpWithReactJs()
        {
            return View();

        }
        [Route("Php-Codeiegniter-Training-With-Live-Project")]
        public IActionResult PhpWithCodeiegniter()
        {
            return View();

        }
    }
}
