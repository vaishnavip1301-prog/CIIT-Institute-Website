using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class UIUXTrainingController : Controller
    {
        [Route("UI-UX-Training-With-Live-Project")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
