using Microsoft.AspNetCore.Mvc;

namespace TemplateIntegration_In_ASP.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
