using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DropDown2.Models
{
    public class Registration
    {
        [Required(ErrorMessage = "Enter Category")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Enter Products")]
        public string Products { get; set; }
    }
}