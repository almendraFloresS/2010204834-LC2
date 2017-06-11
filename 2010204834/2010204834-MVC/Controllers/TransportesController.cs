using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2010204834_ENT.Entities;
using _2010204834_PER;

namespace _2010204834_MVC.Controllers
{
    public class TransportesController : Controller
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: Transportes
        public ActionResult Index()
        {
            var servicio = db.Transporte.Include(t => t.lugarviaje).Include(t => t.bus);
            return View(servicio.ToList());
        }

        // GET: Transportes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.Transporte.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // GET: Transportes/Create
        public ActionResult Create()
        {
            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre");
            ViewBag.idBus = new SelectList(db.Bus, "idBus", "placa");
            return View();
        }

        // POST: Transportes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idServicio,NombreServicio,idLugarViaje,OrigenTransporte,DestinoTransporte,fecha,montoTransporte,tipoviaje,idBus")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                db.Servicio.Add(transporte);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre", transporte.idLugarViaje);
            ViewBag.idBus = new SelectList(db.Bus, "idBus", "placa", transporte.idBus);
            return View(transporte);
        }

        // GET: Transportes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.Transporte.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre", transporte.idLugarViaje);
            ViewBag.idBus = new SelectList(db.Bus, "idBus", "placa", transporte.idBus);
            return View(transporte);
        }

        // POST: Transportes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idServicio,NombreServicio,idLugarViaje,OrigenTransporte,DestinoTransporte,fecha,montoTransporte,tipoviaje,idBus")] Transporte transporte)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transporte).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre", transporte.idLugarViaje);
            ViewBag.idBus = new SelectList(db.Bus, "idBus", "placa", transporte.idBus);
            return View(transporte);
        }

        // GET: Transportes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transporte transporte = db.Transporte.Find(id);
            if (transporte == null)
            {
                return HttpNotFound();
            }
            return View(transporte);
        }

        // POST: Transportes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transporte transporte = db.Transporte.Find(id);
            db.Servicio.Remove(transporte);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
