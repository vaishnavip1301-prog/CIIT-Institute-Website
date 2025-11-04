using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DataAnalystTrainingController : Controller
    {
        [Route("Data-Analyst-Training-With-Live-Project")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
