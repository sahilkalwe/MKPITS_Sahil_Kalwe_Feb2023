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
    public partial class SignIn : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TaskManagement");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

                string email = Request.QueryString["email"].ToString();

                string password = Request.QueryString["password"].ToString();

                str = "insert into SignIn values(@Email,@Password)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                Response.Write("Records Saved Succesfully In SignIn Table");
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
            }
        }
    }
