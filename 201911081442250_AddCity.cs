namespace MyDataBase.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "City", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Address", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "PostalCode", c => c.String(nullable: false));
            AddColumn("dbo.Customers", "Phone", c => c.String());
            AddColumn("dbo.Customers", "Mail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Mail");
            DropColumn("dbo.Customers", "Phone");
            DropColumn("dbo.Customers", "PostalCode");
            DropColumn("dbo.Customers", "Address");
            DropColumn("dbo.Customers", "City");
        }
    }
}
