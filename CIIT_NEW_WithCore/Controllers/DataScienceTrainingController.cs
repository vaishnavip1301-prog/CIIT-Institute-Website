using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DataScienceTrainingController : Controller
    {
        [Route("Data-Science-With-100%-Job-Assistance")]
        public IActionResult DataScience()
        {
            return View();
        }
        //[Route("Data-Analytics-With-100%-Job-Assistance")]
        //public IActionResult DataAnalytics()
        //{
        //    return View();
        //}
        [Route("Project-Based-Advanced-Generative-Training")]
        public IActionResult AdvanceGenerativeAI()
        {
            return View();
        }
    }
}
