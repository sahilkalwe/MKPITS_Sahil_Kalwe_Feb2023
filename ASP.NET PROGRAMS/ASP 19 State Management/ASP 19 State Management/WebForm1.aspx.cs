using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_19_State_Management
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //code to create temporary cookie
            string username;
            HttpCookie cookie1 = new HttpCookie("cook1");
            cookie1.Values.Add("username", TextBox1.Text);
            Response.Cookies.Add(cookie1);
            Label2.Text ="temporary cookie added to client machine" ;

        }
    }
    }
