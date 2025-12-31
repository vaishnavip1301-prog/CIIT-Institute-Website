using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DBAController : Controller
    {
        [Route("oracle-dba")]
        public IActionResult OracleDBA()
        {
            return View();
        }
        [Route("sql-server-dba")]

        public IActionResult SQLServerDBA()
        {
            return View();
        }
    }
}
