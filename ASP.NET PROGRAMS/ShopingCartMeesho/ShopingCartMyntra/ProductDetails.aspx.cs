using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopingCartMyntra
{
    public partial class ProductDetails : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("server =LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=Meesho");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["prodid"].ToString();
            da = new SqlDataAdapter("select * from product where prodid=@prodid", con);
            da.SelectCommand.Parameters.AddWithValue("@prodid", prodid); ds = new DataSet();
            da.Fill(ds, "productdetails");
            DataList1.DataSource = ds.Tables["productdetails"].DefaultView;
            DataList1.DataBind();
        }

        }
    }
