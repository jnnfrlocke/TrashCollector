namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removeforeignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WastePickups", "Zip_Id", "dbo.AspNetUsers");
            DropIndex("dbo.WastePickups", new[] { "Zip_Id" });
            AddColumn("dbo.WastePickups", "Zip", c => c.String());
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.WastePickups", "Zip_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.WastePickups", "Zip");
            CreateIndex("dbo.WastePickups", "Zip_Id");
            AddForeignKey("dbo.WastePickups", "Zip_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
