namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updateforeignkey2 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.WastePickups", name: "ZipCode_Id", newName: "Zip_Id");
            RenameIndex(table: "dbo.WastePickups", name: "IX_ZipCode_Id", newName: "IX_Zip_Id");
            DropColumn("dbo.WastePickups", "Zip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WastePickups", "Zip", c => c.String());
            RenameIndex(table: "dbo.WastePickups", name: "IX_Zip_Id", newName: "IX_ZipCode_Id");
            RenameColumn(table: "dbo.WastePickups", name: "Zip_Id", newName: "ZipCode_Id");
        }
    }
}
