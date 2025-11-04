using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class TestController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
