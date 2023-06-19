using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace somaliaprj
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
        SqlConnection con = null;
        private void button1_Click(object sender, EventArgs e)
        {
            //activity table
            //  connection();

            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select [activity type] from somalia_tempdata", sqlconn);
            da.Fill(ds, "sd");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_data(dr[0].ToString());
            }
            label1.Text = "record saved";

            //searching for id


        }

        //method to insert data into activity table
        void process_data(string activity_name)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select [name] from activity_type where name='" + activity_name + "'", sqlconn);
            da1.Fill(ds1, "at");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["at"].Rows)
            {
                flag = 1;
                //  MessageBox.Show("name " + dr1[0].ToString());
                //process_data(dr[0].ToString());
            }
            if (flag == 0)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "insert into activity_type(name) values('" + activity_name + "')";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                searchid(activity_name);
            }

        }

        //method to search id in activity_type
        void searchid(string an)
        {
            string qr1 = "select id from activity_type where name='" + an + "'";
            SqlConnection con1 = new SqlConnection(sqlconn);
            SqlCommand com2 = new SqlCommand(qr1, con1);
            con1.Open();
            SqlDataReader dr = com2.ExecuteReader();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"].ToString());
                //  MessageBox.Show(id.ToString());
                update_somaliadata(id, an);
            }
            con1.Close();
        }

        void update_somaliadata(int id, string an)
        {
            string qr2 = "update somalia_tempdata set [activity type]='" + id + "' where [activity type]='" + an + "'";
            SqlConnection con2 = new SqlConnection(sqlconn);
            SqlCommand com3 = new SqlCommand(qr2, con2);
            con2.Open();
            com3.ExecuteNonQuery();
            con2.Close();
          //  MessageBox.Show("record updated");
        }

        
        //incident type
        private void button2_Click(object sender, EventArgs e)
        {
            //incident type 
            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select [incident type] from somalia_tempdata", sqlconn);
            da.Fill(ds, "sd");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_incident_type(dr[0].ToString());
            }
            label1.Text = "record saved into incident_type";

            //searching for id


        }

        //method to save data into incident type table
        //method to insert data into activity table
        void process_incident_type(string incident_name)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select [incident_name] from incident_type where incident_name='" + incident_name + "'", sqlconn);
            da1.Fill(ds1, "at");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["at"].Rows)
            {
                flag = 1;
                //  MessageBox.Show("name " + dr1[0].ToString());
                //process_data(dr[0].ToString());
            }
            if (flag == 0)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "insert into incident_type(incident_name) values('" + incident_name + "')";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                search_incident_id(incident_name);
            }

            //method to search id in incident_type
            void search_incident_id(string an)
            {
                string qr1 = "select max(incident_id) from incident_type where incident_name='" + an + "'";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com2 = new SqlCommand(qr1, con1);
                con1.Open();
                int id = Convert.ToInt32(com2.ExecuteScalar());
                //while (dr.Read())
                //{
                   // int id = Convert.ToInt32(dr["incident_id"].ToString());
                    //  MessageBox.Show(id.ToString());
                    update_incident_type(id, an);
               // }
            //    MessageBox.Show("incident type  updated");
                con1.Close();
            }

            //method to update incident_type
            void update_incident_type(int id, string an)
            {
                string qr2 = "update somalia_tempdata set [incident type]='" + id + "' where [incident type]='" + an + "'";
                SqlConnection con2 = new SqlConnection(sqlconn);
                SqlCommand com3 = new SqlCommand(qr2, con2);
                con2.Open();
                com3.ExecuteNonQuery();
                con2.Close();

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //incident subtype 
            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select [incident_id] from incident_type", sqlconn);
            da.Fill(ds, "sd");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["sd"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_incident_subtype(dr[0].ToString());
            }
            label1.Text = "record saved into incident_subtype";

            //searching id from subtype table by passing subtype name
            SqlDataAdapter da1 = new SqlDataAdapter("select [incident_subtype_name] from incident_subtype", sqlconn);
            da1.Fill(ds, "sd1");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["sd1"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_incident_subtype1(dr[0].ToString());
            }

            label1.Text = "record updated in subtype";
        }
        void process_incident_subtype(string incident_id)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select distinct [incident sub-type] from Somalia_tempdata where [Incident Type] = '" + incident_id + "'", sqlconn);
            da1.Fill(ds1, "at");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["at"].Rows)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "insert into incident_subtype(incident_type_id,incident_subtype_name) values('" + incident_id + "','" + dr1[0].ToString() + "')";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                // search_incident_subtypeid(incident_name);
            }
            if (flag == 0)
            {

            }

        }

        void process_incident_subtype1(string incident_subtype_name)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select incident_subtype_id from incident_subtype where [incident_subtype_name] = '" + incident_subtype_name + "'", sqlconn);
            da1.Fill(ds1, "at");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["at"].Rows)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "update somalia_tempdata set [incident sub-type] = '"+dr1[0].ToString()+ "' where [incident sub-type]='"+ incident_subtype_name+"' ";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                // search_incident_subtypeid(incident_name);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //String str = "2.2, 40.33";

            //char[] spearator = { ','};

            //// using the method
            //String[] strlist = str.Split(spearator);

            //foreach (String s in strlist)
            //{
            //    MessageBox.Show(s);
            //}
            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select date,summary,[estimated time],killed,injured," +
                "[number of incidents],[high impact],[source/info rating],[location accuracy],longitude," +
                "province,location,[activity type],[incident type],[target],[criminal charges] from somalia_tempdata", sqlconn);
            da.Fill(ds, "lg");
            foreach (DataRow dr in ds.Tables["lg"].Rows)
            {
                string date = dr["date"].ToString();
                string summary = dr["summary"].ToString();
                summary = summary.Replace("'", "''");
               
                // MessageBox.Show(summary);
                string estimated_time = dr["estimated time"].ToString();
                int killed =Convert.ToInt32( dr["killed"].ToString());
                int injured =Convert.ToInt32( dr["injured"].ToString());
               int number_of_incidents =Convert.ToInt32 (dr["number of incidents"].ToString());
                string high_impact = dr["high impact"].ToString();
                string source_info_rating = dr["source/info rating"].ToString();
                string location_accuracy = dr["location accuracy"].ToString();
                string longitude = dr["longitude"].ToString();
                char[] spearator = { ',' };
                String[] strlist = longitude.Split(spearator);
                //  MessageBox.Show("arr 0 " + strlist[0].ToString());
                //MessageBox.Show("arr 1 " + strlist[0].ToString());
                string lat = "";
                string longi = "";
                if (strlist[0]=="")
                {

                }
                else
                {
                     lat = strlist[0];
                     longi = strlist[1];
                }

               
                string province = dr["province"].ToString();
                string location = dr["location"].ToString();
                string activity_type = dr["activity type"].ToString();
                string incident_type = dr["incident type"].ToString();
                string target = dr["target"].ToString();
                string criminal_charges= dr["criminal charges"].ToString();
                

                string query = "insert into incident values(@date, @summary ,@estimated_time ,@killed,@injured ,@number_of_incidents ,@high_impact ,@source_info_rating ,@location_accuracy ,@lat,@longi,@province ,@location ,@activity_type ,@incident_type ,@target ,@criminal_charges )";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.Add(new SqlParameter("@date", SqlDbType.VarChar)).Value = date;
                command.Parameters.Add(new SqlParameter("@summary", SqlDbType.VarChar,-1)).Value = summary;
                command.Parameters.Add(new SqlParameter("@estimated_time", SqlDbType.VarChar)).Value = estimated_time;
                command.Parameters.Add(new SqlParameter("@killed", SqlDbType.Int)).Value = killed;
                command.Parameters.Add(new SqlParameter("@injured", SqlDbType.Int)).Value = injured;
                command.Parameters.Add(new SqlParameter("@number_of_incidents", SqlDbType.Int)).Value = number_of_incidents;
                command.Parameters.Add(new SqlParameter("@high_impact", SqlDbType.VarChar)).Value = high_impact;
                command.Parameters.Add(new SqlParameter("@source_info_rating", SqlDbType.VarChar)).Value = source_info_rating;
                command.Parameters.Add(new SqlParameter("@location_accuracy", SqlDbType.VarChar)).Value = location_accuracy;
                command.Parameters.Add(new SqlParameter("@lat", SqlDbType.VarChar)).Value = lat;
                command.Parameters.Add(new SqlParameter("@longi", SqlDbType.VarChar)).Value = longi;
                command.Parameters.Add(new SqlParameter("@province", SqlDbType.VarChar)).Value = province;
                command.Parameters.Add(new SqlParameter("@location", SqlDbType.VarChar)).Value = location;
                command.Parameters.Add(new SqlParameter("@activity_type", SqlDbType.Int)).Value = activity_type;
                command.Parameters.Add(new SqlParameter("@incident_type", SqlDbType.Int)).Value = incident_type;
                command.Parameters.Add(new SqlParameter("@target", SqlDbType.VarChar)).Value = target;
                command.Parameters.Add(new SqlParameter("@criminal_charges", SqlDbType.VarChar)).Value = criminal_charges;

                con.Open();
                command.ExecuteNonQuery();
                con.Close();

                //foreach (String s in strlist)
                //{
                //   // MessageBox.Show(s);
                //   lat=
                //}



                //MessageBox.Show(date);
                //MessageBox.Show(summary);
                //MessageBox.Show(estimated_time);




                //string lon = dr[0].ToString();
                //char[] spearator = { ',' };
                //String[] strlist = lon.Split(spearator);
                //foreach (String s in strlist)
                //{
                //    MessageBox.Show(s);
                //}
            }
            label1.Text = "record inserted into incident table";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //code to save record in target table
            //activity table
            //  connection();

            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select [target] from somalia_tempdata", sqlconn);
            da.Fill(ds, "tg");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["tg"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_datatarget(dr[0].ToString());
            }
            label1.Text = "record saved";

        }

        //method to insert data into target table
        void process_datatarget(string target_name)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select [target_name] from target where target_name='" + target_name + "'", sqlconn);
            da1.Fill(ds1, "tg");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["tg"].Rows)
            {
                flag = 1;
                //  MessageBox.Show("name " + dr1[0].ToString());
                //process_data(dr[0].ToString());
            }
            if (flag == 0)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "insert into target(target_name) values('" + target_name + "')";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                searchtargetid(target_name);
            }

        }

        //method to search id in target
        void searchtargetid(string an)
        {
            string qr1 = "select target_id from target where target_name='" + an + "'";
            SqlConnection con1 = new SqlConnection(sqlconn);
            SqlCommand com2 = new SqlCommand(qr1, con1);
            con1.Open();
            SqlDataReader dr = com2.ExecuteReader();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["target_id"].ToString());
                //  MessageBox.Show(id.ToString());
                update_somaliadatatarget(id, an);
            }
            con1.Close();
        }

        void update_somaliadatatarget(int id, string an)
        {
            string qr2 = "update somalia_tempdata set [target]='" + id + "' where [target]='" + an + "'";
            SqlConnection con2 = new SqlConnection(sqlconn);
            SqlCommand com3 = new SqlCommand(qr2, con2);
            con2.Open();
            com3.ExecuteNonQuery();
            con2.Close();
           // MessageBox.Show("record updated");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //target subtype
            //incident subtype 
            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select [target_id] from target", sqlconn);
            da.Fill(ds, "sd1");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["sd1"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_target_subtype(dr[0].ToString());
            }
            label1.Text = "record saved into incident_subtype";

            //searching id from subtype table by passing subtype name
            SqlDataAdapter da1 = new SqlDataAdapter("select [target sub type] from target_subtype", sqlconn);
            da1.Fill(ds, "sd11");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["sd11"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_target_subtype1(dr[0].ToString());
            }

            label1.Text = "record updated in subtype";
        }

        void process_target_subtype(string target_id)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select distinct [sub-type1] from Somalia_tempdata where [target] = '" + target_id + "'", sqlconn);
            da1.Fill(ds1, "at1");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["at1"].Rows)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "insert into target_subtype([target type],[target sub type]) values('" + target_id + "','" + dr1[0].ToString() + "')";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                // search_incident_subtypeid(incident_name);
            }
            if (flag == 0)
            {

            }

        }

        void process_target_subtype1(string target_subtype_name)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select id from target_subtype where [target sub type] = '" + target_subtype_name + "'", sqlconn);
            da1.Fill(ds1, "at2");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["at2"].Rows)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "update somalia_tempdata set [sub-type1] = '" + dr1[0].ToString() + "' where [sub-type1]='" + target_subtype_name + "' ";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                // search_incident_subtypeid(incident_name);
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //activity table
            //  connection();

            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select [criminal charges] from somalia_tempdata", sqlconn);
            da.Fill(ds, "csd");
            //dataGridView1.DataSource = ds.Tables["sd"];

            foreach (DataRow dr in ds.Tables["csd"].Rows)
            {
                //MessageBox.Show(dr[0].ToString());
                process_criminaldata(dr[0].ToString());
            }
            label1.Text = "record saved";

        }

        //method to insert data into activity table
        void process_criminaldata(string charges_name)
        {
            //  MessageBox.Show(activity_name);
            // string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
            // con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds1 = new DataSet();
            SqlDataAdapter da1 = new SqlDataAdapter("select [criminal charges] from criminal_charges where [criminal charges]='" + charges_name + "'", sqlconn);
            da1.Fill(ds1, "cat");
            //dataGridView1.DataSource = ds.Tables["sd"];
            int flag = 0;

            foreach (DataRow dr1 in ds1.Tables["cat"].Rows)
            {
                flag = 1;
                //  MessageBox.Show("name " + dr1[0].ToString());
                //process_data(dr[0].ToString());
            }
            if (flag == 0)
            {
                //MessageBox.Show("no record found in activity_type table");
                string qr = "insert into criminal_charges([criminal charges]) values('" + charges_name + "')";
                SqlConnection con1 = new SqlConnection(sqlconn);
                SqlCommand com = new SqlCommand(qr, con1);
                con1.Open();
                com.ExecuteNonQuery();


                con.Close();
                searchchargesid(charges_name);
            }

        }

        //method to search id in activity_type
        void searchchargesid(string an)
        {
            string qr1 = "select id from criminal_charges where [criminal charges]='" + an + "'";
            SqlConnection con1 = new SqlConnection(sqlconn);
            SqlCommand com2 = new SqlCommand(qr1, con1);
            con1.Open();
            SqlDataReader dr = com2.ExecuteReader();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr["id"].ToString());
                //  MessageBox.Show(id.ToString());
                update_somaliadatacharges(id, an);
            }
            con1.Close();
        }

        void update_somaliadatacharges(int id, string an)
        {
            string qr2 = "update somalia_tempdata set [criminal charges]='" + id + "' where [criminal charges]='" + an + "'";
            SqlConnection con2 = new SqlConnection(sqlconn);
            SqlCommand com3 = new SqlCommand(qr2, con2);
            con2.Open();
            com3.ExecuteNonQuery();
            con2.Close();
          //  MessageBox.Show("record updated");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
