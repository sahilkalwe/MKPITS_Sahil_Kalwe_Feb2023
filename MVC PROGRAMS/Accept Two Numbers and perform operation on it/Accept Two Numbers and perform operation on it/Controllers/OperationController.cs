using Accept_Two_Numbers_and_perform_operation_on_it.Models;
using Microsoft.AspNetCore.Mvc;

namespace Accept_Two_Numbers_and_perform_operation_on_it.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Opeartion o)
        {
            ViewBag.result = o.result;
            ViewBag.n1 = o.n1;
            ViewBag.n2 = o.n2;
            if (o.op == '+')
            {
                ViewBag.result = o.n1 + o.n2;
            }
            else if (o.op == '-')
            {
                ViewBag.result = o.n1 - o.n2;
            }
            else if (o.op == '*')
            {
                ViewBag.result = o.n1 * o.n2;
            }
            else if (o.op == '/')
            {
                ViewBag.result = o.n1 / o.n2;
            }
            else
            {
                ViewBag.result = "Invalid Opeartion";
            }
            return View();
        }
    
    }
}
