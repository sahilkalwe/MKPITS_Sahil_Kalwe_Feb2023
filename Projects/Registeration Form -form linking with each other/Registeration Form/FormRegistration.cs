using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Registeration_Form
{
    public partial class FormRegister : Form
    {
        #region =======CONSTRUCTOR=======
        public FormRegister()
        {
            InitializeComponent();
        }
        #endregion

        #region =======CONRTOL EVENT=======
        private void buttonReset_Click(object sender, EventArgs e)
        {
            this.textBoxage.Text = "";
            this.textBoxName.Text = "";
            this.textBoxMno.Text = "";
        }
        private void textBoxage_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBoxMno_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {           
            int age = Convert.ToInt32(textBoxage.Text);
            string mobile = textBoxMno.Text;
            string name = textBoxName.Text;

            using (Registeration_Form frmTest = new Registeration_Form(age, mobile, name))
            {
                frmTest.ShowDialog();
            }         
        } 









        #endregion
    }
}
