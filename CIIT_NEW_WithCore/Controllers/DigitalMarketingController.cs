using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DigitalMarketingController : Controller
    {
        [Route("Diploma-In-Digital-Marketing-With-Live-Project")]
        public IActionResult DigitalMarketing()
        {
            return View();
        }
        [Route("Graphic-Designing")]
        public IActionResult GraphicsDesign()
        {
            return View();
        }
    }
}
