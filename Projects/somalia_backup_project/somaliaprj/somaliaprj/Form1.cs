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
using System.IO;

namespace somaliaprj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       static SqlConnection con;

        string sqlconn;
        private void connection()
        {
            string sqlconn = "server='\\sqlexpress;integrated security=true;database=somaliaproject";
            
            con = new SqlConnection(sqlconn);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Creating object of datatable  
                DataTable tblcsv = new DataTable();
                //creating columns  
                tblcsv.Columns.Add("Name");
                tblcsv.Columns.Add("City");

                DataTable tblcsv1 = new DataTable();
                tblcsv1.Columns.Add("Address");
                tblcsv1.Columns.Add("Designation");
                //getting full file path of Uploaded file  
                string CSVFilePath = Path.GetFullPath("employeedet.csv");
                //  MessageBox.Show(CSVFilePath);
                //Reading All text  
                string ReadCSV = File.ReadAllText(CSVFilePath);
                MessageBox.Show(ReadCSV.ToString());
                //spliting row after new line  
              
                foreach (string csvRow in ReadCSV.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(csvRow))
                    {
                        //Adding each row into datatable  
                        tblcsv.Rows.Add();
                        tblcsv1.Rows.Add();
                        int count = 0;
                        int count1 = 0;
                        int cnt = 0;
                        foreach (string FileRec in csvRow.Split(','))
                        {
                            if (cnt  <2)
                            {
                                tblcsv.Rows[tblcsv.Rows.Count - 1][count] = FileRec;
                                cnt++;
                                count++;
                            }
                            else if(cnt <4)
                            {
                                tblcsv1.Rows[tblcsv1.Rows.Count - 1][count1] = FileRec;
                                cnt++;
                                count1++;
                            }
                          
                        }
                    }
                }

                //Calling insert Functions  
               InsertCSVRecords(tblcsv,tblcsv1);
                MessageBox.Show("record saved successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        //Function to Insert Records  
        private void InsertCSVRecords(DataTable csvdt, DataTable csvdt1)
        {

            //  connection();
            string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliaproject";

            con = new SqlConnection(sqlconn);
            //creating object of SqlBulkCopy    
            SqlBulkCopy objbulk = new SqlBulkCopy(con);
            //assigning Destination table name    
            objbulk.DestinationTableName = "emp1";
            //Mapping Table column    
            objbulk.ColumnMappings.Add("Name", "name");
            objbulk.ColumnMappings.Add("City", "city");
         
            //inserting Datatable Records to DataBase    
            con.Open();
            objbulk.WriteToServer(csvdt);
            con.Close();


            //creating object of SqlBulkCopy    
            SqlBulkCopy objbulk1 = new SqlBulkCopy(con);
            //assigning Destination table name    
            objbulk1.DestinationTableName = "emp2";
            //Mapping Table column    

            objbulk1.ColumnMappings.Add("Address", "address");
            objbulk1.ColumnMappings.Add("Designation", "designation");
            //inserting Datatable Records to DataBase    
            con.Open();
            objbulk1.WriteToServer(csvdt1);
            con.Close();



        }
    }
}
