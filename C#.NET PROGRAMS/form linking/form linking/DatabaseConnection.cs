using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace form_linking
{
    public static class DatabaseConnection
    {//creating ststic variable
        private static string cs = "server= LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=FormLinking";
        //creating static method
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(cs);
            try
            {
                con.Open();
                return con;

            }
            catch (SqlException e)
            {
                return null;
            }
        }

        //creating ststic method to insert record into users table
        public static string InsertRecord(String username, String password)
        {
            SqlConnection con = GetConnection();
            // creating a insert command 
            string query = "insert into form1 values(@username,@password)";
            ////@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "Record Inserted Succesfully";
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