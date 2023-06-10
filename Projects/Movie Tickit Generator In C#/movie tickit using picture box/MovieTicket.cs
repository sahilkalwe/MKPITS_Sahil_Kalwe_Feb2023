using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_tickit_using_picture_box
{
    private static string connectionString = "server=LAPTOP-AQT0G55D\\SQLEXPRESS01; integrated security=true;database=Movie;";

    public static SqlConnection GetConnection()
    {
        SqlConnection conn = new SqlConnection(connectionString);
        try
        {
            //conn.Open();
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
    public abstract class MovieTicket
    {
        public string MovieName { get; set; }
        public string TheatreName { get; set; }
        public string ShowTime { get; set; }
        public int NoOfSeats { get; set; }
        public float TicketPrice { get; set; }
        public abstract string CalculateTicketPrice();

    }
   public class OnlineBooking : MovieTicket
    {
        public OnlineBooking(int NoOfSeats, float TicketPrice)
        {
            this.NoOfSeats = NoOfSeats;
            this.TicketPrice = TicketPrice;
        }
        public float discount { get; set; }
        public override string CalculateTicketPrice()
        {
            float tp = NoOfSeats * TicketPrice;
            discount = tp * 0.10f;
            tp = tp - discount;
            return "tp " + tp;
        }
    }
         public class BoxOffice : MovieTicket
        {
            public BoxOffice(int NoOfSeats, float TicketPrice)
            {
                this.NoOfSeats = NoOfSeats;
                this.TicketPrice = TicketPrice;
            }
            public float BookingFees { get; set; }
            public override string CalculateTicketPrice()
            {
                float tp = NoOfSeats * TicketPrice;
                BookingFees = 20;
                tp = tp + 20;
                return " "+tp;
            }
        }

 }

