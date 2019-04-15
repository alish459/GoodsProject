namespace Connection.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllGoods",
                c => new
                    {
                        GoodsID = c.Int(nullable: false, identity: true),
                        GoodsName = c.String(nullable: false, maxLength: 500),
                        ActDate = c.String(nullable: false, maxLength: 10),
                        ArzID = c.Int(nullable: false),
                        BuyPrice = c.Decimal(nullable: false, precision: 18, scale: 0),
                        OtherPrices = c.Decimal(nullable: false, precision: 18, scale: 0),
                        ArzName = c.String(nullable: false, maxLength: 500),
                        ArzPrice = c.Decimal(nullable: false, precision: 18, scale: 3),
                    })
                .PrimaryKey(t => t.GoodsID);
            
            CreateTable(
                "dbo.Arz",
                c => new
                    {
                        ArzID = c.Int(nullable: false, identity: true),
                        ArzName = c.String(nullable: false, maxLength: 500),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 3),
                    })
                .PrimaryKey(t => t.ArzID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Arz");
            DropTable("dbo.AllGoods");
        }
    }
}
