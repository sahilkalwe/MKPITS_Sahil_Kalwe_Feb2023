using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fendahl2
{
    public static class CourseRegistration1
    {
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01; integrated security=true;database=fendahl 2;";

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

        public static DataSet GetCity(string StateName )
        {
            string query = "select s.CityID,s.CityName from TableCity s inner join TableState n on s.StateID=n.StateID where n.StateName=@StateName";
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("StateName", StateName);
            da.Fill(ds, "TableCity");
            return ds;
        }
    }
}



            
       























