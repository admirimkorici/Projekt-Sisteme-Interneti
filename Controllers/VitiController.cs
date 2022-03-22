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
    public class VitiController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Viti
        public ActionResult Index()
        {
            return View(db.Viti.ToList());
        }

        // GET: Viti/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viti viti = db.Viti.Find(id);
            if (viti == null)
            {
                return HttpNotFound();
            }
            return View(viti);
        }

        // GET: Viti/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Viti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,NrViti")] Viti viti)
        {
            if (ModelState.IsValid)
            {
                db.Viti.Add(viti);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viti);
        }

        // GET: Viti/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viti viti = db.Viti.Find(id);
            if (viti == null)
            {
                return HttpNotFound();
            }
            return View(viti);
        }

        // POST: Viti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,NrViti")] Viti viti)
        {
            if (ModelState.IsValid)
            {
                db.Entry(viti).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(viti);
        }

        // GET: Viti/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Viti viti = db.Viti.Find(id);
            if (viti == null)
            {
                return HttpNotFound();
            }
            return View(viti);
        }

        // POST: Viti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Viti viti = db.Viti.Find(id);
            db.Viti.Remove(viti);
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
