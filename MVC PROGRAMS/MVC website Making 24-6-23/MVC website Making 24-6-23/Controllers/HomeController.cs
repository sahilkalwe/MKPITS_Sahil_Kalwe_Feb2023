using Microsoft.AspNetCore.Mvc;
using MVC_website_Making_24_6_23.Models;
using System.Diagnostics;

namespace MVC_website_Making_24_6_23.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Insights()
        {
            return View();
        }
        public IActionResult Careers()
        {
            return View();
        }
        public IActionResult Contactus()
        {
            return View();
        }

        public IActionResult Support()
        {
            return View();
        }

        public IActionResult Aboutus()
        {
            return View();
        }


        public IActionResult Capabilities()
        {
            return View();
        }


        public IActionResult Sectors()
        {
            return View();
        }

        public IActionResult SoftwareAndServices()
        {
            return View();
        }
        public IActionResult Home()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}