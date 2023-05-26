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
using System.Threading;

namespace Admission_form
{
    public partial class Form1 : Form
    {
        GENDER gender;
        enum GENDER { Male, Female }
        public Form1()
        {
            InitializeComponent();

            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = AdmissionForm.GetCountry();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "CountryName";
            comboBox1.ValueMember = "CountryID";

            DataSet ds1 = AdmissionForm.GetCourse();
            comboBox4.DataSource = ds1.Tables[0];
            comboBox4.DisplayMember = "CourseName";
            comboBox4.ValueMember = "CourseID";
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void clearall()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        public void Calculate_Total()
        {

            double Balance = Convert.ToDouble(textBox3.Text) - Convert.ToDouble(textBox4.Text);
            textBox5.Text = Balance.ToString();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = AdmissionForm.GetCourseFees(comboBox4.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox3.Text = dr["Fees"].ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {

            }
            else
            {
                Calculate_Total();
            }
           
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1 = AdmissionForm.GetState(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables["State"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1 = AdmissionForm.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds1.Tables["City"];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";
        }

        public void CheckUserDetails()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Fill All Mandatory Fields");

            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Please Fill Amount Paid");

            }
            else
            {


                string result = AdmissionForm.saveAdmission(textBox1.Text, Convert.ToInt16(textBox2.Text),
                Convert.ToInt32(comboBox1.SelectedValue),
                Convert.ToInt32(comboBox2.SelectedValue),
                Convert.ToInt32(comboBox3.SelectedValue),
                Convert.ToInt32(comboBox4.SelectedValue),
                dateTimePicker1.Value,
                Convert.ToInt32(textBox3.Text),
                Convert.ToDecimal(textBox4.Text),
                Convert.ToInt32(textBox5.Text));
                MessageBox.Show(result);

            }


        }
    }
}
