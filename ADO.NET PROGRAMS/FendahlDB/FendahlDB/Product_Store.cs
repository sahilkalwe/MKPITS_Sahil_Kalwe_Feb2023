using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.CodeDom;
using System.Xml.Linq;

namespace FendahlDB
{
    public static class Product_Store
    {
        private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01; integrated security=true;database=fendahldb;";
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

        //method to return product category
        public static DataSet GetTableProductCategory()
        {
            SqlConnection con = GetConnection();
            string query = "select * from TableProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "Product_Type_Name");
            return ds;
        }

        //method to return product name for given product type name
        public static DataSet GetTableProductName(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.ProductID,p.ProductName from TableProduct p inner join TableProductCategory t on p.ProductTypeID=t.Product_Category_ID where t.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProduct");
            return ds;  
        }


        //method to return gstdetails for given product type name

        public static DataSet GetGstDetails(string Product_Type_Name)
        {
            SqlConnection con = GetConnection();
            string query = "select a.cgst,a.sgst,a.igst from TableProductGSTDetails a inner join TableProductCategory b on a.Product_GST_ID=b.Product_GST_ID where b.Product_Type_Name=@Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Type_Name", Product_Type_Name);
            da.Fill(ds, "TableProductGSTDetails");
            return ds;
        }

        //method to return product price for given product name

        public static DataSet GetProductPrice(string ProductName)
        {
            SqlConnection con = GetConnection();
            string query = "Select ProductPrice From TableProduct Where ProductName=@ProductName";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@ProductName", ProductName);
            da.Fill(ds, "TableProduct");
            return ds;
        }
        //method to save records inside invoice table

        public static string saveTableInvoiceDetails(String Customer_Name,long Customer_Contact,int Product_Category_ID,int Product_ID,int Residential_Type_ID,DateTime Invoice_Date,decimal Quantity,decimal Price,decimal CGST,decimal SGST,decimal IGST,decimal CGST_Value,decimal SGST_Value,decimal IGST_Value,decimal Total_Amount)
        {
            String result = null;
            //System.Windows.Form8
            //
            //s.MessageBox.Show(Invoice_Date.ToString());
            string query = "Insert Into TableInvoiceDetails Values (@Customer_Name,@Customer_Contact,@Product_Category_ID,@Product_ID,@Residential_Type_ID,@InvoiceDate,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_Value,@IGST_Value,@Total_Amount)";
            SqlConnection con=GetConnection();
            SqlCommand command=new SqlCommand(query, con);

                command.Parameters.AddWithValue("@Customer_Name",Customer_Name );
                command.Parameters.AddWithValue("@Customer_Contact",Customer_Contact);
                command.Parameters.AddWithValue("@Product_Category_ID",Product_Category_ID);
                command.Parameters.AddWithValue("@Product_ID",Product_ID);
                command.Parameters.AddWithValue("@Residential_Type_ID",Residential_Type_ID);
                command.Parameters.AddWithValue("@InvoiceDate",Invoice_Date);
                command.Parameters.AddWithValue("@Quantity",Quantity);
                command.Parameters.AddWithValue("@Price",Price);
                command.Parameters.AddWithValue("@CGST",CGST);
                command.Parameters.AddWithValue("@SGST", SGST);
                command.Parameters.AddWithValue("@IGST", IGST);
                command.Parameters.AddWithValue("@CGST_Value", CGST_Value);
                command.Parameters.AddWithValue("@SGST_Value", SGST_Value);
                command.Parameters.AddWithValue("@IGST_Value", IGST_Value);
                command.Parameters.AddWithValue("@Total_Amount", Total_Amount);

            try
            {
                command.ExecuteNonQuery();
                result = "Record Saved Successfully";
              

            }

            catch (Exception ee)
            {
              result =ee.ToString();
            }
            finally
            {
                con.Close();
            }
            return result;

        }

    }
}


