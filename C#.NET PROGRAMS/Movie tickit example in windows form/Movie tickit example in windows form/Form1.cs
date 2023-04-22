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
            comboBox1.Items.Clear();
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

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
