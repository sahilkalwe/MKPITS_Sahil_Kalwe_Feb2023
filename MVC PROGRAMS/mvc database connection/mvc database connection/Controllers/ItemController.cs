using Microsoft.AspNetCore.Mvc;
using mvc_database_connection.Models;

namespace mvc_database_connection.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //add new item
        [HttpGet]
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ItemModel ilist)
        {
        if(ModelState.IsValid)
            {
                ItemDBHandler db = new ItemDBHandler();
                if(db.InsertItem(ilist))
                {
                    ViewBag.message = "Item Saved Succesfully";
                    ModelState.Clear();
                }
            }
        return View();
        
        }

    }
}
