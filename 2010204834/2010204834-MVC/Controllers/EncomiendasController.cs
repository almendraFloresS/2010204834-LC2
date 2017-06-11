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
    public class EncomiendasController : Controller
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: Encomiendas
        public ActionResult Index()
        {
            var servicio = db.Encomienda.Include(e => e.lugarviaje);
            return View(servicio.ToList());
        }

        // GET: Encomiendas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = db.Encomienda.Find(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            return View(encomienda);
        }

        // GET: Encomiendas/Create
        public ActionResult Create()
        {
            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre");
            return View();
        }

        // POST: Encomiendas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idServicio,NombreServicio,idLugarViaje,OrigenEncomienda,DestinoEncomienda,montoEncomienda,descripcion")] Encomienda encomienda)
        {
            if (ModelState.IsValid)
            {
                db.Servicio.Add(encomienda);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre", encomienda.idLugarViaje);
            return View(encomienda);
        }

        // GET: Encomiendas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = db.Encomienda.Find(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre", encomienda.idLugarViaje);
            return View(encomienda);
        }

        // POST: Encomiendas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idServicio,NombreServicio,idLugarViaje,OrigenEncomienda,DestinoEncomienda,montoEncomienda,descripcion")] Encomienda encomienda)
        {
            if (ModelState.IsValid)
            {
                db.Entry(encomienda).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.idLugarViaje = new SelectList(db.LugarViaje, "idLugarViaje", "nombre", encomienda.idLugarViaje);
            return View(encomienda);
        }

        // GET: Encomiendas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Encomienda encomienda = db.Encomienda.Find(id);
            if (encomienda == null)
            {
                return HttpNotFound();
            }
            return View(encomienda);
        }

        // POST: Encomiendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Encomienda encomienda = db.Encomienda.Find(id);
            db.Servicio.Remove(encomienda);
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
