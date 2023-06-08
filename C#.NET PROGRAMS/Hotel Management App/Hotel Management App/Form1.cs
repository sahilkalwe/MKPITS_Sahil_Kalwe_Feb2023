using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel5.Hide();
            groupBox1.Hide();
            groupBox2.Hide();  
       
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Show();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
   
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox1.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox2.Hide();
            pictureBox1.Hide();
            pictureBox4.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox4.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox1.Hide();
        }
    }
}
