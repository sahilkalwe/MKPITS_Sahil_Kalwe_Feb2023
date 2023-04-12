using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace calculator_by_creating_class_in_windows_form
{
    public partial class calculatordesign : Form
    {
        public calculatordesign()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            textBox1.Text = "1";
        }
        calculator cal = new calculator();

        private void button2_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = "2";
            }
            calculator cal = new calculator();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                textBox1.Text = "3";
            }
            calculator cal = new calculator();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.plusclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(cal.minusclick(Convert.ToInt32(textBox1.Text)));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int result = cal.calculateresult(Convert.ToInt32(textBox1.Text));
            textBox1.Text = result.ToString();
        }
    }
}
