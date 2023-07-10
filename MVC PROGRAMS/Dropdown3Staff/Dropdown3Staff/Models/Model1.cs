using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Dropdown3Staff.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<StaffTable> StaffTables { get; set; }
        public virtual DbSet<StudentTable> StudentTables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StaffTable>()
                .Property(e => e.Staffname)
                .IsUnicode(false);

            modelBuilder.Entity<StudentTable>()
                .Property(e => e.Studentname)
                .IsUnicode(false);
        }
    }
}
