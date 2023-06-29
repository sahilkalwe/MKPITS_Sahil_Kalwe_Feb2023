namespace DropdownAssignment.Models
{
    public class Dropdown
    {
        public string usernmae { get; set; }
        public bool Subject1 { get; set; }
        public bool Subject2 { get; set; }
        public string Gender { get; set; }
        public City getCity { get; set; }
        public bool course { get; set; }
        public string res { get; set; }
    }
        public enum City
        {
            Nagpur, Mumbai
        }

    }

