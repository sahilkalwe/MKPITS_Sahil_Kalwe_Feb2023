using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fendahl2
{
    public static class CourseRegistration1
    {
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01; integrated security=true;database=fendahltwo;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                //conn.Open();
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

        public static DataSet GetNation()

        {
            string query = "select * from TableNation";
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableNation");
            return ds;
        }
        public static DataSet GetState(string NationName)

        {
            string query = "select s.Stateid,s.StateName from TableState s inner join TableNation n on s.NationID=n.NationId where n.NationName =@NationName ";
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@NationName", NationName);
            da.Fill(ds, "TableState");
            return ds;
        }

        public static DataSet GetCity(string StateName)
        {
            string query = "select s.CityID,s.CityName from TableCity s inner join TableState n on s.StateID=n.StateID where n.StateName=@StateName";
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("StateName", StateName);
            da.Fill(ds, "TableCity");
            return ds;
        }

        public static string saveTableCourseRegDetails(int CategoryID, string FullName, int GenderID)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "insert into TableCourseRegDetails values(@CategoryID,@FullName,@GenderID)";
            SqlCommand command= new SqlCommand(query, con);
            command.Parameters.AddWithValue("CategoryID", CategoryID);
            command.Parameters.AddWithValue("FullName", FullName);
            command.Parameters.AddWithValue("GenderID", GenderID);
            command.ExecuteNonQuery();
            con.Close();
            return "Record Saved Succesfully In TableCourseRegDetails";

        }
        static int CourseRegID = 0;
        //save Records in TableRegAddress
        public static string SaveTableRegAddress(int NationID, int StateID, int CityID)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "SELECT top 1 CourseRegID From TableCourseRegDetails ORDER BY CourseRegID DESC";
            SqlCommand command = new SqlCommand(query, con);
            CourseRegID = Convert.ToInt32(command.ExecuteScalar());
            query = "Insert into TableRegAddress values(@CourseRegID,@NationID,@StateID,@CityID)";
            command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            command.Parameters.AddWithValue("@NationID", NationID);
            command.Parameters.AddWithValue("@StateID", StateID);
            command.Parameters.AddWithValue("@CityID", CityID);
            command.ExecuteNonQuery();
            con.Close();
            return "Records Saved Succesfully In TableRegAddress";
        }



        public static string saveTableFeeDetails(double TotalAmount,Double MinPer,Double PaidAmount,Double BalAmount,DateTime PaidDate)
        {
            SqlConnection con = GetConnection();
            con.Open();
            string query = "Insert into TableFeeDetails values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand command= new SqlCommand(query, con);
            command.Parameters.AddWithValue("@CourseRegID", CourseRegID);
            command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
            command.Parameters.AddWithValue("@MinPer", MinPer);
            command.Parameters.AddWithValue("@PaidAmount", PaidAmount);
            command.Parameters.AddWithValue("@BalAmount", BalAmount);
            command.Parameters.AddWithValue("@PaidDate", PaidDate);
            command.ExecuteNonQuery();
            con.Close();
            return "Records Saved Successfully In TableFeeDetails";
        }
    }

}     























