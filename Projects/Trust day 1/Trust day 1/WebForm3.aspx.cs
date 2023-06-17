using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trust_day_1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TrustDB1");
        DataSet ds = new DataSet();
        SqlDataAdapter dr;
        string str = null;

        public void loaddata()
        {
            str = "select * from Vendor_Master";
            dr = new SqlDataAdapter(str, con);
            dr.Fill(ds, "Vendor_Master");
            GridView1.DataSource = ds.Tables["Vendor_Master"].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Vendor_Master values(@Vendor_Name)";
            SqlCommand command = new SqlCommand(str, con);
            //command.Parameters.AddWithValue("@Vendor_ID", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Vendor_Name", TextBox2.Text);
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Saved";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Vendor_Master set Vendor_Name=@Vendor_Name where Vendor_ID=@Vendor_ID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Vendor_Name", TextBox2.Text);
            command.Parameters.AddWithValue("@Vendor_ID", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Updated";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "Delete from Vendor_Master where Vendor_ID = @Vendor_ID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Vendor_ID", Convert.ToInt32(TextBox1.Text));
            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            Label1.Text = "Record Deleted";
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
            loaddata();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from Vendor_Master where Vendor_ID = @Vendor_ID";
            dr = new SqlDataAdapter(str, con);
            dr.SelectCommand.Parameters.AddWithValue("@Vendor_ID", TextBox1.Text);

            dr.Fill(ds, "Vendor_Master");
            TextBox2.Text = ds.Tables["Vendor_Master"].Rows[0].ItemArray[1].ToString();
            GridView1.DataSource = ds.Tables["Vendor_Master"].DefaultView;
            GridView1.DataBind();
        }
    }
}