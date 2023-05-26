using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace student_info_ado.net
{
    internal class DatabaseConnection
    {
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=student";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }

        }
        public static string InsertRecord(int roll_no, string name,string course,string designation)
        {
            SqlConnection con = GetConnection();
            string query = "insert into stud11 values(@roll_no,@name,@course,@designation)";
            try
            {
                SqlCommand command = new SqlCommand(query,con);
                command.Parameters.AddWithValue("@roll_no", roll_no);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@course", course);
                command.Parameters.AddWithValue("@designation", designation);
                command.ExecuteNonQuery();
                return "Record Inserted Successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }

            finally
            {
                con.Close();
            }

        }

    }
}
