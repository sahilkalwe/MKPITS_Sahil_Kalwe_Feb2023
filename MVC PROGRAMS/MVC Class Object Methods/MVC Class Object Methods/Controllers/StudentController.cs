using Microsoft.AspNetCore.Mvc;

namespace MVC_Class_Object_Methods.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
