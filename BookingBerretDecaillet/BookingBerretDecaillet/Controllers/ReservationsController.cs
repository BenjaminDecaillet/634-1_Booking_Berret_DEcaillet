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
    public class ReservationsController : ApiController
    {
        private HotelManagement db = new HotelManagement();

        // GET: api/Reservations
        public IQueryable<Reservation> GetReservations()
        {
            return db.Reservations
                .Include(r => r.RoomsReservation)
                .Include(r => r.Hotel);
        }

        // GET: api/Reservations/5
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult GetReservation(int id)
        {
            Reservation reservation = null;
            List<Reservation> reservations = GetReservations().ToList();

            foreach (Reservation r in reservations)
            {
                if(r.IdReservation==id)
                {
                    reservation = r;
                }
            }

            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }

        // PUT: api/Reservations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReservation(int id, Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reservation.IdReservation)
            {
                return BadRequest();
            }

            db.Entry(reservation).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReservationExists(id))
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

        // POST: api/Reservations
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult PostReservation(Reservation reservation)
        {
            HotelsController hc = new HotelsController();
            RoomsController rc = new RoomsController();

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            Reservation reservationPost = reservation;
            ICollection<Room> rooms = reservation.RoomsReservation;

            db.Reservations.Add(reservationPost);
            db.SaveChanges();
            reservationPost.RoomsReservation = rooms;
            reservationPost.Hotel = db.Hotels.Where(h => h.IdHotel == reservation.Hotel.IdHotel).FirstOrDefault();
            db.SaveChanges();
            return CreatedAtRoute("DefaultApi", new { id = reservation.IdReservation }, reservation);
        }

        // DELETE: api/Reservations/5
        [ResponseType(typeof(Reservation))]
        public IHttpActionResult DeleteReservation(int id)
        {
            Reservation reservation = db.Reservations.Find(id);
            if (reservation == null)
            {
                return NotFound();
            }

            db.Reservations.Remove(reservation);
            db.SaveChanges();

            return Ok(reservation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReservationExists(int id)
        {
            return db.Reservations.Count(e => e.IdReservation == id) > 0;
        }
    }
}