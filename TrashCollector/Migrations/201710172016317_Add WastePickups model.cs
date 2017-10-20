namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWastePickupsmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WastePickups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        CollectionDay = c.String(),
                        Begin = c.String(),
                        End = c.String(),
                        CollectionDates = c.String(),
                        CostPerPickup = c.Int(nullable: false),
                        Balance = c.Int(nullable: false),
                        Customer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Customer_Id)
                .Index(t => t.Customer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WastePickups", "Customer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.WastePickups", new[] { "Customer_Id" });
            DropTable("dbo.WastePickups");
        }
    }
}
