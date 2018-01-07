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
    [RoutePrefix("api/hotels")]
    public class HotelsController : ApiController
    {
        private HotelManagement db = new HotelManagement();

        // GET: api/Hotels
        [Route("")]
        public IQueryable<Hotel> GetHotels()
        {
            return db.Hotels
                .Include(h => h.Rooms);
        }

        // GET: api/Hotels/5
        [Route("{id:int}")]
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult GetHotel(int id)
        {
            Hotel hotel = null;
            List<Hotel> hotels = GetHotels().ToList();
            foreach (Hotel h in hotels)
            {
                if (h.IdHotel == id)
                    hotel = h;
            }

            if (hotel == null)
            {
                return NotFound();
            }

            return Ok(hotel);
        }

        // GET: api/Hotels/Sion
        [Route("{location}")]
        public IQueryable<Hotel> GetHotelByLocation(string location)
        {
            return db.Hotels
                .Where(h => h.Location.Equals(location, StringComparison.OrdinalIgnoreCase))
                .Include(h => h.Rooms);
        }

        // PUT: api/Hotels/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHotel(int id, Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hotel.IdHotel)
            {
                return BadRequest();
            }

            db.Entry(hotel).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelExists(id))
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

        // POST: api/Hotels
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult PostHotel(Hotel hotel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Hotels.Add(hotel);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hotel.IdHotel }, hotel);
        }

        // DELETE: api/Hotels/5
        [ResponseType(typeof(Hotel))]
        public IHttpActionResult DeleteHotel(int id)
        {
            Hotel hotel = db.Hotels.Find(id);
            if (hotel == null)
            {
                return NotFound();
            }

            db.Hotels.Remove(hotel);
            db.SaveChanges();

            return Ok(hotel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HotelExists(int id)
        {
            return db.Hotels.Count(e => e.IdHotel == id) > 0;
        }
    }
}