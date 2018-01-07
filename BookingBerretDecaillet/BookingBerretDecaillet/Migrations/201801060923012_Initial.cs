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
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        IdReservation = c.Int(nullable: false, identity: true),
                        Fisrtname = c.String(),
                        Lastname = c.String(),
                        CheckIn = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        CheckOut = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Hotel_IdHotel = c.Int(),
                    })
                .PrimaryKey(t => t.IdReservation)
                .ForeignKey("dbo.Hotels", t => t.Hotel_IdHotel)
                .Index(t => t.Hotel_IdHotel);
            
            CreateTable(
                "dbo.ReservationRooms",
                c => new
                    {
                        Reservation_IdReservation = c.Int(nullable: false),
                        Room_IdRoom = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Reservation_IdReservation, t.Room_IdRoom })
                .ForeignKey("dbo.Reservations", t => t.Reservation_IdReservation, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.Room_IdRoom, cascadeDelete: true)
                .Index(t => t.Reservation_IdReservation)
                .Index(t => t.Room_IdRoom);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ReservationRooms", "Room_IdRoom", "dbo.Rooms");
            DropForeignKey("dbo.ReservationRooms", "Reservation_IdReservation", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "Hotel_IdHotel", "dbo.Hotels");
            DropForeignKey("dbo.Pictures", "Room_IdRoom", "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Hotel_IdHotel", "dbo.Hotels");
            DropIndex("dbo.ReservationRooms", new[] { "Room_IdRoom" });
            DropIndex("dbo.ReservationRooms", new[] { "Reservation_IdReservation" });
            DropIndex("dbo.Reservations", new[] { "Hotel_IdHotel" });
            DropIndex("dbo.Pictures", new[] { "Room_IdRoom" });
            DropIndex("dbo.Rooms", new[] { "Hotel_IdHotel" });
            DropTable("dbo.ReservationRooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Pictures");
            DropTable("dbo.Rooms");
            DropTable("dbo.Hotels");
        }
    }
}
