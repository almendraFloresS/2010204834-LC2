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
    public class TripulacionsController : ApiController
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: api/Tripulacions
        public IQueryable<Tripulacion> GetEmpleado()
        {
            return db.Tripulacion;
        }

        // GET: api/Tripulacions/5
        [ResponseType(typeof(Tripulacion))]
        public IHttpActionResult GetTripulacion(int id)
        {
            Tripulacion tripulacion = db.Tripulacion.Find(id);
            if (tripulacion == null)
            {
                return NotFound();
            }

            return Ok(tripulacion);
        }

        // PUT: api/Tripulacions/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTripulacion(int id, Tripulacion tripulacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tripulacion.idEmpleado)
            {
                return BadRequest();
            }

            db.Entry(tripulacion).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TripulacionExists(id))
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

        // POST: api/Tripulacions
        [ResponseType(typeof(Tripulacion))]
        public IHttpActionResult PostTripulacion(Tripulacion tripulacion)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Empleado.Add(tripulacion);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tripulacion.idEmpleado }, tripulacion);
        }

        // DELETE: api/Tripulacions/5
        [ResponseType(typeof(Tripulacion))]
        public IHttpActionResult DeleteTripulacion(int id)
        {
            Tripulacion tripulacion = db.Tripulacion.Find(id);
            if (tripulacion == null)
            {
                return NotFound();
            }

            db.Empleado.Remove(tripulacion);
            db.SaveChanges();

            return Ok(tripulacion);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TripulacionExists(int id)
        {
            return db.Empleado.Count(e => e.idEmpleado == id) > 0;
        }
    }
}