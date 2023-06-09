using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP20_Cookie
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            {
                //code to create temporary cookie
                string username;
                HttpCookie cookie1 = new HttpCookie("cook1");
                cookie1.Values.Add("username", TextBox1.Text);
                Response.Cookies.Add(cookie1);
                Label2.Text = "temporary cookie added to client machine";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine
            HttpCookie cookie1 = Request.Cookies["cook1"];
            if (cookie1 != null)
            {
                string uname = cookie1.Values["username"].ToString();
                Label2.Text = "username: " +uname;
            }
            else
            {
                Label2.Text = "no cookie exist";
            }

           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //code to create permenent cookie
            HttpCookie cookie12 = new HttpCookie("cook1");
            cookie12.Values.Add("username", TextBox1.Text);
            cookie12.Values.Add("email", TextBox2.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 2, 0);
            cookie12.Expires = dt.Add(ts);
            Label2.Text = "permanent cookie added to client machine";

            Response.Cookies.Add(cookie12);
            Label2.Text = "Permenent cookie added to client machine";
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine
            HttpCookie cookie12 = Request.Cookies["cook1"];

            if (cookie12 != null)
            {
                string uname = cookie12.Values["username"].ToString();
                string uemail = cookie12.Values["email"].ToString();
                Label2.Text = "username:"+uname;
                Label4.Text ="email" +uemail;
            }
            else
            {
                Label2.Text ="no permanent cookie exist";
            }
        }
    }
}