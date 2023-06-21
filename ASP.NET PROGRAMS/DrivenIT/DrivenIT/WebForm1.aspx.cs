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
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox3.Text));
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
                   bq=bq-Convert.ToInt32(TextBox3.Text);
                }
                else if (transt=="R")
                {
                   bq=bq+Convert.ToInt32(TextBox3.Text);

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
            int updateqty = 0;
            Response.Write("Transaction ID " + transid.ToString());
            updateqty = Convert.ToInt32(TextBox3.Text) - oldtransqty;
            Response.Write("Updated Qty " + updateqty.ToString());

            try
            {
                query = "update transactions set TransType=@TransType,TransQty=@TransQty,TransDate=@TransDate where TransID=@TransID";
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
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.Parameters.AddWithValue("@TransType", transt);
                command.Parameters.AddWithValue("@TransQty", Convert.ToInt32(TextBox3.Text));
                command.Parameters.AddWithValue("@TransDate", TextBox2.Text);
                command.Parameters.AddWithValue("@TransID", transid);
                con.Open();
                command.ExecuteNonQuery();

                //getting the balqty from itemmaster table for particular item id
                query = "select max(BalQty) from ItemMaster where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                Response.Write("bq " + bq.ToString());
                Response.Write("Updateqty " + updateqty.ToString());
                if (RadioButton1.Checked)
                    bq = bq - updateqty;
                if (RadioButton2.Checked)
                    bq = bq + updateqty;
                Response.Write("<br>newupdateqty " + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "Stock Not Avilable";
                }
                else
                {


                //if (transt == "I")
                //{
                //    bq = bq - Convert.ToInt32(TextBox1.Text);
                //}
                //else if (transt == "R")
                //{
                //    bq = bq + Convert.ToInt32(TextBox1.Text);
                //}


                //updating bal qty on item master table
                query = "update ItemMaster set BalQty=@BalQty where ItemID=@ItemID";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@BalQty", bq);
                command.Parameters.AddWithValue("@ItemID", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "Record Updated Successfully";
            }
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


        static int transid = 0;
        static int oldtransqty = 0;

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox3.Text = GridView1.SelectedRow.Cells[3].Text;


            //oldtransqty= Convert.ToInt32(TextBox1.Text);
            //DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            //TextBox2.Text=dd.ToString("yyyy-MM-dd");
            //DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[1].Text;
            //string res = GridView1.SelectedRow.Cells[3].Text;
            //if(res=="I")
            //{
            //    RadioButton2.Checked = false;
            //    RadioButton1.Checked=true;
            //}
            //if(res=="R")
            //{
            //    RadioButton1.Checked = false;
            //    RadioButton2.Checked = true;
            //}
            //transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }
    }

}