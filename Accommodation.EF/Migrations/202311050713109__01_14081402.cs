namespace Accommodation.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _01_14081402 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Amenities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LatinName = c.String(nullable: false),
                        NativeName = c.String(nullable: false),
                        District = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                        Rules = c.String(),
                        HotelGroupId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HotelGroups", t => t.HotelGroupId, cascadeDelete: true)
                .Index(t => t.HotelGroupId);
            
            CreateTable(
                "dbo.HotelGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LatinTitle = c.String(nullable: false),
                        NativeTitle = c.String(nullable: false),
                        CityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        CountryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        CountOfBeds = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.HotelTags",
                c => new
                    {
                        TagId = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.TagId, t.HotelId })
                .ForeignKey("dbo.Hotels", t => t.TagId, cascadeDelete: true)
                .ForeignKey("dbo.Tags", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.TagId)
                .Index(t => t.HotelId);
            
            CreateTable(
                "dbo.HotelAmenities",
                c => new
                    {
                        AmenityId = c.Int(nullable: false),
                        HotelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AmenityId, t.HotelId })
                .ForeignKey("dbo.Amenities", t => t.AmenityId, cascadeDelete: true)
                .ForeignKey("dbo.Hotels", t => t.HotelId, cascadeDelete: true)
                .Index(t => t.AmenityId)
                .Index(t => t.HotelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HotelAmenities", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.HotelAmenities", "AmenityId", "dbo.Amenities");
            DropForeignKey("dbo.HotelTags", "HotelId", "dbo.Tags");
            DropForeignKey("dbo.HotelTags", "TagId", "dbo.Hotels");
            DropForeignKey("dbo.Rooms", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "HotelGroupId", "dbo.HotelGroups");
            DropForeignKey("dbo.HotelGroups", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.HotelAmenities", new[] { "HotelId" });
            DropIndex("dbo.HotelAmenities", new[] { "AmenityId" });
            DropIndex("dbo.HotelTags", new[] { "HotelId" });
            DropIndex("dbo.HotelTags", new[] { "TagId" });
            DropIndex("dbo.Rooms", new[] { "HotelId" });
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropIndex("dbo.HotelGroups", new[] { "CityId" });
            DropIndex("dbo.Hotels", new[] { "HotelGroupId" });
            DropTable("dbo.HotelAmenities");
            DropTable("dbo.HotelTags");
            DropTable("dbo.Tags");
            DropTable("dbo.Rooms");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.HotelGroups");
            DropTable("dbo.Hotels");
            DropTable("dbo.Amenities");
        }
    }
}
