using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ado.net_17_5_23
{
    public static class EmployeeDetails
    {
        private static string connectionString="server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=Ado.net;";
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
        public static string Insertemployee_detail(string name, string gender, string email, int mobile_number, string city, string dob)
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

        public static string UpdateUsers(string name, int mobile_number)
        {
            SqlConnection con = GetConnection();
            string query = "update employee_detail set name=@name where mobile_number=@mobile_number";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@mobile_number", mobile_number);
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
        //creating method to delete record from users table
        public static string DeleteUsers(string name)
        {
            SqlConnection con = GetConnection();
            string query = "delete from employee_detail where name=@name";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@name",name);
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

        public static DataSet getEmployeeDetails()
        {
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            string qr = "select * from employee_detail";
            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.Fill(ds, "employee_detail");
            return ds;

        }
        public static DataSet searchemployee(int Employee_Number)
        {
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            string qr = "select * from employee_detail where Employee_Number=@Employee_Number";

            SqlDataAdapter da = new SqlDataAdapter(qr, con);
            da.SelectCommand.Parameters.AddWithValue("@Employee_Number",Employee_Number);
            da.Fill(ds, "employee_details");
            return ds;
        }





    }


}

