using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class ExtraTopicController : Controller
    {
        [Route("C-Language-Training")]
        public IActionResult CLanguage()
        {
            return View();
        }
        [Route("CPP-Language-Training")]
        public IActionResult CPPLanguage()
        {
            return View();
        }
        [Route("DSA-Training")]

        public IActionResult DSA()
        {
            return View();
        }
        [Route("Core-Java-Training")]

        public IActionResult Corejava()
        {
            return View();
        }
        [Route("Core-Python-Training")]

        public IActionResult CorePython()
        {
            return View();
        }
        [Route("Oracle-Database-Training")]

        public IActionResult RDBMS()
        {
            return View();
        }
        [Route("Sql-Server-Database-Training")]

        public IActionResult SqlServer()
        {
            return View();
        }
    }
}
