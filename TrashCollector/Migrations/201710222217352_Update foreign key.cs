namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updateforeignkey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.WastePickups", "Zip", "dbo.AspNetUsers");
            DropIndex("dbo.WastePickups", new[] { "Zip" });
            AddColumn("dbo.WastePickups", "ZipCode_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.WastePickups", "Zip", c => c.String());
            CreateIndex("dbo.WastePickups", "ZipCode_Id");
            AddForeignKey("dbo.WastePickups", "ZipCode_Id", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WastePickups", "ZipCode_Id", "dbo.AspNetUsers");
            DropIndex("dbo.WastePickups", new[] { "ZipCode_Id" });
            AlterColumn("dbo.WastePickups", "Zip", c => c.String(maxLength: 128));
            DropColumn("dbo.WastePickups", "ZipCode_Id");
            CreateIndex("dbo.WastePickups", "Zip");
            AddForeignKey("dbo.WastePickups", "Zip", "dbo.AspNetUsers", "Id");
        }
    }
}
