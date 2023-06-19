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
using System.Drawing.Text;


namespace somaliaprj
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        static SqlConnection con;

        string sqlconn;

        private void connection()
        {
            string sqlconn = "server=.\\SQLEXPRESS;integrated security=true;database=sdb";
            con = new SqlConnection(sqlconn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();

              
                dt.Columns.Add("Source");
                dt.Columns.Add("Date_Uploaded");
                dt.Columns.Add("Time_Uploaded");
                dt.Columns.Add("Summary");
                dt.Columns.Add("Date");
                dt.Columns.Add("Estimated_Time");
                dt.Columns.Add("Killed");
                dt.Columns.Add("Injured");
                dt.Columns.Add("Number_of_Incidents");
                dt.Columns.Add("High_Impact");
                dt.Columns.Add("Source_Info_Rating");
                dt.Columns.Add("Location_Accuracy");
               dt.Columns.Add("Longitude");
                dt.Columns.Add("Province");
                dt.Columns.Add("Location");
                dt.Columns.Add("Activity_Type");
                dt.Columns.Add("Incident_Type");
                dt.Columns.Add("Incident_Sub_Type");
                dt.Columns.Add("Instigator");
                dt.Columns.Add("Sub_Type");
                dt.Columns.Add("Target");
                dt.Columns.Add("Sub_Type2");
                dt.Columns.Add("Criminal_Charges");
                dt.Columns.Add("Physical_Context");
                dt.Columns.Add("Reason_for_Protest");
                dt.Columns.Add("Number_of_Protesters");
                dt.Columns.Add("PMU_Faction");
                dt.Columns.Add("Tribal_Group");
                dt.Columns.Add("Major_Storm");
                dt.Columns.Add("Tactic");
                dt.Columns.Add("Unusual_Social_Political_Tension");
                dt.Columns.Add("Threat_Level");
                dt.Columns.Add("Disease_Outbreak");
                dt.Columns.Add("Drought");

                string CSVFilePath = Path.GetFullPath("sd.csv");


                string ReadCSV = File.ReadAllText(CSVFilePath);
              //  MessageBox.Show(ReadCSV.ToString());

                foreach (string csvRow in ReadCSV.Split('\n'))
                {
                    if (!string.IsNullOrEmpty(csvRow))
                    {
                        dt.Rows.Add();
                        int count = 0;
                        foreach (string FileRec in csvRow.Split(','))
                        {
                            dt.Rows[dt.Rows.Count - 1][count] = FileRec;
                            count++;
                        }

                    }
                }
                InsertCSVRecord(dt);
                MessageBox.Show("record saved successfully");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        private void InsertCSVRecord(DataTable csvdt)
        {
            string sqlconn = "server=.\\SQLEXPRESS;integrated security=true;database=sdb";

            con = new SqlConnection(sqlconn);

            SqlBulkCopy sbc = new SqlBulkCopy(con);
            sbc.DestinationTableName = "Somalia_Data1";


            
            sbc.ColumnMappings.Add("Source", "Source");
            sbc.ColumnMappings.Add("Date_Uploaded", "Date_Uploaded");
            sbc.ColumnMappings.Add("Time_Uploaded", "Time_Uploaded");
            sbc.ColumnMappings.Add("Summary", "Summary");
            sbc.ColumnMappings.Add("Date", "Date");
            sbc.ColumnMappings.Add("Estimated_Time", "Estimated_Time");
            sbc.ColumnMappings.Add("Killed", "Killed");
            sbc.ColumnMappings.Add("Injured", "Injured");
            sbc.ColumnMappings.Add("Number_of_Incidents", "Number_of_Incidents");
            sbc.ColumnMappings.Add("High_Impact", "High_Impact");
            sbc.ColumnMappings.Add("Source_Info_Rating", "Source_Info_Rating");
            sbc.ColumnMappings.Add("Location_Accuracy", "Location_Accuracy");
            
            sbc.ColumnMappings.Add("Longitude", "Longitude");
            sbc.ColumnMappings.Add("Province", "Province");
            sbc.ColumnMappings.Add("Location", "Location");
            sbc.ColumnMappings.Add("Activity_Type", "Activity_Type");
            sbc.ColumnMappings.Add("Incident_Type", "Incident_Type");
            sbc.ColumnMappings.Add("Incident_Sub_Type", "Incident_Sub_Type");
            sbc.ColumnMappings.Add("Instigator", "Instigator");
            sbc.ColumnMappings.Add("Sub_Type", "Sub_Type");
            sbc.ColumnMappings.Add("Target", "Target");
            sbc.ColumnMappings.Add("Sub_Type2", "Sub_Type2");
            sbc.ColumnMappings.Add("Criminal_Charges", "Criminal_Charges");
            sbc.ColumnMappings.Add("Physical_Context", "Physical_Context");
            sbc.ColumnMappings.Add("Reason_for_Protest", "Reason_for_Protest");
            sbc.ColumnMappings.Add("Number_of_Protesters", "Number_of_Protesters");
            sbc.ColumnMappings.Add("PMU_Faction", "PMU_Faction");
            sbc.ColumnMappings.Add("Tribal_Group", "Tribal_Group");
            sbc.ColumnMappings.Add("Major_Storm", "Major_Storm");
            sbc.ColumnMappings.Add("Tactic", "Tactict");
            sbc.ColumnMappings.Add("Unusual_Social_Political_Tension", "Unusual_Social_Political_Tension");
            sbc.ColumnMappings.Add("Threat_Level", "Threat_Level");
            sbc.ColumnMappings.Add("Disease_Outbreak", "Disease_Outbreak");
            sbc.ColumnMappings.Add("Drought", "Drought");


            con.Open();
            sbc.WriteToServer(csvdt);
            con.Close();

        }
    }
}
