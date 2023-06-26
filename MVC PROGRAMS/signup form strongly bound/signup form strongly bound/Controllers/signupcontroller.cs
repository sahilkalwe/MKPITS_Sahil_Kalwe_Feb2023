using Microsoft.AspNetCore.Mvc;
using signup_form_strongly_bound.Models;

namespace signup_form_strongly_bound.Controllers
{
    public class signupcontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(signup u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;
            return View();

        }
    }
}
