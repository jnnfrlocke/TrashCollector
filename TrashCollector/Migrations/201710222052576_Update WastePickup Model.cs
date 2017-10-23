namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateWastePickupModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WastePickups", "StreetNumber", c => c.Int(nullable: false));
            AddColumn("dbo.WastePickups", "StreetName", c => c.String());
            AddColumn("dbo.WastePickups", "Apartment", c => c.String());
            AddColumn("dbo.WastePickups", "City", c => c.String());
            AddColumn("dbo.WastePickups", "State", c => c.String());
            AddColumn("dbo.WastePickups", "ZipCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WastePickups", "ZipCode");
            DropColumn("dbo.WastePickups", "State");
            DropColumn("dbo.WastePickups", "City");
            DropColumn("dbo.WastePickups", "Apartment");
            DropColumn("dbo.WastePickups", "StreetName");
            DropColumn("dbo.WastePickups", "StreetNumber");
        }
    }
}
