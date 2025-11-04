using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class CorporateTrainingController : Controller
    {
        [Route("Corporate-Training-With-Live-Project")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
