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
    public class AdministrativoesController : Controller
    {
        private EmpresaTransporteDBContext db = new EmpresaTransporteDBContext();

        // GET: Administrativoes
        public ActionResult Index()
        {
            return View(db.Empleado.ToList());
        }

        // GET: Administrativoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Administrativo.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // GET: Administrativoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrativoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idEmpleado,NombreEmpleado,fechaContratacion")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                db.Empleado.Add(administrativo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(administrativo);
        }

        // GET: Administrativoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Administrativo.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idEmpleado,NombreEmpleado,fechaContratacion")] Administrativo administrativo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(administrativo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(administrativo);
        }

        // GET: Administrativoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Administrativo administrativo = db.Administrativo.Find(id);
            if (administrativo == null)
            {
                return HttpNotFound();
            }
            return View(administrativo);
        }

        // POST: Administrativoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Administrativo administrativo = db.Administrativo.Find(id);
            db.Empleado.Remove(administrativo);
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
