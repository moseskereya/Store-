namespace App2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoties",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 100),
                        Description = c.String(),
                        Accesories_Id = c.Int(),
                        Colors_ColorId = c.Int(),
                    })
                .PrimaryKey(t => t.CategoryID)
                .ForeignKey("dbo.Accesories", t => t.Accesories_Id)
                .ForeignKey("dbo.Colors", t => t.Colors_ColorId)
                .Index(t => t.Accesories_Id)
                .Index(t => t.Colors_ColorId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        description = c.String(nullable: false),
                        ImageUrl = c.String(),
                        ShortDescription = c.String(),
                        Price = c.Decimal(precision: 18, scale: 2),
                        CategotyId = c.Int(),
                        AccesoriesId = c.Int(),
                        Categoty_CategoryID = c.Int(),
                        Color_ColorId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accesories", t => t.AccesoriesId)
                .ForeignKey("dbo.Categoties", t => t.Categoty_CategoryID)
                .ForeignKey("dbo.Colors", t => t.Color_ColorId)
                .Index(t => t.AccesoriesId)
                .Index(t => t.Categoty_CategoryID)
                .Index(t => t.Color_ColorId);
            
            CreateTable(
                "dbo.Accesories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Amount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Colors",
                c => new
                    {
                        ColorId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        availability = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ColorId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Language = c.String(),
                        Code = c.String(),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        CountryId = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "CountryId", "dbo.Countries");
            DropForeignKey("dbo.Products", "Color_ColorId", "dbo.Colors");
            DropForeignKey("dbo.Categoties", "Colors_ColorId", "dbo.Colors");
            DropForeignKey("dbo.Products", "Categoty_CategoryID", "dbo.Categoties");
            DropForeignKey("dbo.Products", "AccesoriesId", "dbo.Accesories");
            DropForeignKey("dbo.Categoties", "Accesories_Id", "dbo.Accesories");
            DropIndex("dbo.Customers", new[] { "CountryId" });
            DropIndex("dbo.Products", new[] { "Color_ColorId" });
            DropIndex("dbo.Products", new[] { "Categoty_CategoryID" });
            DropIndex("dbo.Products", new[] { "AccesoriesId" });
            DropIndex("dbo.Categoties", new[] { "Colors_ColorId" });
            DropIndex("dbo.Categoties", new[] { "Accesories_Id" });
            DropTable("dbo.Customers");
            DropTable("dbo.Countries");
            DropTable("dbo.Colors");
            DropTable("dbo.Accesories");
            DropTable("dbo.Products");
            DropTable("dbo.Categoties");
        }
    }
}
