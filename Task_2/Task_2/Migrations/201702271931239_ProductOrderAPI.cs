namespace Task_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductOrderAPI : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Address = c.String(nullable: false, maxLength: 50),
                        City = c.String(nullable: false, maxLength: 50),
                        State = c.String(nullable: false, maxLength: 50),
                        Zip = c.String(nullable: false, maxLength: 7),
                        Phone = c.String(nullable: false, maxLength: 8),
                        Email = c.String(nullable: false, maxLength: 50),
                        CardNumber = c.String(nullable: false, maxLength: 14),
                        CardExpirationMonth = c.Int(nullable: false),
                        CardExpirationYear = c.Int(nullable: false),
                        CardSecurityCode = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
