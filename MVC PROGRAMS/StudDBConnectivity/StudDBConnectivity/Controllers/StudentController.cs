using StudDBConnectivity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudDBConnectivity.Controllers
{
    public class StudentController : Controller
    {

        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Student Details Page";
            ItemDBHandler handler = new ItemDBHandler();
            ModelState.Clear();
            return View(handler.GetItemList());
        }


        //add new item

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudModel iList)
        {
            if (ModelState.IsValid)
            {
                ItemDBHandler ItemHaandler = new ItemDBHandler();
                if (ItemHaandler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Succesfully";
                    ModelState.Clear();

                }
            }
            return View();
        }


        //update item
        [HttpGet]
        public ActionResult Edit(int StudID)
        {
            ItemDBHandler itemDBHandler = new ItemDBHandler();
            return View(itemDBHandler.GetItemList().Find(StudModel => StudModel.StudID == StudID));
        }
        [HttpPost]
        public ActionResult Edit(int StudID, StudModel iList)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch 
            {
                return View(); 
            }


        }


        //delete item
        [HttpGet]
        public ActionResult delete(int StudID)
        {
            try
            {
                ItemDBHandler itemHandler = new ItemDBHandler();
                if (itemHandler.DeleteItem(StudID))
                {
                    ViewBag.AlertMsg = "Item Deleted Succesfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        public ActionResult Details(int StudID)

        {

            ItemDBHandler Itemhandler = new ItemDBHandler();
            return View(Itemhandler.GetItemList().Find(StudModel => StudModel.StudID == StudID));


        }

    }


}
