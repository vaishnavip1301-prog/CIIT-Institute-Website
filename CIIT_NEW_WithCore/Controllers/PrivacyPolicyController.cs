using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        [Route("privacy-policy")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
