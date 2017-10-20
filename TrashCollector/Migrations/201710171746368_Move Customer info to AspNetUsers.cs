namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoveCustomerinfotoAspNetUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "StreetNumber", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "StreetName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Apartment", c => c.String());
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "State", c => c.String());
            AddColumn("dbo.AspNetUsers", "ZipCode", c => c.Int(nullable: false));
            DropColumn("dbo.Customers", "FirstName");
            DropColumn("dbo.Customers", "LastName");
            DropColumn("dbo.Customers", "EmailAddress");
            DropColumn("dbo.Customers", "StreetNumber");
            DropColumn("dbo.Customers", "StreetName");
            DropColumn("dbo.Customers", "Apartment");
            DropColumn("dbo.Customers", "City");
            DropColumn("dbo.Customers", "State");
            DropColumn("dbo.Customers", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "ZipCode", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "State", c => c.String());
            AddColumn("dbo.Customers", "City", c => c.String());
            AddColumn("dbo.Customers", "Apartment", c => c.String());
            AddColumn("dbo.Customers", "StreetName", c => c.String());
            AddColumn("dbo.Customers", "StreetNumber", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "EmailAddress", c => c.String());
            AddColumn("dbo.Customers", "LastName", c => c.String());
            AddColumn("dbo.Customers", "FirstName", c => c.String());
            DropColumn("dbo.AspNetUsers", "ZipCode");
            DropColumn("dbo.AspNetUsers", "State");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "Apartment");
            DropColumn("dbo.AspNetUsers", "StreetName");
            DropColumn("dbo.AspNetUsers", "StreetNumber");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
        }
    }
}
