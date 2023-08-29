using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using insert_with_ajax.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;


namespace insert_with_ajax.Controllers
{
    public class HomeController : Controller
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=insertwithajaxdb";
            con = new SqlConnection(constr);
        }
        public  ActionResult AddEmployee() 
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
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
        [HttpPost]
        public ActionResult AddEmployee(EmpModel obj)
        {
            AddDetails(obj);

            return View();
        }



        //To add Records into database     
        private void AddDetails(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("AddEmp", con);
            //addemp is the name of stored procedure
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", obj.name);
            com.Parameters.AddWithValue("@city", obj.city);
            com.Parameters.AddWithValue("@address", obj.address);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }
    }
}
