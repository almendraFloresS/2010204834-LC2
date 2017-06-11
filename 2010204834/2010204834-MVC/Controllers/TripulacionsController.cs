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
    public class TripulacionsController : Controller
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: Tripulacions
        public ActionResult Index()
        {
            return View(db.Empleado.ToList());
        }

        // GET: Tripulacions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulacion.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // GET: Tripulacions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tripulacions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpleado,NombreEmpleado,tipotripulacion,licencia,fec_ingreso")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                db.Empleado.Add(tripulacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tripulacion);
        }

        // GET: Tripulacions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulacion.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // POST: Tripulacions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmpleado,NombreEmpleado,tipotripulacion,licencia,fec_ingreso")] Tripulacion tripulacion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tripulacion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tripulacion);
        }

        // GET: Tripulacions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tripulacion tripulacion = db.Tripulacion.Find(id);
            if (tripulacion == null)
            {
                return HttpNotFound();
            }
            return View(tripulacion);
        }

        // POST: Tripulacions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tripulacion tripulacion = db.Tripulacion.Find(id);
            db.Empleado.Remove(tripulacion);
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
