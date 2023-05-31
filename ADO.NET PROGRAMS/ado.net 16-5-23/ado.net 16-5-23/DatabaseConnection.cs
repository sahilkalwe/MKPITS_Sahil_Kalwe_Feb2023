using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace ado.net_16_5_23
{
    public static class DatabaseConnection
    {
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=ADO.net";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ex)
            {
                return null;
            }

        }




        //creating ststic method to insert record nto the table
        public static string InsertRecord(string username, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command

            string query = "Insert Into users values(@username,@password)";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class 
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.ExecuteNonQuery();
                return "Records Inserted Succesfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }

        //creating a static method to update records into users table

        public static string UpdateUsers(string username, string password)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "update users set password=@password where username=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters

                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "Record Updated Successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally
            {
                con.Close();
            }

        }
        //creating a static method to delete record from users table
        public static string DeleteUsers(string username)
        {
            SqlConnection con = GetConnection();
            //creating a insert command
            string query = "delete from users  where username=@username";
            //@username and @password are sqlparameters
            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters


                command.Parameters.AddWithValue("@username", username);
                //executing the command using executenonquery method
                command.ExecuteNonQuery();
                return "Record Deleted Successfully";
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

      //  internal static string InsertRecord(string text1, string text2, string text3, string text4, string text5, string text6, string text7)
        //{
           // throw new NotImplementedException();
        //}
    }


}


    
    
    
   