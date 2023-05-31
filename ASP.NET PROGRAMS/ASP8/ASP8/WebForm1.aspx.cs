using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Name  " + TextBox1.Text + "<br>");
            sb.Append("Password  " + TextBox2.Text + "<br>"); 
            sb.Append("Address  " + TextBox3.Text + "<br>");
            sb.Append("MobileNumber  " + TextBox4.Text + "<br>");
            sb.Append("DateOfBirth  " + TextBox5.Text + "<br>");
            if (RadioButton1.Checked)
                sb.Append("gender  " + RadioButton1.Text + "<br>");
            else if (RadioButton2.Checked)
                sb.Append("gender  " + RadioButton2.Text + "<br>");
            if (CheckBox1.Checked)
                sb.Append("Hobby  " + CheckBox1.Text + "<br>");
            if (CheckBox2.Checked)
                sb.Append("Hobby  " + CheckBox2.Text + "<br>");
            if (CheckBox3.Checked)
                sb.Append("Hobby  " + CheckBox3.Text + "<br>");
            if (CheckBox4.Checked)
                sb.Append("Hobby  " + CheckBox4.Text + "<br>");
            sb.Append("City   " + DropDownList1.Text + "<br>");
            Label1.Text = sb.ToString();
        
        }
    }
}