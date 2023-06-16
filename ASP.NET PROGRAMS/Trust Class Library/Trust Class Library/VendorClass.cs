using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trust_Class_Library
{
    internal class VendorClass
    {

        static SqlConnection con = DbConnection.getConnection();
        static string query = null;
        static SqlCommand cmd = null;
        //method to insert record in vendors table
        public static string Vendor_Master(string Vendor_name)
        {
            string res = null;
            try
            {
                query = "insert into Vendor_Master values(@Vendor_Name)";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("Vendor_Name", Vendor_Name);
                con.Open();
                cmd.ExecuteNonQuery();
                res = "record saved in Vendor Master Succesfully";
            }

            catch (Exception ex)
            {
                res = ex.ToString();
            }
            finally

            {
                con.Close();
            }
            return res;

        }
    }
}
