using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace mvc_database_connection.Models
{
    public class ItemDBHandler
    {
        SqlConnection con = null;
        public void connection()
        {
           //string constr =System.Configuration.ConfigurationManager.ConnectionStrings["CompShopConString"].ToString();
            string constr = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=ItemList";
            con=new SqlConnection(constr);

        }

        //insert itemmethod to insert rexord into itemlist table
        public bool InsertItem(ItemModel ilist)
        {
            connection();
            string query = "Insert into itemlist values (' " + ilist.Name + " ',' " + ilist.Category + " ',' " + ilist.Price + " ')";
            SqlCommand command = new SqlCommand(query,con);
            con.Open();
            int i=command.ExecuteNonQuery();
            con.Close();
            if(i>=1)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

    }
}
