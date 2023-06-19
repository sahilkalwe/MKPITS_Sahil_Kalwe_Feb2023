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
using System.Windows.Forms.DataVisualization.Charting;

namespace somaliaprj
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string sqlconn = "server=.\\sqlexpress;integrated security=true;database=somaliadb";
        SqlConnection con = null;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(sqlconn);
            // SqlCommand command = new SqlCommand(,con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("  select DATE,SUM([acitivity type]) as [acitivity type]  from incident where[acitivity type] = 2 group by date having date between  '2021-04-03' and '2021-04-04'", sqlconn);
            ds.Tables.Clear();
            da.Fill(ds, "inc1");
           // dataGridView1.DataSource = ds.Tables["inc1"];
            foreach (DataRow dr in ds.Tables["inc1"].Rows)
            {
                chart1.Series["state"].Points.AddXY(dr["date"].ToString(), dr["acitivity type"].ToString());
            }
          
            chart1.Titles.Add("province");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s = new Series();
            s.ChartType = SeriesChartType.Bar;

            var d = new DateTime(2013, 04, 01);
            s.Points.AddXY(3, d);
            s.Points.AddXY( 2, d.AddMonths(-1));
            s.Points.AddXY( 1, d.AddMonths(-2));
            s.Points.AddXY( 4, d.AddMonths(-3));

            //s.Points.AddXY(d, 3);
            //s.Points.AddXY(d.AddMonths(-1), 2);
            //s.Points.AddXY(d.AddMonths(-2), 1);
            //s.Points.AddXY(d.AddMonths(-3), 4);

            chart1.Series.Clear();
            chart1.Series.Add(s);


            //chart1.Series[0].XValueType = ChartValueType.DateTime;
            //chart1.ChartAreas.Add(new ChartArea()); // In some cases the winforms designer adds this already
            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            //chart1.ChartAreas[0].AxisX.Interval = 1;
            //chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            //chart1.ChartAreas[0].AxisX.IntervalOffset = 1;

            //chart1.Series[0].XValueType = ChartValueType.DateTime;
            //DateTime minDate = new DateTime(2013, 01, 01).AddSeconds(-1);
            //DateTime maxDate = new DateTime(2013, 05, 01); // or DateTime.Now;
            //chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            //chart1.ChartAreas[0].AxisX.Maximum = maxDate.ToOADate();
        }
    }
}
