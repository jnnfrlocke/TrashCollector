namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveunnecessaryCustomerIDcolumnfromWastePickups : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.WastePickups", "CustomerID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WastePickups", "CustomerID", c => c.Int(nullable: false));
        }
    }
}
