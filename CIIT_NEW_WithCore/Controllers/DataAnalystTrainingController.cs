using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DataAnalystTrainingController : Controller
    {
        [Route("Data-Analytics-With-Job-Assistance")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("advance-excel-with-vba")]
        public IActionResult AdvanceExcelWithVBA()
        {
            return View();
        }
        [Route("power-bi")]
        public IActionResult PowerBI()
        {
            return View();
        }
    }
}
