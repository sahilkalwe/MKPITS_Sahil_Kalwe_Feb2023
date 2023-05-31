using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace civika_ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "server= LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=ADO.net";
            SqlConnection conn=new SqlConnection(con);
            try
            {
                conn.Open();
                label1.Text = "succesful";

            }


            catch(Exception ex)
            {
                label1.Text=ex.ToString(); 

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
