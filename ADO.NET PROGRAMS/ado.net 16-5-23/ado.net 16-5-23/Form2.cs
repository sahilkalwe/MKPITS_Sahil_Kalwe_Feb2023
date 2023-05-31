using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace ado.net_16_5_23
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
              

        }
        private void button8_Click(object sender, EventArgs e)

        {
            label8.Text = DatabaseConnection.DeleteUsers(textBox1.Text);
            clearall();
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
            label8.Text = EmployeeDetails.Insertemployee_detail( textBox1.Text,gender,
                textBox2.Text,Convert.ToInt32(textBox3.Text),comboBox1.Text, dateTimePicker1.Text);
            clearall();
        } 

        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = EmployeeDetails.GetCity();
            //reading the records from sqldatareader
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["city"].ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = EmployeeDetails.UpdateUsers(textBox1.Text,textBox3.Text);
            clearall();
        }
    }
}

