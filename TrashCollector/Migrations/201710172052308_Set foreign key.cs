namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Setforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WastePickups", "CustomerID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WastePickups", "CustomerID");
        }
    }
}
