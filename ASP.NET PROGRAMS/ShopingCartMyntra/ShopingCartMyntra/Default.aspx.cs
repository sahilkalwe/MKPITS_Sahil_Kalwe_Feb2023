using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopingCartMyntra
{
    public partial class _Default : Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=Meesho");
        SqlDataAdapter da;
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                da = new SqlDataAdapter("select * from product", con);
                ds = new DataSet();
                da.Fill(ds, "product");
                DataList1.DataSource = ds.Tables["product"].DefaultView;
                DataList1.DataBind();


            }
        }
    }
}