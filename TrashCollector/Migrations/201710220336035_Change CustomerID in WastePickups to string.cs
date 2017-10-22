namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomerIDinWastePickupstostring : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.WastePickups", new[] { "Customer_Id" });
            DropColumn("dbo.WastePickups", "CustomerID");
            RenameColumn(table: "dbo.WastePickups", name: "Customer_Id", newName: "CustomerID");
            AlterColumn("dbo.WastePickups", "CustomerID", c => c.String(maxLength: 128));
            CreateIndex("dbo.WastePickups", "CustomerID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.WastePickups", new[] { "CustomerID" });
            AlterColumn("dbo.WastePickups", "CustomerID", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.WastePickups", name: "CustomerID", newName: "Customer_Id");
            AddColumn("dbo.WastePickups", "CustomerID", c => c.Int(nullable: false));
            CreateIndex("dbo.WastePickups", "Customer_Id");
        }
    }
}
