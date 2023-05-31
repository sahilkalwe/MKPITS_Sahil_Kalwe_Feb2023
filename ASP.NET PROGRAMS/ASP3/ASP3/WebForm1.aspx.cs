using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, result,grade=0;
            double per;

            s1= Convert.ToInt32(TextBox1.Text);
            s2 = Convert.ToInt32(TextBox2.Text);
            s3 = Convert.ToInt32(TextBox3.Text);
            result= s1+s2+s3;
            per = (result * 100) / 300;
            if(per>=75)
            {
                TextBox6.Text = "A";
            }
            else if(per>=70 && per<75)
            {
                TextBox6.Text = "B";
            }
            else
            {
                TextBox6.Text = "C";
            }
            TextBox4.Text=result.ToString();
            TextBox5.Text=per.ToString();
        }
    }
}