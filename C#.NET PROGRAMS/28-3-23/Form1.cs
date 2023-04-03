using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();

            String Country = comboBox1.Text;
            switch (Country)
            {
                case "INDIA":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Amravati");
                    comboBox2.Items.Add("Ballarshah");
                    break;
                case "USA":
                    comboBox2.Items.Add("san fransisco");
                    comboBox2.Items.Add("Los Angels");
                    comboBox2.Items.Add("America");
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "country : " + comboBox1.Text + "\n";
            label3.Text += "city : " + comboBox2.Text + "\n";

            label3.Text += "course : " + listBox1.SelectedItem.ToString() + "\n";
            label3.Text += "dob : " + dateTimePicker1.Text + "\n";
            label3.Text += "phone no : " + maskedTextBox1.Text + "\n";

        }
    }
}