using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            Invoice_Form I1 = null;
            Customer_Form C1 = null;
            Student_Form S1 = null;
        private void invoiceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            I1= new Invoice_Form();
            I1.MdiParent = this;
            I1.Show();
       
        }

        private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C1=new Customer_Form();
            C1.MdiParent = this;
            C1.Show();

        }

        private void studentFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            S1=new Student_Form();
            S1.MdiParent=this;
            S1.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);

        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            I1=new Invoice_Form();
            I1.MdiParent = this;    
            I1.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            C1 =new Customer_Form();
            C1.MdiParent = this;
            C1.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            S1 =new Student_Form();
            S1.MdiParent = this;
            S1.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            for(int i=0;i<=100;i++)
            {
                toolStripProgressBar1.Value = i;
            }
            I1=new Invoice_Form();
            I1.MdiParent = this;
                I1.Show();
        }

        private void toolStripSplitButton2_ButtonClick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                toolStripProgressBar1.Value = i;
            }

                C1 = new Customer_Form();
            C1.MdiParent = this;
            C1.Show();

        }

        private void toolStripSplitButton3_ButtonClick(object sender, EventArgs e)
        {
                for (int i = 0; i <= 100; i++)
                {
                    toolStripProgressBar1.Value = i;
                }

                S1 = new Student_Form();
                S1.MdiParent = this;
                S1.Show();

            }

        private void toolStripSplitButton4_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
