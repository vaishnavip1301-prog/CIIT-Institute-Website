using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class VBlogsController : Controller
    {
        [Route("ciit-vblogs")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
