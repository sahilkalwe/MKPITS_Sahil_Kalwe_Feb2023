﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Movie_tickit_example_in_windows_form
{
    abstract class Movie_Tickit
    {
        public string MovieName { get; set; }
        public string TheatreName { get; set; }
        public string ShowTime { get; set;}
        public int NoOfSeats { get;set; }
        public float TickitPrice { get; set; }
        public abstract string Calculate_Tickit_price();

    }
    class Online_Booking:Movie_Tickit
    {
        public float discount { get;set; }
        public override string Calculate_Tickit_price()
        {
            float tp = NoOfSeats*TickitPrice+discount;
            return "Total Price Of Tickit Is" + tp.ToString();
        }


    }
    class Box_Office:Movie_Tickit
   
    {
        public float BookingFees { get; set; }  
        public override string Calculate_Tickit_price()
        {
            float tp =NoOfSeats*TickitPrice ;
            return "Total Price Of Tickit Is "+tp.ToString();
        }

    }


}
