using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace validation_summary.Models
{ 
    public class Validation
    {
        [StringLength (50,MinimumLength = 3)]
        public string Name { get; set; }
      public string Email { get; set; }
        public string ConformEmail { get; set; }
        public int Age { get; set; }





    }
}
