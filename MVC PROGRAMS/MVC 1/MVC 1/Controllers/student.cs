using Microsoft.AspNetCore.Mvc;

namespace MVC_1.Controllers
{
    public class student : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
