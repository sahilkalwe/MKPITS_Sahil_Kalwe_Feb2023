using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_tickit_example_in_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           //comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text="";
            switch(comboBox1.Text)
            {
                case"Hum Apke Hain Kon":
                    comboBox2.Items.Add("Vr");
                    comboBox2.Items.Add("Pvr");
                    break;
                case "Hum Saath Saath Hain":
                    comboBox2.Items.Add("Sangam");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Vr");
                    break;
                case "Koi Mil Gaya":
                    comboBox2.Items.Add("Inox");
                    comboBox2.Items.Add("Sangam");
                    comboBox2.Items.Add("Pvr");
                    break;
                case "Run":
                    comboBox2.Items.Add("Vr");
                    break;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie_Tickit mt = null;
            if (radioButton1.Checked)
            {
                mt= new Online_Booking(Convert.ToInt32(numericUpDown1.Value),Convert.ToSingle(textBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                //mt =new Box_Office(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));
            }
            label7.Text = mt.Calculate_Tickit_price();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) 
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch(comboBox2.Text) 
            {
                case "vr":
                    comboBox3.Items.Add("9.00AM");
                    comboBox3.Items.Add("10.30AM");
                    comboBox3.Items.Add("1.30PM");
                    comboBox3.Items.Add("3.30PM");
                    textBox1.Text = "420";
                    break;
                case "Pvr":
                    comboBox3.Items.Add("11.30AM");
                    comboBox3.Items.Add("2.30PM");
                    comboBox3.Items.Add("3.30PM");
                    comboBox3.Items.Add("5.30PM");
                    textBox1.Text = "320";
                    break;
                case "Inox":
                    comboBox3.Items.Add("5.30PM");
                    comboBox3.Items.Add("7.15PM");
                    comboBox3.Items.Add("9.00PM");
                    textBox1.Text = "120";
                    break;
                case "Sangam":
                    comboBox3.Items.Add("9.PM");
                    comboBox3.Items.Add("10.30PM");
                    textBox1.Text = "20";
                    break;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
