using Microsoft.AspNetCore.Mvc;

namespace CIIT_NEW_WithCore.Controllers
{
    public class DataScienceTrainingController : Controller
    {
        [Route("Data-Science-With-Job-Assistance")]
        public IActionResult DataScience()
        {
            return View();
        }
        //[Route("Data-Analytics-With-100%-Job-Assistance")]
        //public IActionResult DataAnalytics()
        //{
        //    return View();
        //}
        [Route("Project-Based-Advanced-Generative-AI-Training")]
        public IActionResult AdvanceGenerativeAI()
        {
            return View();
        }
        [Route("Machine-Learning-Training-With-Job-Assurance")]
        public IActionResult MachineLearning()
        {
            return View();
        }
        [Route("Data-Engineering-Training-With-Job-Assurance")]
        public IActionResult DataEngineeringTraining()
        {
            return View();
        }
        [Route("Business-Analytics-Training-With-Job-Assurance")]
        public IActionResult BusinessAnalytics()
        {
            return View();
        }
        [Route("/agentic-ai-with-job-assurance")]
        public IActionResult AgenticAI()
        {
            return View();
        }
    }
}
