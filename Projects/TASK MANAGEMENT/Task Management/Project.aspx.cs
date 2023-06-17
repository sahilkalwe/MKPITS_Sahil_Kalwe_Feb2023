using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_Management
{
    public partial class Task : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TaskManagement");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.QueryString["name"].ToString();
           // Response.Write("name is"+name);

            string startdate = Request.QueryString["startdate"].ToString();
            //Response.Write("date is" + startdate);
            string enddate = Request.QueryString["enddate"].ToString();
            //Response.Write("enddate is " + enddate);
            string projectmanager = Request.QueryString["Projectmanager"].ToString();
            //Response.Write("projectmanager is" + projectmanager);
            string status = Request.QueryString["status"].ToString();
            //Response.Write("status is" + status);
            string projectteammember = Request.QueryString["projectteammember"].ToString();
            //Response.Write("projectteammember is" + projectteammember);


            str = "insert into Project values(@Name,@StartDate,@ProjectManager,@Status,@Enddate,@ProjectTeamMembers)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@StartDate", startdate);
            command.Parameters.AddWithValue("@ProjectManager", projectmanager);
            command.Parameters.AddWithValue("@Status",status);
            command.Parameters.AddWithValue("@Enddate", enddate);
            command.Parameters.AddWithValue("@ProjectTeamMembers",projectteammember);
            Response.Write("Records Saved Succesfully");
            con.Open();
            command.ExecuteNonQuery();
            con.Close();

        }
    }
}