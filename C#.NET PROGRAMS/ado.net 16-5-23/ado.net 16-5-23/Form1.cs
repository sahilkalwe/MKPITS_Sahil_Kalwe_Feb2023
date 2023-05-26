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

namespace ado.net_16_5_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.InsertRecord(textBox1.Text, textBox2.Text);
            clearall();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.UpdateUsers(textBox1.Text, textBox2.Text);
            clearall();
        }
        public void clearall()
        {
            textBox1.Clear();
            textBox2.Clear();   
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Text = DatabaseConnection.DeleteUsers(textBox1.Text);
            clearall();

        }
    }
}
