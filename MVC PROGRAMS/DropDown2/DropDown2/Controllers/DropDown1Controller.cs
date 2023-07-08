using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DropDown2.Models;

namespace DropDown2.Controllers
{
    public class DropDown1Controller : Controller
    {
        // GET: DropDown1
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            bindCategory();
            return View();
        }

        public void bindCategory()
        {
            Model12 modelDemo = new Model12();
            var Category = modelDemo.CategoryTables.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select Category--", Value = "0" });

            foreach (var m in Category)
            {


                li.Add(new SelectListItem { Text = m.Categoryname, Value = m.Categoryid.ToString() });
                ViewBag.Category = li;

            }
        }

        public JsonResult getProduct(int id)
        {
            Model12 modelDemo = new Model12();
            var ddlProduct = modelDemo.ProductTables.Where(x => x.Categoryid == id).ToList();
            List<SelectListItem> liProducts = new List<SelectListItem>();

            liProducts.Add(new SelectListItem { Text = "--Select Product--", Value = "0" });
            if (ddlProduct != null)
            {
                foreach (var x in ddlProduct)
                {
                    liProducts.Add(new SelectListItem { Text = x.Productname, Value = x.Productid.ToString() });
                }
            }
            return Json(new SelectList(liProducts, "Value", "Text", JsonRequestBehavior.AllowGet));
        }

    }
}
