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
    public class LugarViajesController : Controller
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: LugarViajes
        public ActionResult Index()
        {
            return View(db.LugarViaje.ToList());
        }

        // GET: LugarViajes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LugarViaje lugarViaje = db.LugarViaje.Find(id);
            if (lugarViaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarViaje);
        }

        // GET: LugarViajes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LugarViajes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idLugarViaje,nombre,direccion,tipolugar")] LugarViaje lugarViaje)
        {
            if (ModelState.IsValid)
            {
                db.LugarViaje.Add(lugarViaje);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lugarViaje);
        }

        // GET: LugarViajes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LugarViaje lugarViaje = db.LugarViaje.Find(id);
            if (lugarViaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarViaje);
        }

        // POST: LugarViajes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idLugarViaje,nombre,direccion,tipolugar")] LugarViaje lugarViaje)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lugarViaje).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lugarViaje);
        }

        // GET: LugarViajes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LugarViaje lugarViaje = db.LugarViaje.Find(id);
            if (lugarViaje == null)
            {
                return HttpNotFound();
            }
            return View(lugarViaje);
        }

        // POST: LugarViajes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LugarViaje lugarViaje = db.LugarViaje.Find(id);
            db.LugarViaje.Remove(lugarViaje);
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
