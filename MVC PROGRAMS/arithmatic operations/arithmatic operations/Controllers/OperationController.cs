using Microsoft.AspNetCore.Mvc;

namespace arithmatic_operations.Controllers
{
    public class OperationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
