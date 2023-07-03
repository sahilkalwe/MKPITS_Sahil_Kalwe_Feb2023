using Microsoft.AspNetCore.Mvc;
using validation.Models;

namespace validation.Controllers
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
            if (string.IsNullOrEmpty(m.Name))
            {
                ModelState.AddModelError("Name", "Name Required");
            }
            if (m.Age == 0 || m.Age > 101)
            {
                ModelState.AddModelError("Age", "Please eneter valid age between 1-101");

            }
            if (ModelState.IsValid)
            {
                ViewBag.name = m.Name;
                ViewBag.age = m.Age;
                return View("Index");
            }

            else
                ViewBag.name = "No Data";
            ViewBag.Age = "No Data";
            return View("Index");
                
        }
    }
}
