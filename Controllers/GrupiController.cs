using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Projekt_Sisteme_Interneti.Models;

namespace Projekt_Sisteme_Interneti.Controllers
{
    public class GrupiController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Grupi
        public ActionResult Index()
        {
            return View(db.Grupi.ToList());
        }

        // GET: Grupi/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupi grupi = db.Grupi.Find(id);
            if (grupi == null)
            {
                return HttpNotFound();
            }
            return View(grupi);
        }

        // GET: Grupi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grupi/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,EmGrupi")] Grupi grupi)
        {
            if (ModelState.IsValid)
            {
                db.Grupi.Add(grupi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(grupi);
        }

        // GET: Grupi/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupi grupi = db.Grupi.Find(id);
            if (grupi == null)
            {
                return HttpNotFound();
            }
            return View(grupi);
        }

        // POST: Grupi/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EmGrupi")] Grupi grupi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(grupi);
        }

        // GET: Grupi/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupi grupi = db.Grupi.Find(id);
            if (grupi == null)
            {
                return HttpNotFound();
            }
            return View(grupi);
        }

        // POST: Grupi/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grupi grupi = db.Grupi.Find(id);
            db.Grupi.Remove(grupi);
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
