namespace BookingBerretDecaillet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        IdHotel = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Description = c.String(),
                        Location = c.String(maxLength: 50),
                        Category = c.Int(nullable: false),
                        Wifi = c.Boolean(),
                        Parking = c.Boolean(),
                        Phone = c.String(),
                        Email = c.String(),
                        WebSite = c.String(),
                    })
                .PrimaryKey(t => t.IdHotel);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        IdRoom = c.Int(nullable: false, identity: true),
                        Number = c.Int(nullable: false),
                        Description = c.String(),
                        Type = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HasTV = c.Boolean(),
                        HasHairdryer = c.Boolean(),
                        Hotel_IdHotel = c.Int(),
                    })
                .PrimaryKey(t => t.IdRoom)
                .ForeignKey("dbo.Hotels", t => t.Hotel_IdHotel)
                .Index(t => t.Hotel_IdHotel);
            
            CreateTable(
                "dbo.Pictures",
                c => new
                    {
                        IdPicture = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Room_IdRoom = c.Int(),
                    })
                .PrimaryKey(t => t.IdPicture)
                .ForeignKey("dbo.Rooms", t => t.Room_IdRoom)
                .Index(t => t.Room_IdRoom);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pictures", "Room_IdRoom", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Hotel_IdHotel", "dbo.Hotels");
            DropIndex("dbo.Pictures", new[] { "Room_IdRoom" });
            DropIndex("dbo.Rooms", new[] { "Hotel_IdHotel" });
            DropTable("dbo.Pictures");
            DropTable("dbo.Rooms");
            DropTable("dbo.Hotels");
        }
    }
}
