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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
        }
        Nationality nationality;
        private void button2_Click(object sender, EventArgs e)
        {
            Clearall();
        }
        public void Clearall()
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetTableProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_ID";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetTableProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";
            comboBox2.ValueMember = "ProductID";


            DataSet ds1 = ProductStore.GetGSTDetails(comboBox1.Text);
                foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());

            }
            if (nationality == 0)
            {
                tgst = cgst + sgst;
            }
            else
            {
                tgst = igst;
            }
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = tgst.ToString();

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox9.Text = dr["ProductPrice"].ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text));
            Calculate_Total();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {

            }
            else
            {
                Calculate_Total();
            }
        }
        public void Calculate_Total()
        {

            double TotalAmount = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox10.Text);
            textBox11.Text = TotalAmount.ToString();

            double CGSTAmount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox3.Text) / 100.0);
            textBox6.Text = CGSTAmount.ToString();

            double SGSTAmount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
            textBox7.Text = SGSTAmount.ToString();

            double IGSTAmount = Convert.ToDouble(textBox9.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
            textBox8.Text = IGSTAmount.ToString();

            double NETAmount = Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
            textBox12.Text = NETAmount.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CheckUserDetails();
            Clearall();

        }
        public void CheckUserDetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill All Mandatory Fields");

            }
            else if (textBox10.Text == "0")
            {
                MessageBox.Show("Quantity Can't Be Zero");

            }
            else
            {
                string result = ProductStore.saveTableInvoiceDetails(textBox1.Text, Convert.ToInt32(textBox2.Text),
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
        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = igst.ToString();
            Calculate_Total();
        }
    } 
}

