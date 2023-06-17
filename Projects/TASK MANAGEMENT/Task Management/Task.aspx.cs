using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_Management
{
    public partial class Task1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TaskManagement");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstname = Request.QueryString["firstname"].ToString();

            string projectname = Request.QueryString["projectname"].ToString();

            string startdate = Request.QueryString["startdate"].ToString();
          
            string lastname = Request.QueryString["lastname"].ToString();
     
            string taskassigned = Request.QueryString["taskassigned"].ToString();

            string enddate = Request.QueryString["enddate"].ToString();
          
          


           string str = "insert into Task values(@FirstName,@ProjectName,@StartDate,@LastName,@TaskAssigned,@Enddate)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@FirstName", firstname);
            command.Parameters.AddWithValue("@ProjectName", projectname);
            command.Parameters.AddWithValue("@StartDate", startdate);
            command.Parameters.AddWithValue("@LastName", lastname);
            command.Parameters.AddWithValue("@TaskAssigned", taskassigned);
            command.Parameters.AddWithValue("@EndDate", enddate);
            Response.Write("Records Saved Succesfully");
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}