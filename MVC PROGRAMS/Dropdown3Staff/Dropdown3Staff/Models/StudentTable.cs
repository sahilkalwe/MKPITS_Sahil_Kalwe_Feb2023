namespace Dropdown3Staff.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentTable")]
    public partial class StudentTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Studentid { get; set; }

        [StringLength(30)]
        public string Studentname { get; set; }

        public int? Staffid { get; set; }

        public virtual StaffTable StaffTable { get; set; }
    }
}
