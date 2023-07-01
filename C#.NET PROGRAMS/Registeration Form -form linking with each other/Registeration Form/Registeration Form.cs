using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registeration_Form
{
    public partial class Registeration_Form : Form
    {
        public Registeration_Form(int age,string name,string mobile)
        {
            this.InitializeComponent();
            this.labelAge.Text = age.ToString();
            this.labelName.Text = name;
            this.labelName.Text = mobile.ToString();
        }
    }
}
