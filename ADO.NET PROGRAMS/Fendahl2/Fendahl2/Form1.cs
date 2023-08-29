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
using static System.Windows.Forms.AxHost;

namespace Fendahl2
{
    public partial class Form1 : Form
    {
        enum Category {Student,ITProfessional}
        Category category;
        enum Gender {Male,Female,Other}
        Gender gender;
        public object CourseRegistration { get; private set; }
        
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        double fp=0;
        double total=0;
        public void CalculateBalance()
        {
             total = Convert.ToDouble(textBox2.Text);
            // variable fp for calculate 50%
            fp = 0;
            if (category==0)
            {
                fp = total * 0.5;

            }
            else
            {
                fp=total * 0.8;
            }
            if (Convert.ToDouble(textBox3.Text)<fp)
            {
                MessageBox.Show("You should pay minimum 50% amount for student and 80% amount for the IT Professionals ");

            }
            else
            {
                double balance = Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox3.Text);
                    textBox4.Text = balance.ToString();
            }
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = CourseRegistration1.GetNation();
            comboBox1.DataSource = ds.Tables["TableNation"];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";
            textBox2.Text = "1000";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1=CourseRegistration1.GetState(comboBox1.Text);
            comboBox2.DataSource = ds1.Tables["TableState"];
            comboBox2.DisplayMember = "StateName";
            comboBox2.ValueMember = "StateID";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            ds1 = CourseRegistration1.GetCity(comboBox2.Text);
            comboBox3.DataSource = ds1.Tables["TableCity"];
            comboBox3.DisplayMember = "CityName";
            comboBox3.ValueMember = "CityID";
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


        public void clearall()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertRecord();
            clearall();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                category = Category.Student;
                textBox2.Text = "1000";  
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
            {
                category = Category.ITProfessional;
                textBox2.Text = "3000";
                textBox3.Clear();
                textBox4.Clear();
            }
        }
        private void textBox3_Leave(object sender, EventArgs e)
        {
            CalculateBalance();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                gender = Gender.Male;   
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                gender = Gender.Female;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton3.Checked)
            {
                gender = Gender.Other; 
            }
        }
        public void InsertRecord()
        {
            string result = CourseRegistration1.saveTableCourseRegDetails(Convert.ToInt32(category), textBox1.Text,Convert.ToInt32(gender));
                MessageBox.Show(result);

            result = CourseRegistration1.SaveTableRegAddress(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox3.SelectedValue));

                MessageBox.Show(result);
            result = CourseRegistration1.saveTableFeeDetails(Convert.ToDouble(textBox2.Text),fp, Convert.ToDouble(textBox3.Text), Convert.ToDouble(textBox4.Text), dateTimePicker1.Value);
                MessageBox.Show(result);    
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
