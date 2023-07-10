using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Dropdown3Staff.Models
{
    public class Registration
    {


        [Required(ErrorMessage = "Enter Staff")]
        public string Staff { get; set; }
        [Required(ErrorMessage = "Enter Student")]
        public string Students { get; set; }
    }
}