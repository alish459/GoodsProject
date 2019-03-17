namespace Connecntion
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Connecntion.Tables;

    public partial class PersianMode : DbContext
    {
        public PersianMode()
            : base("name=PersianCS")
        {
        }
        public virtual DbSet<Arz> Arz { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arz>()
                .Property(e => e.ArzPrice)
                .HasPrecision(18, 0);
        }
    }
}
