using Microsoft.AspNetCore.Mvc;

namespace MVC_Class_Object_Methods.Controllers
{
    public class Customer : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
