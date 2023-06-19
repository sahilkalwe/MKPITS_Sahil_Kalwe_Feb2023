using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net;

namespace DrivenIT
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=DrivenIt");
        SqlCommand command = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
               query = "Insert into Transactions values(@ItemID,@TransType,@TransQty,@TransDate)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                string transt = null;
                if(RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";

                }
                command.Parameters.AddWithValue("@TransType",transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                con.Open();
                command.ExecuteNonQuery();



                //getting the balqty from ItemMaster Table For Particular item id
                
                
                query = " select max(BalQty) from ItemMaster where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt=="I")
                {
                   bq=bq-Convert.ToInt32(TextBox1.Text);
                }
                else if (transt=="R")
                {
                   bq=bq+Convert.ToInt32(TextBox1.Text);

                }

                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "Record Saved";
            }

            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }



        }

        protected void Edit_Click(object sender, EventArgs e)
        {


            try
            {
                query = "update transactions set TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where ItemID=@ItemID";
                command = new SqlCommand(query, con);

                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@TransType", transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(BalQty) from ItemMaster where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);
                }


                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "Record Updated Successfully";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }


        }

        protected void Delete_Click(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
        }
    }

}