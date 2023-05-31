using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP1
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1, n2, result=0;
            n1=Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            result=n1+n2;
            TextBox3.Text=result.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int n1, n2, result = 0;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            result = n1 - n2;
            TextBox3.Text = result.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int n1, n2, result = 0;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            result = n1 * n2;
            TextBox3.Text = result.ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int n1, n2, result = 0;
            n1 = Convert.ToInt32(TextBox1.Text);
            n2 = Convert.ToInt32(TextBox2.Text);
            result = n1 / n2;
            TextBox3.Text = result.ToString();
        }
    }
}