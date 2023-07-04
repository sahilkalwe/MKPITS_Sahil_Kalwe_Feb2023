using Microsoft.AspNetCore.Mvc;
using Validation_summary.Models;

namespace Validation_summary.Controllers
{
    public class ValidationSummaryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ValidationSummary v)
        {
            ViewBag.Username = v.UserName;
            ViewBag.MobileNumber=v.MobileNumber;
            return View(v);
        }
    }
}
