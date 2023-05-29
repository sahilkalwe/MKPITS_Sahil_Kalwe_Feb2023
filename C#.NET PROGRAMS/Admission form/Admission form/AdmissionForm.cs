using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Reflection;

namespace Admission_form
{
    public static class AdmissionForm
    {
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01; integrated security=true;database=AdmissionForm;";
        //method to create connection 
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception ee)
            {
                return null;
            }
            finally
            {
                //conn.Close();
            }
        }

        public static DataSet GetCountry()
        {
            SqlConnection con = GetConnection();
            string query = "select * from Country";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "CountryName");
            return ds;
        }

        public static DataSet GetCourse()
        {
            SqlConnection con = GetConnection();
            string query = "select * from Course";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "CourseName");
            return ds;
        }


        public static DataSet GetState(string CountryName)
        {
            SqlConnection con = GetConnection();
            string query = "select p.StateID,p.StateName from State p inner join Country t on p.CountryID=t.CountryID where CountryName=@CountryName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@CountryName",CountryName);
            da.Fill(ds, "State");
            return ds;
        }


        public static DataSet GetCity(string StateName)
        {
            SqlConnection con = GetConnection();
            string query = "select p.CityID,p.CityName from City p inner join State t on p.StateID = t.StateID where StateName = @StateName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@StateName", StateName);
            da.Fill(ds, "City");
            return ds;
        }
        public static DataSet GetCourseFees(string CourseName)
        {
            SqlConnection con = GetConnection();
            string query = "select Fees from Course where CourseName = @CourseName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@CourseName", CourseName);
            da.Fill(ds, "Course");
            return ds;
        }
            public static string saveAdmission(int gender,string Contact, int Country_ID, int State_ID, int City_ID, DateTime AdmissionDate,int CourseID ,decimal fees, decimal AmountPaid, decimal Balance)
        {

         
            String result = null;
            string query = "Insert Into Admission Values (@Gender,@Contact,@Country_ID,@State_ID,@City_ID,@AdmissionDate,@CourseID,@fees,@AmountPaid,@Balance)";
            SqlConnection con = GetConnection();
            SqlCommand command = new SqlCommand(query, con);
            //command.Parameters.AddWithValue("@AdmissionID",AdmissionID);
           // command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Gender",gender);
            command.Parameters.AddWithValue("@Contact",Contact);
            command.Parameters.AddWithValue("@Country_ID", Country_ID);
            command.Parameters.AddWithValue("@State_ID", State_ID);
            command.Parameters.AddWithValue("@City_ID", City_ID);
            command.Parameters.AddWithValue("@AdmissionDate", AdmissionDate);
            command.Parameters.AddWithValue("@CourseID", CourseID);
            command.Parameters.AddWithValue("@fees", fees);
            command.Parameters.AddWithValue("@AmountPaid", AmountPaid);
            command.Parameters.AddWithValue("@Balance", Balance);
            try
            {
                command.ExecuteNonQuery();
                result = "Record Saved Successfully";
            }

            catch (Exception ee)
            {
                result = ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return result;

        }



    }
}
