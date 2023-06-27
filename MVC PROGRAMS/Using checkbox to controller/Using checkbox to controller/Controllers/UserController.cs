using Microsoft.AspNetCore.Mvc;
using Using_checkbox_to_controller.Models;

namespace Using_checkbox_to_controller.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(User u)
        {
            if (u.Tea == true)
                ViewBag.Tea = "You Selected Tea";
            if (u.Loundry == true)
                ViewBag.Loundry = "You Selected Loundry";
            if (u.Breakfast == true)
                ViewBag.Breakfast = "You Selected Breakfast";
            return View();
        }



    }
}
