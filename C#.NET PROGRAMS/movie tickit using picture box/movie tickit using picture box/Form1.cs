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

namespace movie_tickit_using_picture_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            groupBox3.Hide();
            button2.Hide(); 

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Items.Clear();
            switch (comboBox1.Text)
            {
                case "PK":
                    pictureBox1.Show();
                    comboBox2.Items.Add("Vr");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Smruti");
                    comboBox2.Items.Add("Laxmi");
                    comboBox2.Items.Add("Alankar");
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    break;
                case "Highway":
                    pictureBox2.Show();
                    comboBox2.Items.Add("Sangam");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Vr");
                    pictureBox1.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    break;
                case "3 Idiots":
                    comboBox2.Items.Add("Inox");
                    comboBox2.Items.Add("Sangam");
                    comboBox2.Items.Add("Pvr");
                    pictureBox3.Show();
                    pictureBox2.Hide();
                    pictureBox1.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    break;
                case "Bahubali":
                    comboBox2.Items.Add("Vr");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Inox");
                    comboBox2.Items.Add("Alankar");
                    comboBox2.Items.Add("Laxmi");
                    pictureBox4.Show();
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    pictureBox1.Hide();
                    pictureBox5.Hide();
                    pictureBox6.Hide();
                    break;
                case "RRR":
                    comboBox2.Items.Add("Inox");
                    comboBox2.Items.Add("Sangam");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Smruti");
                    pictureBox5.Show();
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox1.Hide();
                    pictureBox6.Hide();
                    break;
                case "Kuch Kuch Hota Hain":
                    comboBox2.Items.Add("Inox");
                    comboBox2.Items.Add("Sangam");
                    comboBox2.Items.Add("Pvr");
                    comboBox2.Items.Add("Alankar");
                    pictureBox6.Show();
                    pictureBox2.Hide();
                    pictureBox3.Hide();
                    pictureBox4.Hide();
                    pictureBox5.Hide();
                    pictureBox1.Hide();
                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "Vr":
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
                    textBox1.Text = "170";
                    break;
                case "Sangam":
                    comboBox3.Items.Add("9.00PM");
                    comboBox3.Items.Add("10.30PM");
                    textBox1.Text = "160";
                    break;
                case "Smruti":
                    comboBox3.Items.Add("1.30PM");
                    comboBox3.Items.Add("6.15PM");
                    comboBox3.Items.Add("8.00PM");
                    textBox1.Text = "150";
                    break;
                case "Laxmi":
                    comboBox3.Items.Add("2.30PM");
                    comboBox3.Items.Add("3.15PM");
                    comboBox3.Items.Add("4.00PM");
                    textBox1.Text = "300";
                    break;
                case "Alankar":
                    comboBox3.Items.Add("7.30PM");
                    comboBox3.Items.Add("8.15PM");
                    comboBox3.Items.Add("9.00PM");
                    textBox1.Text = "180";
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox3.Show();
            button2.Show();
            label16.Text =comboBox1.Text;
            label17.Text = comboBox2.Text;
            label18.Text = comboBox3.Text;
            label19.Text = numericUpDown1.Text;
            MovieTicket mt = null;
            if (radioButton1.Checked)
            {
                mt = new OnlineBooking(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));
            }
            else if (radioButton2.Checked)
            {
                //mt=new BoxOffice(Convert.ToInt32)(numericUpDown1.Value), Convert.ToSingle(textBox1.Text);
            }
            label15.Text = mt.CalculateTicketPrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Ticket Book Succesfully");
        }
    }
}