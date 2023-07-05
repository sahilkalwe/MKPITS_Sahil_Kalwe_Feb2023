using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_database_connection_2.Models
{
    public class ItemModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal price { get; set; }
    }
}