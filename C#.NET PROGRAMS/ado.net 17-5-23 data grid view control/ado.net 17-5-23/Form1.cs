using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ado.net_17_5_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string gender = null;
            if (radioButton1.Checked)
            {
                gender = "male";
            }
            else if (radioButton2.Checked)
            {
                gender = "female";
            }
            label8.Text = EmployeeDetails.Insertemployee_detail(textBox1.Text, gender,
                textBox2.Text, Convert.ToInt32(textBox3.Text), comboBox1.Text, dateTimePicker1.Text);
            clearall();

        }

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDetails.getEmployeeDetails();
            dataGridView1.DataSource = ds.Tables[0];



            SqlDataReader dr = EmployeeDetails.GetCity();
            //reading the records from sqldatareader
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["city"].ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = EmployeeDetails.UpdateUsers(textBox1.Text, Convert.ToInt32(textBox3.Text));
            clearall();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            label8.Text = EmployeeDetails.DeleteUsers(textBox1.Text);
            clearall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = EmployeeDetails.searchemployee(Convert.ToInt32(textBox4.Text));
            dataGridView1.DataSource = ds.Tables[0];
            textBox1.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            string gender = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            if (gender == "male")
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;

        }
    }
}
