using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace mvc_database_connection_2.Models
{
    public class ItemDBHandler
    {

        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["ItemList"].ToString();
            con=new SqlConnection(constring);

        }
        //list generic class to create collection of itemmodel objects
        
        public List<ItemModel> GetItemList() 
        {
            connection();
            List<ItemModel> ilist = new List<ItemModel>();
            string query = "Select * from ItemList";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable;
            con.Open();
            adapter.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ilist.Add(new ItemModel)
                    {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])
                        });
            }
            return ilist;
           
        }

        public bool InsertItem(ItemModel iList)
        {
            connection();

        }




        
        }

    }
}