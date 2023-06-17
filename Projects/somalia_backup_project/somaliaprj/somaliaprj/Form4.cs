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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string sqlconn = "server=.\\sqlexpress01;integrated security=true;database=somaliadb";
        SqlConnection con = null;
        private void Form4_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            // SqlDataAdapter da = new SqlDataAdapter("select * from incident", sqlconn);
            string qr = "SELECT inc.id, inc.date,inc.summary,inc.[estimated time],inc.killed ,inc.injured,inc.[no of incident],inc.[high impact],inc.[source info rating],inc.[location accuracy],inc.latitude,inc.longitude,inc.province,inc.location,act.name ,inct.incident_name,tar.target_name FROM incident as inc INNER JOIN activity_type  as act ON inc.[acitivity type] = act.id inner join incident_type as inct on inc.incident=inct.incident_id inner join target as tar on inc.target=convert(varchar,tar.target_id)";
            
            SqlDataAdapter da = new SqlDataAdapter(qr, sqlconn);
            da.Fill(ds, "inc");
           // dataGridView1.DataSource = ds.Tables["inc"];

            //loading the province
            SqlDataAdapter da1 = new SqlDataAdapter("select distinct province from incident", sqlconn);
            da1.Fill(ds, "pro");
            DataRow drr = ds.Tables["pro"].NewRow();
            drr["province"] = "Select state";
            ds.Tables["pro"].Rows.InsertAt(drr, 0);

            comboBox2.DataSource = ds.Tables["pro"];
            comboBox2.DisplayMember = "province";

            //loading the activity type
            SqlDataAdapter da2 = new SqlDataAdapter("select * from activity_type", sqlconn);
            da2.Fill(ds, "act");
            DataRow drr1 = ds.Tables["act"].NewRow();
            drr1["name"] = "Select activity type";
              drr1["id"] = 0;// Some ID
            ds.Tables["act"].Rows.InsertAt(drr1, 0);

            comboBox3.DataSource = ds.Tables["act"];
            comboBox3.DisplayMember = "name";
            comboBox3.ValueMember = "id";

            //loading the incident type
            SqlDataAdapter da3 = new SqlDataAdapter("select * from incident_type", sqlconn);
            da3.Fill(ds, "inc1");
            DataRow drr2 = ds.Tables["inc1"].NewRow();
            drr2["incident_name"] = "Select incident";
            drr2["incident_id"] = 0;// Some ID
            ds.Tables["inc1"].Rows.InsertAt(drr2, 0);
            comboBox4.DataSource = ds.Tables["inc1"];
            comboBox4.DisplayMember = "incident_name";
            comboBox4.ValueMember = "incident_id";

            //loading the incident type
            SqlDataAdapter da4 = new SqlDataAdapter("select * from target", sqlconn);
            da4.Fill(ds, "tar");
            DataRow drr3 = ds.Tables["tar"].NewRow();
            drr3["target_name"] = "Select target";
            drr3["target_id"] = 0;// Some ID
            ds.Tables["tar"].Rows.InsertAt(drr3, 0);

            comboBox5.DataSource = ds.Tables["tar"];
            comboBox5.DisplayMember = "target_name";
            comboBox5.ValueMember = "target_id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
             con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from incident where province='"+comboBox2.Text+"' and [acitivity type]='"+comboBox3.SelectedValue.ToString()+ "' and [incident]='" + comboBox4.SelectedValue.ToString() + "' and [target]='" + comboBox5.SelectedValue.ToString() + "'", sqlconn);
            ds.Tables.Clear();
            da.Fill(ds, "inc1");
            dataGridView1.DataSource = ds.Tables["inc1"];

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sqlFormattedDate = null;
            string sqlFormattedDate2 = null;
            con = new SqlConnection(sqlconn);
            if (dateTimePicker1.Checked)
            {
                 sqlFormattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            }

            if (dateTimePicker2.Checked)
            {
                 sqlFormattedDate2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            }



            DataSet ds = new DataSet();
            SqlDataAdapter da=null;
            int pro = 0;
            if (dateTimePicker1.Checked && dateTimePicker2.Checked)
            {
                if (comboBox2.Text == "Select state" )
                {
                    da = new SqlDataAdapter("select * from Incident where Date between '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "' ", con);
                }
                else
                {
                    pro = 1;
                    da = new SqlDataAdapter("select * from Incident where Date between '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "' and province='" + comboBox2.Text + "' ", con);
                }

                if ( comboBox3.Text=="Select activity type")
                {
                    if (pro == 1)
                        da = new SqlDataAdapter("select * from Incident where Date between '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "' and province='" + comboBox2.Text + "'  ", con);
                    else
                    da = new SqlDataAdapter("select * from Incident where Date between '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "'   ", con);
                }
                else
                {
                    if(pro==1)
                    da = new SqlDataAdapter("select * from Incident where Date between '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "' and province='" + comboBox2.Text + "' and [acitivity type]= '"+comboBox3.SelectedValue.ToString()+"' ", con);
                    else if (pro == 0)
                        da = new SqlDataAdapter("select * from Incident where Date between '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "' and  [acitivity type]= '" + comboBox3.SelectedValue.ToString() + "' ", con);
                }

            }
            else 
            {
                if (comboBox2.Text == "Select state")
                {
                 //   da = new SqlDataAdapter("select * from Incident where  and '" + sqlFormattedDate2 + "' ", con);
                }
                else
                {
                    pro = 1;
                    da = new SqlDataAdapter("select * from Incident where  province='" + comboBox2.Text + "' ", con);
                }

                if (comboBox3.Text == "Select activity type")
                {
                    if (pro == 1)
                        da = new SqlDataAdapter("select * from Incident where  province='" + comboBox2.Text + "'  ", con);
                  //  else
                       // da = new SqlDataAdapter("select * from Incident where dDate2 + "'   ", con);
                }
                else
                {
                    if (pro == 1)
                        da = new SqlDataAdapter("select * from Incident where  province='" + comboBox2.Text + "' and [acitivity type]= '" + comboBox3.SelectedValue.ToString() + "' ", con);
                    else if (pro == 0)
                        da = new SqlDataAdapter("select * from Incident where   [acitivity type]= '" + comboBox3.SelectedValue.ToString() + "' ", con);
                }

            }
            ds.Tables.Clear();

            da.Fill(ds, "inc1");

            dataGridView1.DataSource = ds.Tables["inc1"];


            //for graph

            DataSet ds1 = new DataSet();
            SqlDataAdapter da11 = new SqlDataAdapter("  select DATE,SUM([acitivity type]) as [acitivity type]  from incident where[acitivity type] = 2 group by date having date between  '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "'", sqlconn);
            ds1.Tables.Clear();
            da11.Fill(ds1, "inc111");
            // dataGridView1.DataSource = ds.Tables["inc1"];

            foreach (DataRow dr in ds1.Tables["inc111"].Rows)
            {
                chart1.Series["Terrorism"].Points.AddXY(dr["date"].ToString(), dr["acitivity type"].ToString());
            }

            SqlDataAdapter da111 = new SqlDataAdapter("  select DATE,SUM([acitivity type]) as [acitivity type]  from incident where[acitivity type] = 1 group by date having date between  '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "'", sqlconn);
            // ds.Tables.Clear();
            da111.Fill(ds1, "act111");
            // dataGridView1.DataSource = ds.Tables["inc1"];

            foreach (DataRow dr in ds1.Tables["act111"].Rows)
            {
                chart1.Series["Military"].Points.AddXY(dr["date"].ToString(), dr["acitivity type"].ToString());
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sqlFormattedDate = null;
            string sqlFormattedDate2 = null;
            con = new SqlConnection(sqlconn);
            if (dateTimePicker1.Checked)
            {
                sqlFormattedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            }

            if (dateTimePicker2.Checked)
            {
                sqlFormattedDate2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            }
        //    con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("  select DATE,SUM([acitivity type]) as [acitivity type]  from incident where[acitivity type] = 2 group by date having date between  '"+ sqlFormattedDate +"' and '"+ sqlFormattedDate2 +"'", sqlconn);
            ds.Tables.Clear();
            da.Fill(ds, "inc1");
            // dataGridView1.DataSource = ds.Tables["inc1"];
            
            foreach (DataRow dr in ds.Tables["inc1"].Rows)
            {
                chart1.Series["Terrorism"].Points.AddXY(dr["date"].ToString(), dr["acitivity type"].ToString());
            }

            SqlDataAdapter da1 = new SqlDataAdapter("  select DATE,SUM([acitivity type]) as [acitivity type]  from incident where[acitivity type] = 1 group by date having date between  '" + sqlFormattedDate + "' and '" + sqlFormattedDate2 + "'", sqlconn);
           // ds.Tables.Clear();
            da1.Fill(ds, "act1");
            // dataGridView1.DataSource = ds.Tables["inc1"];

            foreach (DataRow dr in ds.Tables["act1"].Rows)
            {
                chart1.Series["Military"].Points.AddXY(dr["date"].ToString(), dr["acitivity type"].ToString());
            }

            // chart1.Titles.Add("activity type :");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void clearall()
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            dateTimePicker1.Text="" ;
            dataGridView1.ClearSelection();
        }

        private void comboBox6_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
