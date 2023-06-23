using Microsoft.AspNetCore.Mvc;

namespace MVC_1
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
