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
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TrustDB");
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
            str = "insert into Item_Master values(@Item_Name,@Category,@Rate,@BalanceQuantity)";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Item_Name", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Category", DropDownList1.Text);
            command.Parameters.AddWithValue("@Rate", Convert.ToInt32(TextBox2.Text));
            command.Parameters.AddWithValue("@BalanceQuantity", TextBox3.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Saved";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Item_Master set Item_Quantity=@Department_Name where Department_ID=@Department_ID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_Name", TextBox2.Text);
            command.Parameters.AddWithValue("@Department_ID", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Updated";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "Delete from Department_Master where Department_ID = @Department_ID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_ID", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Deleted";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Item_Master where Item_Name = @Item_Name";
            dr = new SqlDataAdapter(str, con);
            dr.SelectCommand.Parameters.AddWithValue("@Item_Name",TextBox1.Text);

            dr.Fill(ds, "Item_Master");
            DropDownList1.SelectedValue = ds.Tables["Item_Master"].Rows[0].ItemArray[1].ToString();
            TextBox2.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[1].ToString();
            TextBox3.Text = ds.Tables["Item_Master"].Rows[0].ItemArray[1].ToString();
            GridView1.DataSource = ds.Tables["Item_Master"].DefaultView;
            GridView1.DataBind();
        
    }
    }
}