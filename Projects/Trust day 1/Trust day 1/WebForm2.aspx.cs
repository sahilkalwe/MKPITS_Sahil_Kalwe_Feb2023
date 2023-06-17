using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trust_day_1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=TrustDB1");
        DataSet ds = new DataSet();
        SqlDataAdapter dr;
        string str = null;

        public void loaddata()
        {
            str = "select * from Department_Master";
            dr = new SqlDataAdapter(str, con);
            dr.Fill(ds, "Department_Master");
            GridView1.DataSource = ds.Tables["Department_Master"].DefaultView;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into Department_Master values(@Department_Name)";
            SqlCommand command = new SqlCommand(str, con);
            //command.Parameters.AddWithValue("@Department_ID", Convert.ToInt32(TextBox1.Text));
            command.Parameters.AddWithValue("@Department_Name", TextBox2.Text);
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
            str = "update Department_Master set Department_Name=@Department_Name where Department_ID=@Department_ID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_Name", TextBox2.Text);
           command.Parameters.AddWithValue("@Department_ID", Convert.ToInt32(TextBox1.Text));
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
            str = "Delete from Department_Master where Department_ID = @Department_ID";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@Department_ID", Convert.ToInt32(TextBox1.Text));
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
            str = "select * from Department_Master where Department_ID = @Department_ID";
            dr = new SqlDataAdapter(str, con);
            dr.SelectCommand.Parameters.AddWithValue("@Department_ID",TextBox1.Text);

            dr.Fill(ds, "Department_Master");
            TextBox2.Text = ds.Tables["Department_Master"].Rows[0].ItemArray[1].ToString();
            GridView1.DataSource = ds.Tables["Department_Master"].DefaultView;
            GridView1.DataBind();
        }
    }
}