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

        SqlConnection con = null;
        private void connection()
        {

            // string constring = ConfigurationManager.ConnectionStrings["ItemList"].ToString();
            string constring = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=ItemList";
            con = new SqlConnection(constring);

        }
        //list generic class to create collection of itemmodel objects

        public List<ItemModel> GetItemList()
        {
            connection();
            List<ItemModel> ilist = new List<ItemModel>();
            string query = "Select * from ItemList";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ilist.Add(new ItemModel
                {
                    ID = Convert.ToInt32(dr["ID"]),
                    Name = Convert.ToString(dr["Name"]),
                    Category = Convert.ToString(dr["Category"]),
                    Price = Convert.ToDecimal(dr["Price"])

                });
             
            }

            return ilist;
            //insert items

        }

        public bool InsertItem(ItemModel iList)

        {
            connection();
            string query = "Insert into ItemList values (' " + iList.Name + " ',' " + iList.Category + " '," + iList.Price + ")";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;

        }

        public bool UpdateItem(ItemModel iList)
        {
            connection();
            string query="UPDATE ItemList SET Name='"+iList.Name+"',Category='"+iList.Category+"',Price="+iList.Price+" WHERE ID= "+iList.ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool DeleteItem(int ID)
        {
            connection();
            string query = "Delete from ItemList  WHERE ID= "+ID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }



    }
}
