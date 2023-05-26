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

namespace Fendahl2
{
    public partial class Form1 : Form
    {
        enum Category { Student,ITProfessional}
        enum Gender {Male,Female}
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


        public void CalculateTotal()
        {


            double BalanceAmount = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text);
            textBox4.Text = BalanceAmount.ToString();

            double PaidAmount = 0;
            if (Category == 0)
            {
                BalanceAmount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);

            }
            else
            {
                BalanceAmount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);
            }
            // double NETAmount = Convert.ToDouble(textBox3.Text) + Convert.ToDouble(textBox11.Text);
            textBox5.Text = NETAmount.ToString();
        }
private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            //   string str=CourseRegistration1.
            ds = CourseRegistration1.GetNation();
            comboBox1.DataSource = ds.Tables["TableNation"];
            comboBox1.DisplayMember = "NationName";
            comboBox1.ValueMember = "NationID";
            
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
            
            clearall();

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
