using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DataScienceTrainingController : Controller
    {
        [Route("Data-Science-Training-With-Live-Project")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
