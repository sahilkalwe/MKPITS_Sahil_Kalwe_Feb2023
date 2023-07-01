using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendahl_3
{
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
           
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            using (Test frmTest = new Test())
            {
                frmTest.ShowDialog();               
            }
        }

     
    }
}
