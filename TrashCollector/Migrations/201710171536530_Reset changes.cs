namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Resetchanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CreditCard");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CreditCard", c => c.Int());
        }
    }
}
