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
           //panel3.Hide();
           panel5.Hide();
           // groupBox1.Hide();
            panel4.Hide();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel4.Show();
            button1.Hide();
            button2.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           // groupBox1.Hide();
            //panel5.Show();
            panel5.Visible = true;
          
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel4.Show();
            button2.Hide();
            button3.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
