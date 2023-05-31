using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP7
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int InitialAmount = 1000;
            int result = 0;
            int Amt = Convert.ToInt32(TextBox2.Text);
            string Type = Convert.ToString(TextBox3.Text);

            if (Type == "Deposit")
            {
                result = InitialAmount + Amt;
                Label1.Text = result.ToString();
            }
            else if (Type == "Withdrawl")
            {
                result = InitialAmount - Amt;
                Label1.Text = result.ToString();
            }
        }
    }
}