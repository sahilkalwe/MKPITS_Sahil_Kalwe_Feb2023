using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dropdown3Staff.Models;

namespace Dropdown3Staff.Controllers
{
    public class DropDownController : Controller
    {
        // GET: DropDown
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Details()
        {
            bindStaff();
            return View();
        }

        public void bindStaff()
        {
            Model1 modelDemo = new Model1();
            var Staff = modelDemo.StaffTables.ToList();
            List<SelectListItem> li = new List<SelectListItem>();
            li.Add(new SelectListItem { Text = "--Select Staff--", Value = "0" });

            foreach (var m in Staff)
            {


                li.Add(new SelectListItem { Text = m.Staffname, Value = m.Staffid.ToString() });
                ViewBag.Staff = li;

            }
        }

        public JsonResult getStudent(int id)
        {
            Model1 modelDemo = new Model1();
            var ddlStudent = modelDemo.StudentTables.Where(x => x.Staffid == id).ToList();
            List<SelectListItem> liStudent = new List<SelectListItem>();

            liStudent.Add(new SelectListItem { Text = "--Select Student--", Value = "0" });
            if (ddlStudent != null)
            {
                foreach (var x in ddlStudent)
                {
                    liStudent.Add(new SelectListItem { Text = x.Studentname, Value = x.Studentid.ToString() });
                }
            }
            return Json(new SelectList(liStudent, "Value", "Text", JsonRequestBehavior.AllowGet));
        }

    }
}
