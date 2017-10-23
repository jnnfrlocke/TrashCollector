namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedatatypeforZipcodeinusertalble : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WastePickups", "Zip", c => c.String());
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.String());
            DropColumn("dbo.WastePickups", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WastePickups", "ZipCode", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "ZipCode", c => c.Int(nullable: false));
            DropColumn("dbo.WastePickups", "Zip");
        }
    }
}
