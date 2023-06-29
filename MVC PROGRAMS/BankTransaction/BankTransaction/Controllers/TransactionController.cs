using Microsoft.AspNetCore.Mvc;
using System.Transactions;
using System.IO;
using BankTransaction.Models;

namespace BankTransaction.Controllers
{
    public class TransactionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult index(BankTransaction.Models.Transaction c)
        {
            ViewBag.custname = c.custname;
            ViewBag.type = c.type;
            ViewBag.amount = c.amount;
            ViewBag.totalBalance = c.TotalBalance;


            int amt = 3000;
            if (c.type == "Deposit")
            {
                ViewBag.TotalBalance = ViewBag.amount + amt;

            }
            else
            {
                ViewBag.TotalBalance = amt - ViewBag.amount;

            }

                return View();
        }

    }
}
