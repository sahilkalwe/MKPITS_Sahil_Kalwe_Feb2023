using even_odd.Models;
using Microsoft.AspNetCore.Mvc;

namespace even_odd.Controllers
{
    public class evenoddcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(evenodd eo)
        {
            ViewBag.result = eo.result;
            ViewBag.num1 = eo.num1;
            int res = eo.num1%2;

            if (res == 0)
            {
                ViewBag.result = "Even Number";

            }
            else if(res == 1)
            {
                ViewBag.result = "Odd Number";
            }
                return View();
           
    }
    }
}
