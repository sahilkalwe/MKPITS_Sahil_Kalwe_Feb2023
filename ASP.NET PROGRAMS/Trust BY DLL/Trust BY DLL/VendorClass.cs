using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Trust_BY_DLL
{
    public static class VendorClass
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

            catch(Exception ex)
            {
                res=ex.ToString();
            }
            finally

            {
                con.Close(); 
            }
            return res;

            }
        //method to return Vendor_ID
        public static string getVendor_ID()
        {
            string res = null;
            try
            {
                query = "select max (Vendor_Id) from Vendor_Master";
                cmd = new SqlCommand(query, con);
                con.Open();
                int VID = Convert.ToInt32(cmd.ExecuteScalar());
                res = VID.ToString();
            }
            catch(Exception ex) 
            {   
                res=ex.ToString();
            
            }
            finally 
            {
                con.Close(); 
            }

            return res;

        }


        //method to update record in vendor table.


        }

    }