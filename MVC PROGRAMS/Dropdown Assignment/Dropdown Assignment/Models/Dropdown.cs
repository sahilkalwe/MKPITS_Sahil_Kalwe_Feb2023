﻿using System.Runtime.InteropServices;

namespace Dropdown_Assignment.Models
{
    public class Dropdown
    {
        public string Username { get; set; }
        public string Gender { get; set; }
        public  bool Course { get; set; }

        public City getcity { get; set; }
    
    
    }
    public enum City 
    {
        Nagpur,Mumbai
    }
}
