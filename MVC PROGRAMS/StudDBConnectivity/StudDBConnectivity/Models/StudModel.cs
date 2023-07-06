using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudDBConnectivity.Models
{
    public class StudModel
    {
        public int StudID { get; set; } 
        public string StudName { get; set; }
        public int StudRollNo { get; set;}

        public int StudAge { get; set; }
        public string StudDesignation { get; set; } 

    }
}