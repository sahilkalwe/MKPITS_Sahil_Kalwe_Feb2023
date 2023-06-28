using arithmatic_operations.Models;
using Microsoft.AspNetCore.Mvc;

namespace arithmatic_operations.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Operation u)
        {
            ViewBag.number1 = u.number1;
            ViewBag.number2 = u.number2;
            if (u.add == true)
            {
                u.result1 = u.number1 + u.number2;
                ViewBag.result1 = u.result1;
            }
            if (u.substract == true)
            {
                u.result2 = u.number1 - u.number2;
                ViewBag.result2 = u.result2;
            }
            if (u.multiply == true)
            {
                u.result3 = u.number1 * u.number2;
                ViewBag.result3 = u.result3;
            }

            return View();
        }


    }
}
