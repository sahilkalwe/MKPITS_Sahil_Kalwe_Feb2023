using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_10_digit_by_creating_class_in_windows_form
{
    public partial class calculate1 : Form
    {
        public calculate1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculate1 c = new calculate1();
            int result = c.calculate1result(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text),
            Convert.ToChar(comboBox1.Text));
            label3.Text = "result : " + result;
        }
    }
}
