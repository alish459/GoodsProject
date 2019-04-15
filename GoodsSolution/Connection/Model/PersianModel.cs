namespace Connection.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PersianModel : DbContext
    {
        public PersianModel()
            : base("name=PersianModel")
        {
        }

        public virtual DbSet<AllGoods> AllGoods { get; set; }
        public virtual DbSet<Arz> Arz { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //try
            //{
            //    Database.SetInitializer<PersianModel>(null);
            //    base.OnModelCreating(modelBuilder);
            //}
            //catch 
            //{
            //    System.Windows.Forms.MessageBox.Show("œÌ «»Ì” œ— Õ«· ”«Œ ‰ «” ");
            //    throw;
            //}
            
            modelBuilder.Entity<AllGoods>()
                .Property(e => e.BuyPrice)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AllGoods>()
                .Property(e => e.OtherPrices)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AllGoods>()
                .Property(e => e.ArzPrice)
                .HasPrecision(18, 3);

            modelBuilder.Entity<Arz>()
                .Property(e => e.Price)
                .HasPrecision(18, 3);
        }
    }
}
