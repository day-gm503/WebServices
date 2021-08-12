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
using WebServicesSignosVitales.Models;

namespace WebServicesSignosVitales.Controllers
{
    public class sat_oxiController : ApiController
    {
        private uth_inte09Entities db = new uth_inte09Entities();

        // GET: api/sat_oxi
        public IQueryable<sat_oxi> Getsat_oxi()
        {
            return db.sat_oxi;
        }

        // GET: api/sat_oxi/5
        [ResponseType(typeof(sat_oxi))]
        public IHttpActionResult Getsat_oxi(int id)
        {
            sat_oxi sat_oxi = db.sat_oxi.Find(id);
            if (sat_oxi == null)
            {
                return NotFound();
            }

            return Ok(sat_oxi);
        }

        // PUT: api/sat_oxi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putsat_oxi(int id, sat_oxi sat_oxi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sat_oxi.IdSO)
            {
                return BadRequest();
            }

            db.Entry(sat_oxi).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!sat_oxiExists(id))
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

        // POST: api/sat_oxi
        [ResponseType(typeof(sat_oxi))]
        public IHttpActionResult Postsat_oxi(sat_oxi sat_oxi)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.sat_oxi.Add(sat_oxi);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = sat_oxi.IdSO }, sat_oxi);
        }

        // DELETE: api/sat_oxi/5
        [ResponseType(typeof(sat_oxi))]
        public IHttpActionResult Deletesat_oxi(int id)
        {
            sat_oxi sat_oxi = db.sat_oxi.Find(id);
            if (sat_oxi == null)
            {
                return NotFound();
            }

            db.sat_oxi.Remove(sat_oxi);
            db.SaveChanges();

            return Ok(sat_oxi);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool sat_oxiExists(int id)
        {
            return db.sat_oxi.Count(e => e.IdSO == id) > 0;
        }
    }
}