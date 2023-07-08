namespace DropDown2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductTable")]
    public partial class ProductTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Productid { get; set; }

        [StringLength(30)]
        public string Productname { get; set; }

        public int? Categoryid { get; set; }

        public virtual CategoryTable CategoryTable { get; set; }
    }
}
