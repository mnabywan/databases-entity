namespace MyDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProducts : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "ProductID", "dbo.Products");
            DropIndex("dbo.Orders", new[] { "ProductID" });
            AddColumn("dbo.Products", "Order_OrderID", c => c.Int());
            AlterColumn("dbo.Orders", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            CreateIndex("dbo.Products", "Order_OrderID");
            AddForeignKey("dbo.Products", "Order_OrderID", "dbo.Orders", "OrderID");
            DropColumn("dbo.Orders", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "ProductID", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "Order_OrderID", "dbo.Orders");
            DropIndex("dbo.Products", new[] { "Order_OrderID" });
            AlterColumn("dbo.Orders", "Price", c => c.Double(nullable: false));
            DropColumn("dbo.Products", "Order_OrderID");
            CreateIndex("dbo.Orders", "ProductID");
            AddForeignKey("dbo.Orders", "ProductID", "dbo.Products", "ProductId", cascadeDelete: true);
        }
    }
}
