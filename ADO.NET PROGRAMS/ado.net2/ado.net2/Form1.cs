using staticconnectionex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado.net2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.GetConnection();
            if (con != null)
            {
                label1.Text = "connected successfully";

                con.Close();
            }
            else
            {
                label1.Text = "unable to connect";
            }
        }

    }
}

