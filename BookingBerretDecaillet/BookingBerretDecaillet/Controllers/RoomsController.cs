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
using Newtonsoft.Json;

namespace BookingBerretDecaillet.Controllers
{
    [RoutePrefix("api/rooms")]
    public class RoomsController : ApiController
    {
        private HotelManagement db = new HotelManagement();

        // GET: api/Rooms
        [Route("")]
        public IQueryable<Room> GetRooms()
        {
            return db.Rooms
                .Include(r => r.Hotel);
        }

        // GET: api/Rooms/5
        [Route("hotel/{id:int}")]
        public IEnumerable<Room> GetRoomsOfHotel(int id)
        {

            return db.Rooms
                .Where(r => r.Hotel.IdHotel == id)
                .Include(r => r.Hotel);
        }

        // GET: api/Rooms/5
        [Route("{id:int}")]
        [ResponseType(typeof(Room))]
        public IHttpActionResult GetRoomById(int id)
        {
            List<Room> allrooms = GetRooms().ToList();
            Room room = null;
            foreach (Room r in allrooms)
            {
                if(r.IdRoom==id)
                {
                   room = r;
                }
            }
               //room = db.Rooms
               // .Find(id);
            if (room == null)
            {
                return NotFound();
            }

            return Ok(room);
        }
        
        // GET: api/Rooms/checkin/checkout
        [Route("date/{checkin:datetime:regex(\\d{4}-\\d{2}-\\d{2})}/{checkout:datetime:regex(\\d{4}-\\d{2}-\\d{2})}")]
        public IEnumerable<Room> GetRoomByDate(DateTime checkin, DateTime checkout)
        {
            List<Room> allrooms = GetRooms().ToList();
            List<Room> availableRooms = new List<Room>();
            List<Reservation> reservations = new List<Reservation>() ;
            Reservation lastReservation;

            foreach (Room r in allrooms)
            {
                bool roomAvailable = true;

                if(r.Reservations!=null)
                {
                    reservations = r.Reservations.ToList();
                }
                //Get the last reservation for the 
                if (reservations.Count<Reservation>() > 0)
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

                if (roomAvailable)
                {
                    availableRooms.Add(r);
                }
            }

            return availableRooms;
        }

        // GET: api/Rooms/sion
        [Route("{location}")]
        public IQueryable<Room> GetRoomsByLocation(string location)
        {
            return db.Rooms
                    .Where(r => r.Hotel.Location.Equals(location, StringComparison.OrdinalIgnoreCase));
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