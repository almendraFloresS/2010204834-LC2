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
using _2010204834_ENT.Entities;
using _2010204834_PER;

namespace _2010204834_WebAPI.Controllers
{
    public class EncomiendasController : ApiController
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: api/Encomiendas
        public IQueryable<Encomienda> GetServicio()
        {
            return db.Encomienda;
        }

        // GET: api/Encomiendas/5
        [ResponseType(typeof(Encomienda))]
        public IHttpActionResult GetEncomienda(int id)
        {
            Encomienda encomienda = db.Encomienda.Find(id);
            if (encomienda == null)
            {
                return NotFound();
            }

            return Ok(encomienda);
        }

        // PUT: api/Encomiendas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEncomienda(int id, Encomienda encomienda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != encomienda.idServicio)
            {
                return BadRequest();
            }

            db.Entry(encomienda).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EncomiendaExists(id))
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

        // POST: api/Encomiendas
        [ResponseType(typeof(Encomienda))]
        public IHttpActionResult PostEncomienda(Encomienda encomienda)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Servicio.Add(encomienda);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = encomienda.idServicio }, encomienda);
        }

        // DELETE: api/Encomiendas/5
        [ResponseType(typeof(Encomienda))]
        public IHttpActionResult DeleteEncomienda(int id)
        {
            Encomienda encomienda = db.Encomienda.Find(id);
            if (encomienda == null)
            {
                return NotFound();
            }

            db.Servicio.Remove(encomienda);
            db.SaveChanges();

            return Ok(encomienda);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EncomiendaExists(int id)
        {
            return db.Servicio.Count(e => e.idServicio == id) > 0;
        }
    }
}