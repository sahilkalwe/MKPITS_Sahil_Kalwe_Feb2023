namespace calculator
{
    public partial class Form1 : Form
    {
        double FirstNumber;
        string Operation;
        public Form1()
        {
            InitializeComponent();

        }
        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void buttondot_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        private void buttonadd_Click(object sender, EventArgs e)
        {
             Operation = "+";
        }

        private void buttonsub_Click(object sender, EventArgs e)
        {
            Operation = "-";
        }

        private void buttonmul_Click(object sender, EventArgs e)
        {
            Operation = "*";
        }

        private void buttondiv_Click(object sender, EventArgs e)
        {
            Operation = "/";
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {

            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);

            if (Operation == "+")
            {
                Result = (FirstNumber + SecondNumber);
            }
            if (Operation == "-")
            {
                Result = (FirstNumber - SecondNumber);

            }
            if (Operation == "*")
            {
                Result = (FirstNumber * SecondNumber);

            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textBox1.Text = "Cannot divide by zero";

                }
                else
                {
                    Result = (FirstNumber / SecondNumber);


                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}