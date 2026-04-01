using ERP_Models;
using ERP_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
namespace CIIT_NEW_WithCore.Controllers
{
    public class LeadController : Controller
    {
        ILeadSource leadSource;
        public LeadController(ILeadSource leadSource)
        {
            this.leadSource = leadSource;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<string> AddLeadSource([FromBody] LeadModel l)
        {
            l.lead_date = DateTime.Now;
            await leadSource.AddLead(l);
            return "Thank you for submitting your enquiry.We would like to help you.Our representative you call you in a while.";
        }
        [HttpGet]
        public async Task<List<LeadModel>> GetLeads()
        {
            List<LeadModel> lst = await leadSource.GetLeads();
            return lst;
        }
        [HttpGet]
        public async Task<JsonResult> GetAllLeads()
        {
            List<LeadModel> lst = await leadSource.GetLeads();
            return Json(lst);
        }
        [HttpGet]
        public async Task<LeadModel> GetLead(int id)
        {
            LeadModel lst = await leadSource.GetLead(id);
            return lst;
        }
    }
}