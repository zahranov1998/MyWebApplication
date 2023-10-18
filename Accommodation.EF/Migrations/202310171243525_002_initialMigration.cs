namespace Accommodation.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _002_initialMigration : DbMigration
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
                        HotelId = c.Int(nullable: false),
                        AmenityId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.HotelId, t.AmenityId })
                .ForeignKey("dbo.Amenities", t => t.HotelId, cascadeDelete: true)
                .ForeignKey("dbo.Hotels", t => t.AmenityId, cascadeDelete: true)
                .Index(t => t.HotelId)
                .Index(t => t.AmenityId);
            
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HotelAmenities", "AmenityId", "dbo.Hotels");
            DropForeignKey("dbo.HotelAmenities", "HotelId", "dbo.Amenities");
            DropForeignKey("dbo.HotelTags", "HotelId", "dbo.Tags");
            DropForeignKey("dbo.HotelTags", "TagId", "dbo.Hotels");
            DropForeignKey("dbo.Rooms", "HotelId", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", "HotelGroupId", "dbo.HotelGroups");
            DropForeignKey("dbo.HotelGroups", "CityId", "dbo.Cities");
            DropIndex("dbo.HotelAmenities", new[] { "AmenityId" });
            DropIndex("dbo.HotelAmenities", new[] { "HotelId" });
            DropIndex("dbo.HotelTags", new[] { "HotelId" });
            DropIndex("dbo.HotelTags", new[] { "TagId" });
            DropIndex("dbo.Rooms", new[] { "HotelId" });
            DropIndex("dbo.HotelGroups", new[] { "CityId" });
            DropIndex("dbo.Hotels", new[] { "HotelGroupId" });
            AlterColumn("dbo.Countries", "Name", c => c.String());
            DropTable("dbo.HotelAmenities");
            DropTable("dbo.HotelTags");
            DropTable("dbo.Tags");
            DropTable("dbo.Rooms");
            DropTable("dbo.HotelGroups");
            DropTable("dbo.Hotels");
            DropTable("dbo.Amenities");
        }
    }
}
