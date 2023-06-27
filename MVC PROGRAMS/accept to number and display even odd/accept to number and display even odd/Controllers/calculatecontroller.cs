using accept_to_number_and_display_even_odd.Models;
using Microsoft.AspNetCore.Mvc;

namespace accept_to_number_and_display_even_odd.Controllers
{
    public class calculatecontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(calculatemodel cm)
        {
            int n1 = cm.num1;
            int n2 = cm.num2;
            int res = n1 + n2;
            ViewBag.result = res;
            return View();

        }


    }
}
