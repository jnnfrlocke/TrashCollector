namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trytoaddforeignkey : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "UserID", c => c.String());
            AddColumn("dbo.Customers", "UserId_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Customers", "UserId_Id");
            AddForeignKey("dbo.Customers", "UserId_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Customers", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "UserName", c => c.String());
            DropForeignKey("dbo.Customers", "UserId_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Customers", new[] { "UserId_Id" });
            DropColumn("dbo.Customers", "UserId_Id");
            DropColumn("dbo.Customers", "UserID");
        }
    }
}
