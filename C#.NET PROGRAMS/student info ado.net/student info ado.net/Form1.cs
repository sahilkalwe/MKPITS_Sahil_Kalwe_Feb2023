﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace student_info_ado.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            result = DatabaseConnection.InsertRecord(Convert.ToInt32(textBox1.Text), textBox2.Text, comboBox1.Text, comboBox2.Text);
            label1.Text = result;
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text=" ";    
            comboBox2.Text= " ";
            textBox1.Focus();
        }
    }
}