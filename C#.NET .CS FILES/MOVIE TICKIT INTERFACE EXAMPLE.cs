using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE_TICKIT_INTERFACE_EXAMPLE
{
    class MovieTickit
    {
        private string MovieName;
        private string TheatreName;
        private DateTime ShowTime;
        private int SeatNumber;
        private double TickitPrice;
        public string getMovieName
        {
            get { return MovieName; }
            set { MovieName = value; }
        }
        public string getTheatreName
        {
            get { return TheatreName; }
            set { TheatreName = value; }
        }
        public DateTime getShowTime
        {
            get { return ShowTime; }
            set { ShowTime = value; }
        }
        public int getSeatNumber
        {
            get { return SeatNumber; }
            set { SeatNumber =value; }
        }
        public double getTickitPrice
        {
            get { return TickitPrice; }
            set { TickitPrice = value; }
        }
    }
    class OnlineBooking:MovieTickit
    {
       private double Discount;
        public double getDiscount;
        {
            get { return Discount; }
            set { Discount = value; }   
        }
    }
class program
    { 
        static void Main(string[] args)
        {
            MovieTickit m = new MovieTickit();
            m.getMovieName = "my name is khan";
            m.getTheatreName = "sudama";
            //m.getShowTime =01-01-2023 12:00:00 AM;
            m.getSeatNumber = 10;
            m.getTickitPrice = 300;
            string moviename = m.getMovieName;
            string theatrename=m.getTheatreName;
            DateTime showtime= m.getShowTime;
            int seatnumber=m.getSeatNumber;
            double tickitprice = m.getTickitPrice;
            Console.WriteLine("Movie name is " + moviename);
            Console.WriteLine("theatre name is " + theatrename); 
            Console.WriteLine("show time is " + showtime);
            Console.WriteLine("Seat number is " + seatnumber);
            Console.WriteLine("Tickit Price is " + tickitprice);

            Console.ReadKey();
        }
    }
}
