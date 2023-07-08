using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DropDown2.Models
{
    public partial class Model12 : DbContext
    {
        public Model12()
            : base("name=Model12")
        {
        }

        public virtual DbSet<CategoryTable> CategoryTables { get; set; }
        public virtual DbSet<ProductTable> ProductTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryTable>()
                .Property(e => e.Categoryname)
                .IsUnicode(false);

            modelBuilder.Entity<ProductTable>()
                .Property(e => e.Productname)
                .IsUnicode(false);
        }
    }
}
