namespace BookingBerretDecaillet
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class HotelManagement : DbContext
    {
        // Your context has been configured to use a 'HotelManagement' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookingBerretDecaillet.HotelManagement' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'HotelManagement' 
        // connection string in the application configuration file.
        public HotelManagement()
            : base("name=HotelManagement")
        {
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public System.Data.Entity.DbSet<BookingBerretDecaillet.Models.Hotel> Hotels { get; set; }

        public System.Data.Entity.DbSet<BookingBerretDecaillet.Models.Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<BookingBerretDecaillet.Models.Picture> Pictures { get; set; }

        public System.Data.Entity.DbSet<BookingBerretDecaillet.Models.Reservation> Reservations { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

}