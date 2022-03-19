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
using CapaDatos;

namespace ProyectoBank.Controllers
{
    public class TipoCambiosController : ApiController
    {
        private CentroBankEntities db = new CentroBankEntities();

        // GET: api/TipoCambios
        public IQueryable<TipoCambio> GetTipoCambio()
        {
            return db.TipoCambio;
        }

        // GET: api/TipoCambios/5
        [ResponseType(typeof(TipoCambio))]
        public IHttpActionResult GetTipoCambio(int id)
        {
            TipoCambio tipoCambio = db.TipoCambio.Find(id);
            if (tipoCambio == null)
            {
                return NotFound();
            }

            return Ok(tipoCambio);
        }

        // PUT: api/TipoCambios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTipoCambio(int id, TipoCambio tipoCambio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tipoCambio.IdTipoCambio)
            {
                return BadRequest();
            }

            db.Entry(tipoCambio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipoCambioExists(id))
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

        // POST: api/TipoCambios
        [ResponseType(typeof(TipoCambio))]
        public IHttpActionResult PostTipoCambio(TipoCambio tipoCambio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TipoCambio.Add(tipoCambio);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tipoCambio.IdTipoCambio }, tipoCambio);
        }

        // DELETE: api/TipoCambios/5
        [ResponseType(typeof(TipoCambio))]
        public IHttpActionResult DeleteTipoCambio(int id)
        {
            TipoCambio tipoCambio = db.TipoCambio.Find(id);
            if (tipoCambio == null)
            {
                return NotFound();
            }

            db.TipoCambio.Remove(tipoCambio);
            db.SaveChanges();

            return Ok(tipoCambio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TipoCambioExists(int id)
        {
            return db.TipoCambio.Count(e => e.IdTipoCambio == id) > 0;
        }
    }
}