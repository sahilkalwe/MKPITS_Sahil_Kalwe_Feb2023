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

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
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

                case "Amearica":
                    DropDownList3.Items.Add("Chicago");
                    DropDownList3.Items.Add("Amsterdam");
                    DropDownList3.Items.Add("New York");
                    DropDownList3.Items.Add("Washington");
                    break;

            }
        }
    }
}