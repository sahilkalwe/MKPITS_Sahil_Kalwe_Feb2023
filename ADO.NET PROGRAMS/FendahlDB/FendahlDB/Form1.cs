using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics;

namespace FendahlDB
{
    public partial class Form1 : Form
    {
        //creating an enum for Nationality
        enum Nationality {Indian,NRI}
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;
        public Form1()
        {
            InitializeComponent();
            //CODE TO SET DATE
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = Product_Store.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
           comboBox1.ValueMember = "Product_Category_ID";
        }
 
  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filling the product name in combobox2
            DataSet ds = Product_Store.GetTableProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember= "ProductName";
            comboBox2.ValueMember = "ProductID";


            //for filling GST textboxes
            DataSet ds1 =Product_Store.GetGstDetails(comboBox1.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
               // textBox6.Text = dr["CGST"].ToString();
                //textBox7.Text = dr["SGST"].ToString();
                //textBox8.Text = dr["IGST"].ToString();    
                cgst=Convert.ToInt32( dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());

            }

            if (nationality==0) //i.e. nationality is an indian means value is 0. 
            {
                //if nationality is indian the totalgst i.e.tgst is sum of cgst and sgst
                tgst = cgst + sgst;
            }
            else //nationality is NRI
            {
                tgst=igst; // tgst is only igst not sum
            }
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = tgst.ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(! Char.IsControl(e.KeyChar) && ! Char.IsDigit(e.KeyChar))
                    {
                e.Handled = true;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //filling product price in textbox
            DataSet ds = Product_Store.GetProductPrice(comboBox2.Text);
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                textBox4.Text = dr["ProductPrice"].ToString();
            }
        }
        Nationality  nationality;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            //messageBox.show(nationality.ToString());
            textBox6.Text=cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = Convert.ToString(Convert.ToInt32(textBox6.Text)+Convert.ToInt32(textBox7.Text));
            Calculate_Total();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI; //i.e. enum value is 1 i.e. nationality is NRI
            //MessageBox.Show(nationality.ToString());
            textBox6.Text=cgst.ToString();
            textBox7.Text=sgst.ToString();  
            textBox8.Text=igst.ToString();
            Calculate_Total();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {

            }
            else
            {
                Calculate_Total();
            }
        }


        public void Calculate_Total()
        {

            double TotalAmount = Convert.ToDouble(textBox4.Text) * Convert.ToDouble(textBox12.Text);
            textBox3.Text = TotalAmount.ToString();

            double CGSTAmount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox6.Text) / 100.0);
            textBox9.Text = CGSTAmount.ToString();

            double SGSTAmount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox7.Text) / 100.0);
            textBox10.Text = SGSTAmount.ToString();

            double IGSTAmount = Convert.ToDouble(textBox4.Text) * (Convert.ToDouble(textBox8.Text) / 100.0);
            textBox11.Text = IGSTAmount.ToString();


            double NETAmount = 0;
            if (nationality == 0)
            {
                NETAmount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);

            }
            else
            {
                NETAmount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);
            }



            // double NETAmount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);
            textBox5.Text = NETAmount.ToString();

        }
        public void clearall()
        {
            textBox9.Text="";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox4.Text = "";
            textBox12.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            clearall();   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckUserDetails();
            clearall();

        }
        public void CheckUserDetails()
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                MessageBox.Show("Please Fill All Mandatory Fields");

            }
            else if (textBox12.Text== "0")
            {
                MessageBox.Show("Quantity Can't Be Zero");

            }
            else
            {


                string result=Product_Store.saveTableInvoiceDetails(textBox1.Text, Convert.ToInt32(textBox2.Text), 
                    Convert.ToInt32(comboBox1.SelectedValue), 
                    Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(nationality),
                    dateTimePicker1.Value, Convert.ToDecimal(textBox3.Text),
                    Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text),
                    Convert.ToDecimal(textBox6.Text), Convert.ToDecimal(textBox7.Text), 
                    Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox11.Text),
                    Convert.ToDecimal(textBox12.Text), Convert.ToDecimal(textBox8.Text));
                    MessageBox.Show(result);

            }
            

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
