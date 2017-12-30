using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using BookingBerretDecaillet;
using BookingBerretDecaillet.Models;

namespace BookingBerretDecaillet.Controllers
{
    [Route("api/[controller]")]
    public class RoomsController : ApiController
    {
        private HotelManagement db = new HotelManagement();

        // GET: api/Rooms
        public IQueryable<Room> GetRooms()
        {
            return db.Rooms;
        }

        // GET: api/RoomsofHotel/5
        public IQueryable<Room> GetRoomsOfHotel(int id)
        {
            Hotel hotel = db.Hotels.Find(id);
            List<Room> rooms = new List<Room>();
            List<Room> allrooms =  (List<Room>) GetRooms();
            foreach (Room r in allrooms)
            {
                if (r.Hotel == hotel)
                {
                    rooms.Add(r);
                }
            }
            return (IQueryable<Room>) rooms;
        }

        // GET: api/Rooms/5
        [ResponseType(typeof(Room))]
        public IHttpActionResult GetRoomById(int id)
        {
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }

        // GET: api/Rooms/checkin=date&checkout=date
        public IQueryable<Room> GetRoomByDate(DateTime checkin, DateTime checkout)
        {
            List<Room> allrooms = (List<Room>)GetRooms();
            List<Room> availableRooms = new List<Room>();
            List<Reservation> reservations;
            Reservation lastReservation;

            foreach (Room r in allrooms)
            {
                bool roomAvailable = true;
                //Get the last reservation for the room
                reservations = (List<Reservation>) r.Reservations;
                if (reservations.Count > 0)
                {
                    List<Reservation> resTest = new List<Reservation>();
                    lastReservation = reservations.First();
                    
                    foreach (Reservation res in reservations)
                    {
                        if (!(res.CheckOut < checkin && res.CheckIn < checkin) ||
                            !(res.CheckIn > checkout && res.CheckOut > checkout))
                        {
                            roomAvailable = false;
                        }
                    }

                }
                //If the room will be checked out for the checkin date add room to available rooms
                //Or the room is reserved for before the check in of the last reservation
                if (roomAvailable)
                    {
                        availableRooms.Add(r);
                    }
            }

            return (IQueryable<Room>) availableRooms;
        }

        // GET: api/Rooms/location
        public IQueryable<Room> GetRoomsByLocation(string location)
        {
            List<Room> allrooms = (List<Room>)GetRooms();
            List<Room> availableRooms = new List<Room>();
            foreach (Room r in allrooms)
            {
                if (r.Hotel.Location == location)
                {
                    availableRooms.Add(r);
                }
            }
            return (IQueryable<Room>) availableRooms;
        }
        // GET: api/Rooms/5
        public IQueryable<Room> GetRoomSearch(DateTime checkin, DateTime checkout,string location)
        {
            IQueryable<Room> rooms;
            if (string.IsNullOrEmpty(location))
                rooms = GetRoomByDate(checkin, checkout);
            else
                rooms = GetRoomsByLocation(location);

            return rooms;
        }
        // PUT: api/Rooms/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRoom(int id, Room room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != room.IdRoom)
            {
                return BadRequest();
            }

            db.Entry(room).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Rooms
        [ResponseType(typeof(Room))]
        public IHttpActionResult PostRoom(Room room)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Rooms.Add(room);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = room.IdRoom }, room);
        }

        // DELETE: api/Rooms/5
        [ResponseType(typeof(Room))]
        public IHttpActionResult DeleteRoom(int id)
        {
            Room room = db.Rooms.Find(id);
            if (room == null)
            {
                return NotFound();
            }

            db.Rooms.Remove(room);
            db.SaveChanges();

            return Ok(room);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RoomExists(int id)
        {
            return db.Rooms.Count(e => e.IdRoom == id) > 0;
        }
    }
}