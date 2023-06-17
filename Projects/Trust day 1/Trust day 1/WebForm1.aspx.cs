using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Trust_day_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TrustDB1");
        DataSet ds = new DataSet();
        SqlDataAdapter dr;
        string str = null;

        public void loaddata()
        {
            str = "select * from Item_Master";
            dr=new SqlDataAdapter(str,con);
            dr.Fill(ds, "Item_Master");
            GridView1.DataSource = ds.Tables["Item_Master"].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Item_Master values(@Item_Name,@Category,@rate,@BalanceQuantity)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Name",TextBox1.Text);
            command.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            command.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@BalanceQuantity", Convert.ToInt32(TextBox3.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Saved";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Item_Master set Item_Name=@Item_Name where rate=@rate";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Name", TextBox1.Text);
            command.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            command.Parameters.AddWithValue("@rate", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@BalanceQuantity", Convert.ToInt32(TextBox3.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Updated";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "Delete from Item_Master where Item_Name = @Item_Name";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Name",TextBox1.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Deleted";
            TextBox1.Text = "";
            DropDownList1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Item_Master where Item_Name = @Item_Name";
            dr = new SqlDataAdapter(str, con);
            dr.SelectCommand.Parameters.AddWithValue("@Item_Name",TextBox1.Text);
            dr.SelectCommand.Parameters.AddWithValue("@Category", DropDownList1.SelectedValue);
            dr.SelectCommand.Parameters.AddWithValue("@rate", TextBox2.Text);
            dr.SelectCommand.Parameters.AddWithValue("@BalanceQuantity", TextBox3.Text);

            dr.Fill(ds, "Item_Master");
            DropDownList1.SelectedValue = ds.Tables["Item_Master"].Rows[0].ItemArray[2].ToString();
            TextBox2.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[3].ToString();
            TextBox3.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[4].ToString();
            GridView1.DataSource = ds.Tables["Item_Master"].DefaultView;
            GridView1.DataBind();
        
    }
    }
}