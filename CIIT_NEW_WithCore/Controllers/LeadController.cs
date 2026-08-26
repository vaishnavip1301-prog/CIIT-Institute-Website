using ERP_Models;
using ERP_Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
namespace CIIT_NEW_WithCore.Controllers
{
    public class LeadController : Controller
    {
        ILeadSource leadSource;
        IExtraService extraService;
        EmailSettings _settings;
        public LeadController(ILeadSource leadSource,IExtraService extraService, IOptions<EmailSettings> settings)
        {
            this.leadSource = leadSource;
            _settings = settings.Value;

            this.extraService = extraService;
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
            string message = $"Someone has enquired on CIIT Wesite. Details are below<br/>" +
                $"<table border='1'><tbody>" +
                $"<tr>" +
                $"<tr><td>Candidate Name:</td><td><b>{l.candidate_name}</b></td></tr>"+
                $"<tr><td>Email Address:</td><td><b>{l.email_address}</b></td></tr>" +
                $"<tr><td>Mobile Number:</td><td><b>{l.mobile_number}</b></td></tr>" +
                $"<tr><td>Training Mode:</td><td><b>{l.training_type}</b></td></tr>" +
                $"<tr><td>Enquiry Date:</td><td><b>{l.lead_date.ToLongDateString()}</b></td></tr>" +
                $"<tr><td>Description:</td><td><b>{l.description}</b></td></tr></tbody></table>";
            EmailModel em = new EmailModel()
            {
                 EmailAddress="ciitpune@gmail.com",
                  Subject="Enquiry from CIIT Website",
                   Message=message,
                    UserName="CIIT Training Institute"
            };
          await  extraService.SendEmail(em,_settings);
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