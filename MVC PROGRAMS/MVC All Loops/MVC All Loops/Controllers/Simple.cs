using Microsoft.AspNetCore.Mvc;

namespace MVC_All_Loops.Controllers
{
    public class Simple : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
