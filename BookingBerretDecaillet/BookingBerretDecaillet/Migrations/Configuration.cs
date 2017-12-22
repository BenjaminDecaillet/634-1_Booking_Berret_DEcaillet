namespace BookingBerretDecaillet.Migrations
{
    using BookingBerretDecaillet.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookingBerretDecaillet.HotelManagement>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookingBerretDecaillet.HotelManagement context)
        {
            //Rooms Creation
            List<Room> rooms;
            //context.Rooms.AddOrUpdate(x => x.IdRoom,
            //Octodure Rooms
            context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel() { IdHotel = 1, Name = "Octodure" });
            rooms = new List<Room>() {
                    new Room()
                {
                    IdRoom = 1,
                    Number = 100,
                    Type = 1,
                    Description = "Octodure Single room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 2,
                    Number = 101,
                    Type = 1,
                    Description = "Octodure Single room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 3,
                    Number = 102,
                    Type = 1,
                    Description = "Octodure Single room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 4,
                    Number = 103,
                    Type = 1,
                    Description = "Octodure Single room 4",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 5,
                    Number = 200,
                    Type = 2,
                    Description = "Octodure double room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 6,
                    Number = 201,
                    Type = 2,
                    Description = "Octodure double room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 7,
                    Number = 202,
                    Type = 2,
                    Description = "Octodure double room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 8,
                    Number = 203,
                    Type = 2,
                    Description = "Octodure double room 4",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                },
                    new Room()
                {
                    IdRoom = 9,
                    Number = 204,
                    Type = 2,
                    Description = "Octodure double room 5",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 1).FirstOrDefault()
                }
                };
            context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel() { IdHotel = 1, Name = "Octodure", Description = "Hotel octodure Martigny", rooms = rooms });

            //Constantin Rooms
            context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel() { IdHotel = 2, Name = "Constantin" });
            rooms = new List<Room>() {
                new Room()
                {
                    IdRoom = 10,
                    Number = 100,
                    Type = 1,
                    Description = "Constantin Single room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 11,
                    Number = 101,
                    Type = 1,
                    Description = "Constantin Single room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 12,
                    Number = 200,
                    Type = 2,
                    Description = "Constantin double room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 13,
                    Number = 201,
                    Type = 2,
                    Description = "Constantin double room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 14,
                    Number = 202,
                    Type = 2,
                    Description = "Constantin double room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 15,
                    Number = 203,
                    Type = 2,
                    Description = "Constantin double room 4",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 16,
                    Number = 204,
                    Type = 2,
                    Description = "Constantin double room 5",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 17,
                    Number = 205,
                    Type = 2,
                    Description = "Constantin double room 6",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 18,
                    Number = 206,
                    Type = 2,
                    Description = "Constantin double room 7",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 2).FirstOrDefault()
                }
            };
            context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel()
            {
                IdHotel = 2,
                Name = "Constantin",
                Description = "Hotel Constantin Martigny",
                rooms = rooms
            });
            //Valais Palace Rooms
            context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel() { IdHotel = 3, Name = "Valais Palace" });
            rooms = new List<Room>() {
                new Room()
                {
                    IdRoom = 19,
                    Number = 100,
                    Type = 1,
                    Description = "Valais Palace Single room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 20,
                    Number = 101,
                    Type = 1,
                    Description = "Valais Palace Single room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 21,
                    Number = 102,
                    Type = 1,
                    Description = "Valais Palace Single room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 22,
                    Number = 200,
                    Type = 2,
                    Description = "Valais Palace double room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 23,
                    Number = 201,
                    Type = 2,
                    Description = "Valais Palace double room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 24,
                    Number = 202,
                    Type = 2,
                    Description = "Valais Palace double room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 25,
                    Number = 203,
                    Type = 2,
                    Description = "Valais Palace double room 4",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 26,
                    Number = 204,
                    Type = 2,
                    Description = "Valais Palace double room 5",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 27,
                    Number = 205,
                    Type = 2,
                    Description = "Valais Palace double room 6",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 28,
                    Number = 206,
                    Type = 2,
                    Description = "Valais Palace double room 7",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 29,
                    Number = 207,
                    Type = 2,
                    Description = "Valais Palace double room 8",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 3).FirstOrDefault()
                }
            };
            context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel()
            {
                IdHotel = 3,
                Name = "Valais Palace",
                Description = "Hotel Valais Palace Sion",
                rooms = rooms
            });
            //Grand Duc Rooms
            //context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel() { IdHotel = 4, Name = "Grand Duc" });
            //rooms = new List<Room>() {
            //    new Room()
            //    {
            //        IdRoom = 30,
            //        Number = 100,
            //        Type = 1,
            //        Description = "Grand Duc single room 1",
            //        HasHairdryer = true,
            //        HasTV = true,
            //        Price = 2000,
            //        Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
            //    },
            //    new Room()
            //    {
            //        IdRoom = 31,
            //        Number = 101,
            //        Type = 1,
            //        Description = "Grand Duc single room 2",
            //        HasHairdryer = true,
            //        HasTV = true,
            //        Price = 2000,
            //        Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
            //    }
            //    };
            //context.Hotels.AddOrUpdate(x => x.IdHotel, new Hotel()
            //{
            //    IdHotel = 4,
            //    Name = "Grand Duc",
            //    Description = "Hotel Grand Duc Sion",
            //    rooms = rooms
            //});

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
