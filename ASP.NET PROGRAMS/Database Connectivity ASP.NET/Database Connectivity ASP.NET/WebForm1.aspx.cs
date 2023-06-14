using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Database_Connectivity_ASP.NET
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=\\LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=product");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "insert into tableproduct values(@product_id,product_name,@product_rate,@product_quantity)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@product_id",Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@product_name",TextBox2.Text);
            command.Parameters.AddWithValue("@product_rate", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@product_quantity", Convert.ToInt32(TextBox4.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label5.Text = "Record Saved";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            str = "select * from tableproduct";
            da=new SqlDataAdapter(str, con);
            da.Fill(ds,"tableproduct");
            GridView1.DataSource = ds.Tables["tableproduct"].DefaultView;
            GridView1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "update tableproduct set product_name=@product_name,product_rate=@product_rate,product_quantity=@product_quantity where product_id=@product_id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@product_name",TextBox2.Text);
            command.Parameters.AddWithValue("@product_rate", Convert.ToInt32(TextBox3.Text));
            command.Parameters.AddWithValue("@product_quantity", Convert.ToInt32(TextBox4.Text));
            command.Parameters.AddWithValue("@product_id", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label5.Text = "Record Updated";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str="Delete from tableproduct where product_id = @product_id";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@product_id", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label5.Text = "Record Deleted";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            str = "select * from tableproduct where product_id = @product_id";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@product_id", Convert.ToInt32(TextBox1.Text));
            da.Fill(ds, "tableproduct");
            TextBox2.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[2].ToString();
            TextBox4.Text = ds.Tables["tableproduct"].Rows[0].ItemArray[3].ToString();
            GridView1.DataSource = ds.Tables["tableProduct"].DefaultView;
            GridView1.DataBind();
        }
    }
}