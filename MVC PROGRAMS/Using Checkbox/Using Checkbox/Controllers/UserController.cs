using Microsoft.AspNetCore.Mvc;
using Using_Checkbox.Models;

namespace Using_Checkbox.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(UserModel u)
        {
            ViewBag.Tea=u.Tea.ToString();
            ViewBag.Loundry = u.Loundry.ToString();
            ViewBag.Breakfast=u.Breakfast.ToString();
            return View();
        }
    }
}
