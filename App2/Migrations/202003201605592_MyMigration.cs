namespace App2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MyMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "CountryId", "dbo.Countries");
            DropIndex("dbo.Customers", new[] { "CountryId" });
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Countries", "Language", c => c.String(nullable: false));
            AlterColumn("dbo.Countries", "Code", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "CountryId", c => c.Int());
            CreateIndex("dbo.Customers", "CountryId");
            AddForeignKey("dbo.Customers", "CountryId", "dbo.Countries", "CountryId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CountryId", "dbo.Countries");
            DropIndex("dbo.Customers", new[] { "CountryId" });
            AlterColumn("dbo.Customers", "CountryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Countries", "Code", c => c.String());
            AlterColumn("dbo.Countries", "Language", c => c.String());
            AlterColumn("dbo.Countries", "Name", c => c.String());
            CreateIndex("dbo.Customers", "CountryId");
            AddForeignKey("dbo.Customers", "CountryId", "dbo.Countries", "CountryId", cascadeDelete: true);
        }
    }
}
