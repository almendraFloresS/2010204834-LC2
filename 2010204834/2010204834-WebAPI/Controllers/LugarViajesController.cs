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
    public class LugarViajesController : ApiController
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: api/LugarViajes
        public IQueryable<LugarViaje> GetLugarViaje()
        {
            return db.LugarViaje;
        }

        // GET: api/LugarViajes/5
        [ResponseType(typeof(LugarViaje))]
        public IHttpActionResult GetLugarViaje(int id)
        {
            LugarViaje lugarViaje = db.LugarViaje.Find(id);
            if (lugarViaje == null)
            {
                return NotFound();
            }

            return Ok(lugarViaje);
        }

        // PUT: api/LugarViajes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLugarViaje(int id, LugarViaje lugarViaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != lugarViaje.idLugarViaje)
            {
                return BadRequest();
            }

            db.Entry(lugarViaje).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LugarViajeExists(id))
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

        // POST: api/LugarViajes
        [ResponseType(typeof(LugarViaje))]
        public IHttpActionResult PostLugarViaje(LugarViaje lugarViaje)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.LugarViaje.Add(lugarViaje);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = lugarViaje.idLugarViaje }, lugarViaje);
        }

        // DELETE: api/LugarViajes/5
        [ResponseType(typeof(LugarViaje))]
        public IHttpActionResult DeleteLugarViaje(int id)
        {
            LugarViaje lugarViaje = db.LugarViaje.Find(id);
            if (lugarViaje == null)
            {
                return NotFound();
            }

            db.LugarViaje.Remove(lugarViaje);
            db.SaveChanges();

            return Ok(lugarViaje);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LugarViajeExists(int id)
        {
            return db.LugarViaje.Count(e => e.idLugarViaje == id) > 0;
        }
    }
}