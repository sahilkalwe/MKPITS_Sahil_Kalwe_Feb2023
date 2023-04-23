using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_tickit_using_picture_box
{
    abstract class MovieTicket
    {
        public string MovieName { get; set; }
        public string TheatreName { get; set; }
        public string ShowTime { get; set; }
        public int NoOfSeats { get; set; }
        public float TicketPrice { get; set; }
        public abstract string CalculateTicketPrice();

    }
    class OnlineBooking:MovieTicket
    {
        public OnlineBooking(int NoOfSeats,float Ticketprice)
        {
            this.NoOfSeats = NoOfSeats;
            this.TicketPrice = TicketPrice;
        }
        public float discount { get; set; }
        public override string CalculateTicketPrice() 
        {
            float tp = NoOfSeats * TicketPrice - discount;
            return "Total Ticket Price is " + tp.ToString();
        }
        class BoxOffice:MovieTicket
        {
            public BoxOffice(int NoOfSeats, float TicketPrice)
            {
                this.NoOfSeats = NoOfSeats;
                this.TicketPrice = TicketPrice;
            }
            public float BookingFees { get; set; }
            public override string CalculateTicketPrice()
            {
                float tp = NoOfSeats * TicketPrice + BookingFees;
                return "Total Price Of Ticket Is "+tp.ToString();
            }
        }
    }
}
