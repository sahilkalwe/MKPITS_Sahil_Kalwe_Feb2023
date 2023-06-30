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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace fendahl_3
{
    public partial class Form1 : Form
    {

        enum Gender { Male, Female, Others }
        Gender gender;

        enum Pay { Cash,Emi}
        Pay pay;
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                gender = Gender.Male;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                gender = Gender.Female;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                gender = Gender.Others;
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = InvoiceDetails.GetProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "ProductCategory";
            comboBox1.ValueMember = "ProductCategoryID";

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataSet ds = InvoiceDetails.GetTableProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "ProductName";
            comboBox2.ValueMember = "ProductID";

            DataSet ds1 = InvoiceDetails.GetGST(comboBox1.Text);
                foreach(DataRow dr in ds1.Tables[0].Rows)
                {
                textBox7.Text = dr["CGST"].ToString();
                textBox8.Text = dr["SGST"].ToString();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox2.Text;
            DataSet ds = InvoiceDetails.GetProductPrice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox4.Text = dr["ProductPrice"].ToString();
            }
            DataSet ds1 = InvoiceDetails.GetAvailableQuantity(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox2.Text = dr["AvailableQuantity"].ToString();
            }
            DataSet ds2 = InvoiceDetails.GetTotalQuantity(comboBox2.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox3.Text = dr["TotalQuantity"].ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {

            }
            else
            {
                CalculateTotal();
            }
        }
         public void CalculateTotal()
            {
            double Total=Convert.ToDouble(textBox4.Text)*Convert.ToDouble(textBox5.Text);
            textBox6.Text = Total.ToString();
            double CGST = Convert.ToDouble(textBox4.Text) * ((Convert.ToDouble(textBox7.Text)/100.0));
            textBox9.Text = CGST.ToString();
            double SGST = Convert.ToDouble(textBox4.Text) *(( Convert.ToDouble(textBox8.Text)/100.0));
            textBox10.Text = SGST.ToString();
            double NetAmount = Convert.ToDouble(textBox6.Text)  +Convert.ToDouble(textBox9.Text)+ Convert.ToDouble(textBox10.Text);
            textBox11.Text = NetAmount.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
            pay = Pay.Cash;
            if (radioButton1.Checked)
            {
                textBox16.Text = textBox11.Text;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pay = Pay.Emi;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tamount = Convert.ToInt32(textBox11.Text);
            int pamount = Convert.ToInt32(textBox16.Text);
            int ramount = tamount- pamount;
            double eamount = 0;
            if(radioButton2.Checked)
            {
                if(ramount>0)
                {
                    eamount = ramount / 3.0;
                }
                string pname = textBox1.Text;
                DataSet ds=new DataSet();
                DataTable dt = new DataTable("EmiTable");
                DataRow dr;
                dt.Columns.Add(new DataColumn("srno",typeof(int)));
                dt.Columns.Add(new DataColumn("ProductName", typeof(string)));
                dt.Columns.Add(new DataColumn("Emi Amount", typeof(decimal)));
                for(int i=1;i<=3;i++)
                {
                    dr = dt.NewRow();
                    dr[0] = i;
                    dr[1] = pname;
                    dr[2] = eamount;
                    dt.Rows.Add(dr);
                }
                ds.Tables.Add(dt);
                dataGridView1.DataSource = ds.Tables["EmiTable"].DefaultView;

            }

        }

        private void radioButton1_Leave(object sender, EventArgs e)
        {
            textBox16.Text = "";
        }
    }

        //private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
    }

