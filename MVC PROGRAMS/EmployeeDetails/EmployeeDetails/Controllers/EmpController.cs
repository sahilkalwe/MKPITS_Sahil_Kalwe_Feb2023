using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeDetails.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Emp e)
        {
            ViewBag.empname = e.empname;
            ViewBag.designation = e.designation;
            ViewBag.basicsalary=e.basicsalary;
            ViewBag.da = e.da;
            ViewBag.ta = e.ta;
            ViewBag.hra=e.hra;
            ViewBag.totalsalary=e.totalsalary;

            if(e.designation=="Manager")
            {
                ViewBag.ta = (e.basicsalary * 0.15);
                ViewBag.da = (e.basicsalary * 0.45);
                ViewBag.hra = (e.basicsalary * 0.25);
                ViewBag.totalsalary = (e.basicsalary +ViewBag.ta+ViewBag.da+ ViewBag.hra);

            }
           else if (e.designation == "Clerk")
            {
                ViewBag.ta = (e.basicsalary * 0.15);
                ViewBag.da = (e.basicsalary * 0.45);
                ViewBag.hra = (e.basicsalary * 0.25);
                ViewBag.totalsalary = (e.basicsalary + ViewBag.ta + ViewBag.da + ViewBag.hra);

            }
            if (e.designation == "Peon")
            {
                ViewBag.ta = (e.basicsalary * 0.15);
                ViewBag.da = (e.basicsalary * 0.45);
                ViewBag.hra = (e.basicsalary * 0.25);
                ViewBag.totalsalary = (e.basicsalary + ViewBag.ta + ViewBag.da + ViewBag.hra);

            }
            return View();
        }
    }
}
