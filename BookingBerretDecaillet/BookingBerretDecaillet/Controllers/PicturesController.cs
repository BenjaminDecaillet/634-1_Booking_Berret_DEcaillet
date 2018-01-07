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
    [RoutePrefix("api/pictures")]
    public class PicturesController : ApiController
    {
        private HotelManagement db = new HotelManagement();

        // GET: api/pictures
        [Route("")]
        public IQueryable<Picture> GetPictures()
        {
            return db.Pictures
                .Include(p => p.Room);
        }

        // GET: api/pictures/5
        [Route("room/{id:int}")]
        public IQueryable<Picture> GetPictureOfRoom(int id)
        {

            return db.Pictures
                    .Where(p => p.Room.IdRoom == id)
                    .Include(p => p.Room);
        }

        // GET: api/Pictures/5
        [Route("{id:int}")]
        [ResponseType(typeof(Picture))]
        public IHttpActionResult GetPicture(int id)
        {
            Picture picture = null;
            List<Picture> pictures = GetPictures().ToList();
            foreach (Picture p in pictures)
            {
                if (p.IdPicture == id)
                    picture = p;
            }

            if (picture == null)
            {
                return NotFound();
            }

            return Ok(picture);
        }

        // PUT: api/Pictures/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPicture(int id, Picture picture)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != picture.IdPicture)
            {
                return BadRequest();
            }

            db.Entry(picture).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PictureExists(id))
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

        // POST: api/Pictures
        [ResponseType(typeof(Picture))]
        public IHttpActionResult PostPicture(Picture picture)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pictures.Add(new Picture()
            {
                IdPicture = picture.IdPicture,
                Url = picture.Url,
                Room = db.Rooms.Where(r => r.IdRoom == picture.Room.IdRoom).FirstOrDefault()
            });
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = picture.IdPicture }, picture);
        }

        // DELETE: api/Pictures/5
        [ResponseType(typeof(Picture))]
        public IHttpActionResult DeletePicture(int id)
        {
            Picture picture = db.Pictures.Find(id);
            if (picture == null)
            {
                return NotFound();
            }

            db.Pictures.Remove(picture);
            db.SaveChanges();

            return Ok(picture);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PictureExists(int id)
        {
            return db.Pictures.Count(e => e.IdPicture == id) > 0;
        }
    }
}