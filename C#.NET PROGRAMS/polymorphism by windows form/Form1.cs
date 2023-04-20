using System;

namespace polymorphism_by_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                account1 act = null;
                string Acttype;
                Acttype = Convert.ToString(comboBox1.Text);
                if (Acttype == "saving")
                {
                act = new Saving();
                    int result = act.deposit(Convert.ToInt32(textBox2.Text));
                    label4.Text = Convert.ToString("balance :" + result);
                }
                else if (Acttype == "current")
                {
                    act = new Current();
                    int result = act.deposit(Convert.ToInt32(textBox2.Text));
                    label4.Text = Convert.ToString("balance :" + result);
                }
            }
        }

    
  }