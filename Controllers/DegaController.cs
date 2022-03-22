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
    public class DegaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Dega
        public ActionResult Index()
        {
            return View(db.Dega.ToList());
        }

        // GET: Dega/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dega dega = db.Dega.Find(id);
            if (dega == null)
            {
                return HttpNotFound();
            }
            return View(dega);
        }

        // GET: Dega/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Dega/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Emri")] Dega dega)
        {
            if (ModelState.IsValid)
            {
                db.Dega.Add(dega);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dega);
        }

        // GET: Dega/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dega dega = db.Dega.Find(id);
            if (dega == null)
            {
                return HttpNotFound();
            }
            return View(dega);
        }

        // POST: Dega/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Emri")] Dega dega)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dega).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dega);
        }

        // GET: Dega/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dega dega = db.Dega.Find(id);
            if (dega == null)
            {
                return HttpNotFound();
            }
            return View(dega);
        }

        // POST: Dega/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dega dega = db.Dega.Find(id);
            db.Dega.Remove(dega);
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
