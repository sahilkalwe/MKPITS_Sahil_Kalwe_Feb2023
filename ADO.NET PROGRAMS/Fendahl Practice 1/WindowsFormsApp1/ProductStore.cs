using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class ProductStore
    {
        private static string connectionString = "Server= LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=fendahldb;";
        public static SqlConnection Getconnection()
        {
            SqlConnection Con = new SqlConnection(connectionString);
            try
            {
                Con.Open();
                return Con;
            }

            catch (Exception ee)
            {
                return null;
            }
            finally
            {
                //Con.close();
            }
        }

        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = Getconnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds,"Product_Type_Name");
            return ds;
        }


        public static DataSet GetTableProductName(String Product_Type_Name)
        {
            SqlConnection con = Getconnection();
            string query = "select p.ProductID,p.ProductName from TableProduct p Inner Join TableProductCategory t on p.ProductTypeID= t.Product_Category_ID where t.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name",Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        
        public static DataSet GetGSTDetails(string Product_Type_Name)
        {
            SqlConnection con = Getconnection();
            string query = "select a.cgst,a.sgst,a.igst from TableProductGstDetails a inner join TableProductCategory b on a.Product_GST_ID = b.Product_GST_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProductGSTDetails");
            return ds;
        }
        
        public static DataSet GetProductPrice(String ProductName)
        {
            SqlConnection con = Getconnection();
            string query = "select ProductPrice from TableProduct where ProductName = @ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }

        public static string saveTableInvoiceDetails(string Customer_Name, long Customer_Contact, int Product_Category_ID, int Product_ID, int Resedential_Type_ID, DateTime Invoice_Date, decimal Quantity, decimal Price, decimal CGST, decimal SGST, decimal IGST, decimal CGST_Value, decimal SGST_Value, decimal IGST_Value, decimal Total_Amount)
        {
            string result = null;
            string query = "Insert into TableInvoiceDetails values (@Customer_Name,@Customer_Contact,@Product_Category_ID,@Product_ID,@Resedential_Type_ID,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_Value,@IGST_Value,@Total_Amount)";
            SqlConnection con = Getconnection();
            SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@Customer_Name", Customer_Name);
            command.Parameters.AddWithValue("@Customer_Contact",Customer_Contact);
            command.Parameters.AddWithValue("@Product_Category_ID",Product_Category_ID);
            command.Parameters.AddWithValue("@Product_ID",Product_ID);
            command.Parameters.AddWithValue("@Resedential_Type_ID",Resedential_Type_ID);
            command.Parameters.AddWithValue("@Invoice_Date",Invoice_Date);
            command.Parameters.AddWithValue("@Quantity",Quantity);
            command.Parameters.AddWithValue("@Price",Price);
            command.Parameters.AddWithValue("@CGST",CGST);
            command.Parameters.AddWithValue("@SGST",SGST);
            command.Parameters.AddWithValue("@IGST",IGST);
            command.Parameters.AddWithValue("@CGST_Value",CGST_Value);
            command.Parameters.AddWithValue("@SGST_Value",SGST_Value);
            command.Parameters.AddWithValue("@IGST_Value",IGST_Value);
            command.Parameters.AddWithValue("@Total_Amount",Total_Amount);
            try
            {
                command.ExecuteNonQuery();
                result = "Record Saved Succefully";
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