namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addforeignkeytopasszipcodetowastepickups : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WastePickups", "Zip", c => c.String(maxLength: 128));
            CreateIndex("dbo.WastePickups", "Zip");
            AddForeignKey("dbo.WastePickups", "Zip", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WastePickups", "Zip", "dbo.AspNetUsers");
            DropIndex("dbo.WastePickups", new[] { "Zip" });
            AlterColumn("dbo.WastePickups", "Zip", c => c.String());
        }
    }
}
