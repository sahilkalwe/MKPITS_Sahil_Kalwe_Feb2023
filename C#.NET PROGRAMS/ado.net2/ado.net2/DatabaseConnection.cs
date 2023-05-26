using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace staticconnectionex
{
    public static class DatabaseConnection
    {
        //creating a static variable
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=ADO.net";
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
    }
}
