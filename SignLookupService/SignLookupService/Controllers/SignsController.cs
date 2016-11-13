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
using SignLookupService.Models;

namespace SignLookupService.Controllers
{
    public class SignsController : ApiController
    {
        private SignLookupServiceContext db = new SignLookupServiceContext();

        // GET: api/Signs
        public IQueryable<Sign> GetSigns()
        {
            return db.Signs;
        }

        // GET: api/Signs/5
        [ResponseType(typeof(Sign))]
        public IHttpActionResult GetSign(int id)
        {
            Sign sign = db.Signs.Find(id);
            if (sign == null)
            {
                return NotFound();
            }

            return Ok(sign);
        }

        // PUT: api/Signs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSign(int id, Sign sign)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sign.ID)
            {
                return BadRequest();
            }

            db.Entry(sign).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SignExists(id))
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

        // POST: api/Signs
        [ResponseType(typeof(Sign))]
        public IHttpActionResult PostSign(Sign sign)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Signs.Add(sign);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sign.ID }, sign);
        }

        // DELETE: api/Signs/5
        [ResponseType(typeof(Sign))]
        public IHttpActionResult DeleteSign(int id)
        {
            Sign sign = db.Signs.Find(id);
            if (sign == null)
            {
                return NotFound();
            }

            db.Signs.Remove(sign);
            db.SaveChanges();

            return Ok(sign);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SignExists(int id)
        {
            return db.Signs.Count(e => e.ID == id) > 0;
        }
    }
}