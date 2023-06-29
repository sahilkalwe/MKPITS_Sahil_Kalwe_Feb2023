using DropdownAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace DropdownAssignment.Controllers
{
    public class DropdownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Dropdown u)
        {

            ViewBag.username = u.usernmae;
            ViewBag.course = u.course;
            ViewBag.res = u.res;
            ViewBag.gender = u.Gender;
            ViewBag.city = u.getCity;


            if (u.course == "dotnet")
            {
                ViewBag.res = "DotNet";
            }
            else if (u.course == "java")
            {
                ViewBag.res = "Java";
            }
            else if (u.course =="Dotnet" && u.course == "java")
                    {
                ViewBag.res = "Please Select Any One Operation";
                    }
            return View();
        }
    }
}
