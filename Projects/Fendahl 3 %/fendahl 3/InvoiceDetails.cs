using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace fendahl_3
{
    public class InvoiceDetails
    {
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01; integrated security=true;database=Fendahl 3;";

        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                //conn.Open();
                return conn;
            }
            catch
            {
                return null;
            }
            finally
            {
                //conn.Close();
            }
        }

        public static DataSet GetProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select productcategoryid, productcategory  from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "TableProducCategory");
            return ds;
        }
        public static DataSet GetTableProductName(String ProductCategory)
        {
            string query = "select * from TableProduct p inner join TableProductCategory t on p.ProductCategoryID=t.productcategoryid where t.ProductCategory=@ProductCategory";
            SqlConnection con = GetConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@productcategory", ProductCategory);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet GetProductPrice(String ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "Select ProductPrice From TableProduct Where ProductName=@ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet GetAvailableQuantity(String ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "Select AvailableQuantity From TableProduct Where ProductName=@ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet GetTotalQuantity(String ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "Select TotalQuantity From TableProduct Where ProductName=@ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        public static DataSet GetGST(String ProductCategory)
        {
            SqlConnection con = GetConnection();
            string query = "select c.cgst,c.sgst from TableProductGSTDetails c inner join TableProductCategory s on c.GstDetailName=s.ProductCategory where s.ProductCategory=@ProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductCategory", ProductCategory);
            da.Fill(ds, "TableProduct");
            return ds;
        }





    }
}
