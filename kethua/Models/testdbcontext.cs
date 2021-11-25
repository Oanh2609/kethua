using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace kethua.Models
{
    public partial class testdbcontext : DbContext
    {
        public testdbcontext()
            : base("name=testdbcontext")
        {
        }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
