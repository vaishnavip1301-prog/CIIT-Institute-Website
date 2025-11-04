using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DigitalMarketingController : Controller
    {
        [Route("Digital-Marketing-Training-With-Live-Project")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
