using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Trust_day_1
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (RadioButton1.Checked)
            {
                Label3.Visible = false;
                DropDownList3.Visible = false;
            }

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked)
            {
                Label3.Visible = false;
                DropDownList3.Visible = false;
                Label2.Visible = true;
                DropDownList2.Visible = true;



            }
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked)
            {
                Label2.Visible = false;
                DropDownList2.Visible = false;
                Label3.Visible = true;
                DropDownList3.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection conn = new SqlConnection("server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=ttrue;database=TrustDB1");
            SqlCommand command;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Transaction_Table(Transaction_ID,Item_ID,Transaction_Date,Department_ID,Vendor_ID,Quantity) " +
                        "values(@Transaction_ID,@Item_ID,@Transaction_Date,@Department_ID,@Vendor_ID,@Quantity)";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Item_ID", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@Transaction_Date", TextBox2.Text);
                    command.Parameters.AddWithValue("@Department_ID", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("@Quantity", TextBox1.Text);
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                    //code to get balance_quantity from Item_Master table
                    int bal_qty = 0;
                    query = "select balance_quantity from Item_Master where Item_ID=@Item_ID";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Item_ID", DropDownList1.SelectedValue);
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());

                    }
                    reader.Close();
                    conn.Close();
                    int qty = bal_qty - Convert.ToInt32(TextBox1.Text);
                    query = "upadate Item_Master set Balance_Quantity=@Balance_Quantity where Item_ID=@Item_ID";
                    command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@Balance_Quantity", qty);
                    command.Parameters.AddWithValue("@Item_ID", DropDownList1.SelectedValue);
                    conn.Open();
                    command.ExecuteNonQuery();
                    Label1.Text = "Item Issued to Department Succesfully";

                }
                catch (Exception ex)
                {
                    Label1.Text = ex.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }

        }
    }
}