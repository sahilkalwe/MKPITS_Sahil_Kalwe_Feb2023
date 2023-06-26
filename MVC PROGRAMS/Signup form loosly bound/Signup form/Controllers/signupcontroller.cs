using Microsoft.AspNetCore.Mvc;
using Signup_form.Models;

namespace Signup_form.Controllers
{
    public class signupcontroller : Controller
    {
        //get:signup
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(signupmodel u)
        {
            ViewBag.username = u.username;
            ViewBag.password = u.password;  
            return View();

        }

    }
}
