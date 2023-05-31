using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double price=0, qty = 0 ,res;
            price=Convert.ToInt32(TextBox2.Text);
            qty = Convert.ToInt32(TextBox3.Text);
            res = price * qty;
            Label1.Text = res.ToString();   

        }
    }
}