using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task_Management
{
    public partial class User : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TaskManagement");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string firstname = Request.QueryString["firstname"].ToString();

            string email = Request.QueryString["email"].ToString();

            string password = Request.QueryString["password"].ToString();

            string lastname = Request.QueryString["lastname"].ToString();

            string userrole = Request.QueryString["userrole"].ToString();

            string confirmpassword = Request.QueryString["confirmpassword"].ToString();




            string str = "insert into User1 values(@FirstName,@Email,@Password,@LastName,@UserRole,@ConfirmPassword)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@FirstName", firstname);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@LastName", lastname);
            command.Parameters.AddWithValue("@UserRole", userrole);
            command.Parameters.AddWithValue("@ConfirmPassword", confirmpassword);
            Response.Write("Records Saved Succesfully In User Table");
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
    }
}