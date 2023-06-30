using Dropdown_Assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dropdown_Assignment.Controllers
{
    public class DropdownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Index(Dropdown d)
        {
            ViewBag.Username=d.Username;
            ViewBag.Course = d.Course.ToString();
            ViewBag.Gender = d.Gender;
            var selectedvalue = d.getcity;
            ViewBag.City = selectedvalue.ToString();
            return View(d);
        }
    }
}
