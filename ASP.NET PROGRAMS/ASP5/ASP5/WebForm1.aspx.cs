using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(TextBox1.Text);
            if(n>=21)
            {
                TextBox2.Text = " You Are Eligible";
            }
            else
            {
                TextBox2.Text = " You Are Not Eligible";

            }
        }
    }
}