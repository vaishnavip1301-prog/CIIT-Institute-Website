using AspNetCore.SEOHelper;
using CIIT_NEW_WithCore.Models;
using ERP_Models;
using ERP_Services.Implementations;
using ERP_Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
//using Org.BouncyCastle.Pqc.Crypto.Lms;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
var connectionString = builder.Configuration.GetConnectionString("SQLServerIdentityConnection") ?? throw new InvalidOperationException("Connection string 'SQLServerIdentityConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(60);
});

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddTransient<ILeadSource, LeadServices>();
builder.Services.AddTransient<IMasterService, MasterService>();
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddTransient<IExtraService, ExtraService>();
builder.Services.AddTransient<IBatchService, BatchService>();
builder.Services.AddTransient<IBranchService, BranchService>();
builder.Services.AddTransient<ITopicService, TopicService>();
builder.Services.AddTransient<ICourseService, CourseService>();
builder.Services.AddTransient<IEnquiryService, EnquiryService>();
builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddTransient<ITrainerService, TrainerService>();
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IContentService, ContentService>();
builder.Services.AddTransient<IQuestionService, QuestionService>();
builder.Services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(10);
});
//builder.WebHost.ConfigureKestrel(options =>
//{
//    long mb = 1048576;
//    options.Limits.MaxRequestBodySize = 150 * mb;
//});

builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = int.MaxValue; // if don't set default value is: 128 MB
    options.MultipartHeadersLengthLimit = int.MaxValue;

});
 
builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
});
builder.Services.Configure<FormOptions>(options =>
{
    options.ValueLengthLimit = int.MaxValue;
    options.MultipartBodyLengthLimit = int.MaxValue; // if don't set default value is: 128 MB
    options.MultipartHeadersLengthLimit = int.MaxValue;

});
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    // This will handle exceptions and redirect to the specified error page.
    app.UseExceptionHandler("/Home/Error");
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();
app.UseXMLSitemap(builder.Environment.ContentRootPath);
app.UseRouting();
//app.UseEndpoints(endpoints => { endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); });
app.MapControllerRoute(
    name: "default",
 pattern: "{controller=Main}/{action=Index}/{id?}");
//pattern: "{controller=Test}/{action=TabDemo}/{id?}");
app.Run();