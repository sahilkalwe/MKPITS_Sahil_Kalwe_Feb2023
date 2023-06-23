using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ShopingCartMyntra
{
    public partial class Checkmno : System.Web.UI.Page
    {
        string prodid;
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=Meesho");
        SqlCommand command;
        string query;

        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToString(Session["prodid"]);
            Response.Write("prodid " + prodid);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = TextBox1.Text;
            string prodname = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            if(res=="123456")
            {
                query = "select * from product where prodid=@prodid";
                command=new SqlCommand(query,con);
                command.Parameters.AddWithValue("@prodid", prodid);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    prodname = dr["prodname"].ToString();
                    prodprice = Convert.ToInt32(dr["prodprice"].ToString());
                    qty = 1;
                    sessionid = Session.SessionID;
                }

                con.Close();
                Response.Write("prodname " + prodname + "<br>");
                Response.Write("prod price " + prodprice + "<br>");
                Response.Write("qty " + qty + "<br>");
                Response.Write("session id " + sessionid + "<br>");
           
            
            }
            else
            {
                Label1.Text = "Invalid OTP";
            }
        }
    }
}