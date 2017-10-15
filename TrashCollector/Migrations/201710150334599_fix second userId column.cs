namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixseconduserIdcolumn : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "UserID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "UserID", c => c.String());
        }
    }
}
