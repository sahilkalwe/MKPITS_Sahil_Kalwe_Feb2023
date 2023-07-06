using mvc_database_connection_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
namespace mvc_database_connection_2.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            ViewBag.ItemList = "Computer Shop List Page";
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
        public ActionResult Create(ItemModel iList) 
        {
            if(ModelState.IsValid)
            {
                ItemDBHandler ItemHaandler = new ItemDBHandler();
                if(ItemHaandler.InsertItem(iList))
                {
                    ViewBag.Message = "Item Added Succesfully";
                    ModelState.Clear();

                }
            }
            return View();
            
        
        
        }



        //update item
        [HttpGet]
        public ActionResult Edit(int id)
        {
           ItemDBHandler itemDBHandler = new ItemDBHandler();
            return View(itemDBHandler.GetItemList().Find(ItemModel=>ItemModel.ID==id));
        }
        [HttpPost]
        public ActionResult Edit(int id, ItemModel iList)
        {
            try
            {
                ItemDBHandler ItemHandler = new ItemDBHandler();
                ItemHandler.UpdateItem(iList);
                return RedirectToAction("Index");
            }
            catch { return View(); }

        
            }


        //delete item
        [HttpGet]
        public ActionResult delete(int id)
        {
            try
            {
                ItemDBHandler itemHandler = new ItemDBHandler();
                if (itemHandler.DeleteItem(id))
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
           public ActionResult Details(int ID)

            {
            
                ItemDBHandler Itemhandler=new ItemDBHandler();
            return View(Itemhandler.GetItemList().Find(ItemModel => ItemModel.ID == ID));
            
                
            }

        }


    }
