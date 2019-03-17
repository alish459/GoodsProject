namespace Connecntion.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersianMG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arz",
                c => new
                    {
                        ArzID = c.Int(nullable: false, identity: true),
                        ArzName = c.String(nullable: false, maxLength: 500),
                        ArzPrice = c.Decimal(nullable: false, precision: 18, scale: 0),
                    })
                .PrimaryKey(t => t.ArzID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Arz");
        }
    }
}
