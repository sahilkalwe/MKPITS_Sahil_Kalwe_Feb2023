﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace DLL_part_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label3.Text = c.addition(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label3.Text = c.substaction(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label3.Text = c.multiplication(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            Label3.Text = c.division(Convert.ToInt32(TextBox1.Text), Convert.ToInt32(TextBox2.Text));
        }
    }
}