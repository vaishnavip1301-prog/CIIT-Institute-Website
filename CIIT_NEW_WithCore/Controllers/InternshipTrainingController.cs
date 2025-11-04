using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class InternshipTrainingController : Controller
    {
        [Route("Internship-With-Live-Project")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
