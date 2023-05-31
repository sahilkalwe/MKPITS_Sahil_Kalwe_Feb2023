using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
           string op;
           int result=0;
           int n1 = Convert.ToInt32(TextBox1.Text);
           int n2 = Convert.ToInt32(TextBox2.Text);
            op=Convert.ToString(TextBox4.Text);
            switch (op)
            {
                case "+":
                    result = n1 + n2;
                    //TextBox3.Text = result.ToString();
                    break;
                case "-":
                    result = n1 - n2;
                    //TextBox3.Text = result.ToString();
                    break;
                case "*":
                    result = n1 * n2;
                   // TextBox3.Text = result.ToString();
                    break;
                case "/":
                    result = n1 / n2;
                   // TextBox3.Text = result.ToString();
                    break;
            }
           TextBox3.Text = result.ToString();

        }
    }
}