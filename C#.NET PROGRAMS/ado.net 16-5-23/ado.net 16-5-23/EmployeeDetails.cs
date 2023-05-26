using System;
using System.Data.SqlClient;

namespace ado.net_16_5_23
{
    public static  class EmployeeDetails
    {
        //creating a static variable
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=Ado.net;";
        //creating a static method
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
        //method to return city name 
        public static SqlDataReader GetCity()
        {
            SqlConnection con = GetConnection();
            string query = "select * from city";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                //sqldatareader is used to store record returned from city table
                SqlDataReader dr = command.ExecuteReader();
                return dr;
            }
            catch
            {
                return null;
            }

        }

        //creating ststic method to insert record into the table
        public static string Insertemployee_detail(string name , string gender,string email,int mobile_number,string city,string dob)
        {
            SqlConnection con = GetConnection();
            //creating a insert command

            string query = "Insert Into employee_detail values(@name,@gender,@email,@mobile_number,@city,@dob)";
           
            try
            {
                //creating an object of sqlcommand class 
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@mobile_number", mobile_number);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@dob", dob);
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

        public static string UpdateUsers(string name,int mobile_number)
        {
            SqlConnection con = GetConnection();
            string query = "update employee_detail set name=@name where mobile_number=@mobile_number";

            try
            {
                //creating an object of sqlcommand class
                SqlCommand command = new SqlCommand(query, con);
                //defining sqlparameters
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@mobile_number", mobile_number);
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
            string query = "delete from employee_detail where username=@username";
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

        internal static string UpdateUsers(string text1, string text2)
        {
            throw new NotImplementedException();
        }
    }


}
    


