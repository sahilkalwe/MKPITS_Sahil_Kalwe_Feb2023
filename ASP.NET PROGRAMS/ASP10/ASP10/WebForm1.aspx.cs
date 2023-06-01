using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP10
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList3.Items.Clear();    
            switch(DropDownList1.Text)
            {
                case "India":
                    DropDownList3.Items.Add("Washim");
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Bhandara");
                    DropDownList3.Items.Add("Tumsar");
                    break;

                case "Sri Lanka":
                    DropDownList3.Items.Add("Colombo");
                    DropDownList3.Items.Add("Tirivntpuram");
                    DropDownList3.Items.Add("Nostadq");
                    break;

                case "Nepal":
                    DropDownList3.Items.Add("Katmandu");
                    break;

            }
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb=new System.Text.StringBuilder();
            sb.Append("Country  " + DropDownList1.Text + "<br>");
            sb.Append("City  " + DropDownList3.Text + "<br>");
            foreach (ListItem li in CheckBoxList1.Items)
            {
                if(li.Selected)
                {
                    sb.Append("Course  " + li.Value + "<br>");

                }

            }
            sb.Append("Center  " + ListBox1.SelectedItem.ToString() + "<br>");
            Label1.Text=sb.ToString();
        }
    }
}