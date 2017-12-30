namespace BookingBerretDecaillet.Migrations
{
    using BookingBerretDecaillet.Models;
    using System;
    using System.Collections.Generic;
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
            //Hotels Creation
            List<Room> rooms;

            //Octodure
            Hotel hotOct = new Hotel()
            {
                IdHotel = 1,
                Name = "Octodure",
                Description = "Hotel octodure Martigny",
                Location = "Martigny",
                Category = 4,
                Wifi = true,
                Parking = true,
                Phone = "0273231007",
                Email = "octodurehotel@hotmail.ch",
                WebSite = "htttp://www.octodurehotel.com"
            };
            // Add hotel
            context.Hotels.Add(hotOct);
            context.SaveChanges();
            //Add Rooms
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
            hotOct.rooms = rooms;
            context.SaveChanges();


            //Constantin
            Hotel hotConst = new Hotel()
            {
                IdHotel = 2,
                Name = "Constantin",
                Description = "Hotel Constantin Martigny",
                Location = "Martigny",
                Category = 4,
                Wifi = true,
                Parking = true,
                Phone = "0273294242",
                Email = "constantinhotel@hotmail.ch",
                WebSite = "htttp://www.constantinhotel.com"
            };
            // Add hotel
            context.Hotels.Add(hotConst);
            context.SaveChanges();
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
            hotConst.rooms = rooms;
            context.SaveChanges();

            //Valais Palace
            Hotel hotValPal = new Hotel()
            {
                IdHotel = 3,
                Name = "Valais Palace",
                Description = "Hotel Valais Palace Sion",
                Location = "Sion",
                Category = 4,
                Wifi = true,
                Parking = true,
                Phone = "0273238969",
                Email = "vspalace@hotmail.ch",
                WebSite = "htttp://www.vspalace.com"
            };
            // Add hotel
            context.Hotels.Add(hotValPal);
            context.SaveChanges();
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
            hotValPal.rooms = rooms;
            context.SaveChanges();

            //Grand Duc Rooms
            Hotel hotGrandDuc = new Hotel()
            {
                IdHotel = 4,
                Name = "Grand Duc",
                Description = "Hotel Grand Duc Sion",
                Location = "Sion",
                Category = 4,
                Wifi = true,
                Parking = true,
                Phone = "0273235002",
                Email = "grandduc@hotmail.ch",
                WebSite = "htttp://www.grandduc.com"
            };
            // Add hotel
            context.Hotels.Add(hotGrandDuc);
            context.SaveChanges();
            rooms = new List<Room>() {
                new Room()
                {
                    IdRoom = 30,
                    Number = 100,
                    Type = 1,
                    Description = "Grand Duc single room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 31,
                    Number = 101,
                    Type = 1,
                    Description = "Grand Duc single room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 32,
                    Number = 102,
                    Type = 1,
                    Description = "Grand Duc single room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 33,
                    Number = 103,
                    Type = 1,
                    Description = "Grand Duc single room 4",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 34,
                    Number = 200,
                    Type = 2,
                    Description = "Grand Duc double room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 35,
                    Number = 201,
                    Type = 2,
                    Description = "Grand Duc double room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 4).FirstOrDefault()
                }
            };
            hotGrandDuc.rooms = rooms;
            context.SaveChanges();

            //Walliser Palace
            Hotel hotWall = new Hotel()
            {
                IdHotel = 5,
                Name = "Walliser Palace",
                Description = "Hotel Walliser Palace Brig",
                Location = "Brig",
                Category = 4,
                Wifi = true,
                Parking = true,
                Phone = "0273285465",
                Email = "walliserpalace@hotmail.ch",
                WebSite = "htttp://www.walliserpalace.com",
            };
            // Add hotel
            context.Hotels.Add(hotWall);
            context.SaveChanges();
            rooms = new List<Room>() {
                new Room()
                {
                    IdRoom = 36,
                    Number = 100,
                    Type = 1,
                    Description = "Walliser Palace single room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 5).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 37,
                    Number = 101,
                    Type = 1,
                    Description = "Walliser Palace single room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 5).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 38,
                    Number = 102,
                    Type = 1,
                    Description = "Walliser Palace single room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 5).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 39,
                    Number = 103,
                    Type = 1,
                    Description = "Walliser Palace single room 4",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 5).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 40,
                    Number = 200,
                    Type = 2,
                    Description = "Walliser Palace double room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 5).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 41,
                    Number = 201,
                    Type = 2,
                    Description = "Walliser Palace double room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 5).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 42,
                    Number = 202,
                    Type = 2,
                    Description = "Walliser Palace double room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 5).FirstOrDefault()
                }
            };
            hotWall.rooms = rooms;
            context.SaveChanges();

            //Mattherhorn Palace
            Hotel hotMatt = new Hotel()
            {
                IdHotel = 6,
                Name = "Mattherhorn Palace",
                Description = "Hotel Mattherhorn Palace Brig",
                Location = "Brig",
                Category = 4,
                Wifi = true,
                Parking = true,
                Phone = "0273238546",
                Email = "mattherhornpalace@hotmail.ch",
                WebSite = "htttp://www.mattherhornpalace.com"
            };
            // Add hotel
            context.Hotels.Add(hotMatt);
            context.SaveChanges();
            rooms = new List<Room>() {
                new Room()
                {
                    IdRoom = 43,
                    Number = 100,
                    Type = 1,
                    Description = "Mattherhorn Palace single room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 6).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 44,
                    Number = 101,
                    Type = 1,
                    Description = "Mattherhorn Palace single room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 6).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 45,
                    Number = 102,
                    Type = 1,
                    Description = "Mattherhorn Palace single room 3",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 6).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 46,
                    Number = 103,
                    Type = 1,
                    Description = "Walliser Palace single room 4",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 6).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 47,
                    Number = 104,
                    Type = 1,
                    Description = "Mattherhorn Palace single room 5",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 6).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 48,
                    Number = 200,
                    Type = 2,
                    Description = "Walliser Palace double room 1",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 6).FirstOrDefault()
                },
                new Room()
                {
                    IdRoom = 49,
                    Number = 201,
                    Type = 2,
                    Description = "Walliser Palace double room 2",
                    HasHairdryer = true,
                    HasTV = true,
                    Price = 2000,
                    Hotel = context.Hotels.Where(a => a.IdHotel == 6).FirstOrDefault()
                }
            };
            hotMatt.rooms = rooms;
            context.SaveChanges();

            Picture pic1 = new Picture()
            {
                IdPicture = 1,
                Url = "http://www.hotel-imperator.com/photos/chambres/original/classiques/chambre-hotel-prestige-quatre-etoiles.jpg"
            };
            Picture pic2 = new Picture()
            {
                IdPicture = 2,
                Url = "http://img.ohmymag.com/hotel/chambre-d-hotel_204177_w460.jpg"
            };
            Picture pic3 = new Picture()
            {
                IdPicture = 3,
                Url = "http://www.hotel-chaumiere.fr/uploads/media/hotel-chaumiere-honfleur-11763.jpg"
            };
            Picture pic4 = new Picture()
            {
                IdPicture = 4,
                Url = "http://www.hoteldesprinces.com/images/chambres/cosy/chambre-cosy.jpg"
            };
            Picture pic5 = new Picture()
            {
                IdPicture = 5,
                Url = "http://www.beausejour.ch/wp-content/uploads/galeries/chambre-DBK-3-1.jpg"
            };
            Picture pic6 = new Picture()
            {
                IdPicture = 6,
                Url = "https://media-cdn.tripadvisor.com/media/photo-o/03/bb/4a/44/guest-room.jpg"
            };

            context.Pictures.Add(pic1);
            context.Pictures.Add(pic2);
            context.Pictures.Add(pic3);
            context.Pictures.Add(pic4);
            context.Pictures.Add(pic5);
            context.Pictures.Add(pic6);
            context.SaveChanges();

            Room room;
            List<Picture> piclist;
            Picture pic;

            room = context.Rooms.FirstOrDefault(r => r.IdRoom == 1);
            pic = context.Pictures.Single(p => p.IdPicture == 1);
            pic.Room = room;
            piclist = new List<Picture>() { pic1 };
            room.Pictures = piclist;

            room = context.Rooms.FirstOrDefault(r => r.IdRoom == 10);
            pic = context.Pictures.Single(p => p.IdPicture == 2);
            pic.Room = room;
            piclist = new List<Picture>() { pic };
            room.Pictures = piclist;

            room = context.Rooms.FirstOrDefault(r => r.IdRoom == 19);
            pic = context.Pictures.Single(p => p.IdPicture == 3);
            pic.Room = room;
            piclist = new List<Picture>() { pic };
            room.Pictures = piclist;

            room = context.Rooms.Where(r => r.IdRoom == 30).FirstOrDefault();
            pic = context.Pictures.Single(p => p.IdPicture == 4);
            pic.Room = room;
            piclist = new List<Picture>() { pic };
            room.Pictures = piclist;

            room = context.Rooms.Where(r => r.IdRoom == 36).FirstOrDefault();
            pic = context.Pictures.Single(p => p.IdPicture == 5);
            pic.Room = room;
            piclist = new List<Picture>() { pic };
            room.Pictures = piclist;

            room = context.Rooms.Where(r => r.IdRoom == 43).FirstOrDefault();
            pic = context.Pictures.Single(p => p.IdPicture == 6);
            pic.Room = room;
            piclist = new List<Picture>() { pic };
            room.Pictures = piclist;
            context.SaveChanges();
        }
    }
}
