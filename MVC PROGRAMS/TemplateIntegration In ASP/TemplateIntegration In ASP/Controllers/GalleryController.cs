using Microsoft.AspNetCore.Mvc;

namespace TemplateIntegration_In_ASP.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
