using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using Countrieswithajax.Models;

namespace Countrieswithajax.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CascadingModel model = new CascadingModel(); //this will call contructor

            model.Countries = PopulateDropDown("SELECT CountryId, CountryName FROM Countries", "CountryName", "CountryId");
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //populatedropdown is user defined function created to fill country dropdown
        private static List<SelectListItem> PopulateDropDown(string query, string textColumn, string valueColumn)
        {
            List<SelectListItem> items = new List<SelectListItem>();
            string constr = ConfigurationManager.ConnectionStrings["Constring"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            items.Add(new SelectListItem
                            {
                                Text = sdr[textColumn].ToString(),
                                Value = sdr[valueColumn].ToString()
                            });
                        }
                    }
                    con.Close();
                }
            }

            return items;
        }

        [HttpPost]
        public ActionResult Index(int countryId, int stateId, int cityId)
        {
            CascadingModel model = new CascadingModel();
            model.Countries = PopulateDropDown("SELECT CountryId, CountryName FROM Countries", "CountryName", "CountryId");
            model.States = PopulateDropDown("SELECT StateId, StateName FROM States WHERE CountryId = " + countryId, "StateName", "StateId");
            model.Cities = PopulateDropDown("SELECT CityId, CityName FROM Cities WHERE StateId = " + stateId, "CityName", "CityID");
            return View(model);
        }

        [HttpPost]
        public JsonResult AjaxMethod(string type, int value)
        {
            CascadingModel model = new CascadingModel();
            switch (type)
            {
                case "CountryId":
                    model.States = PopulateDropDown("SELECT StateId, StateName FROM States WHERE CountryId = " + value, "StateName", "StateId");
                    break;
                case "StateId":
                    model.Cities = PopulateDropDown("SELECT CityId, CityName FROM Cities  WHERE StateId = " + value, "CityName", "CityId");
                    break;
            }
            return Json(model);
        }




    }
}



