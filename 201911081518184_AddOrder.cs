namespace MyDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        CompanyName = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CompanyName)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID)
                .Index(t => t.CompanyName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "CompanyName", "dbo.Customers");
            DropIndex("dbo.Orders", new[] { "CompanyName" });
            DropIndex("dbo.Orders", new[] { "ProductID" });
            DropTable("dbo.Orders");
        }
    }
}
