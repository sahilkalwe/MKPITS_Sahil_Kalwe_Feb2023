using Microsoft.AspNetCore.Mvc;
using validation_summary.Models;

namespace validation_summary.Controllers
{
    public class ValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Validation m)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Name=m.Name;
                ViewBag.Email=m.Email;
                ViewBag.Age=m.Age;
                return View("Index");
            }
            else
            {
                ViewBag.Name = "no Data";
                ViewBag.Email = "no Data";
                ViewBag.Age = "no Data";
                return View("Index");
            }
        }
    }
}
