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
            ViewBag.Course1=d.Course1.ToString();
            ViewBag.Gender = d.Gender;
            var selectedvalue = d.getcity;
            ViewBag.City = selectedvalue.ToString();
            
            string res;
            if(d.Course==true)
            {
               d.res = "DotNet";
            }
           if (d.Course1 == true)
            {
             d.res = "Java";
            }
         ViewBag.res = d.res;
            return View(d);
        }
    }
}
