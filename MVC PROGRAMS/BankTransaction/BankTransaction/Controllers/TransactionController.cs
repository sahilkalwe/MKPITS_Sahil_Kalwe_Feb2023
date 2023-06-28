using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using System.IO;

namespace BankTransaction.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult index(Transaction c)
        {
            ViewBag.custname = c.custname;
            ViewBag.type = c.amount;
            return View();
        }
        
    }
}
