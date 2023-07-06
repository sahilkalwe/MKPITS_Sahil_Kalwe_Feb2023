using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace StudDBConnectivity.Models
{
    public class ItemDBHandler
    {
        SqlConnection con=null;
        private void connection()
        {
            string constring = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01;integrated security=true;database=StudentMVCDB";
            con = new SqlConnection(constring);

        }
        public List<StudModel> GetItemList()
        {
            connection();
            List<StudModel> ilist = new List<StudModel>();
            string query = "Select * from Student";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adapter.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ilist.Add(new StudModel
                {
                   StudID  = Convert.ToInt32(dr["StudID"]),
                    StudName = Convert.ToString(dr["StudName"]),
                    StudRollNo = Convert.ToInt32(dr["StudRollNo"]),
                    StudAge= Convert.ToInt32(dr["StudAge"]),
                    StudDesignation = Convert.ToString(dr["StudDesignation"]) 


                });

            }

            return ilist;
            //insert items

        }

        public bool InsertItem(StudModel iList)

        {
            connection();
            string query = "Insert into Student values (' " + iList.StudName + " ',' " + iList.StudRollNo +"','"+iList.StudAge + " ',' "+ iList.StudDesignation+ "')";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
                return true;
            else
                return false;

        }

        public bool UpdateItem(StudModel iList)
        {
            connection();
            string query = "UPDATE Student SET Name='" + iList.StudName + "',RollNumber='" + iList.StudRollNo + "',Age=" + iList.StudAge +" ',Designation=" +iList.StudDesignation+" WHERE StudID= " + iList.StudID;
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        public bool DeleteItem(int StudID)
        {
            connection();
            string query = "Delete from Student  WHERE StudID= " + StudID;
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