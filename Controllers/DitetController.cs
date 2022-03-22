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
    public class DitetController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ditet
        public ActionResult Index()
        {
            var ditet = db.Ditet.Include(d => d.Dega).Include(d => d.Grupi).Include(d => d.Viti);
            return View(ditet.ToList());
        }

        // GET: Ditet/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ditet ditet = db.Ditet.Find(id);
            if (ditet == null)
            {
                return HttpNotFound();
            }
            return View(ditet);
        }

        // GET: Ditet/Create
        public ActionResult Create()
        {
            ViewBag.DegaId = new SelectList(db.Dega, "Id", "Emri");
            ViewBag.GrupiId = new SelectList(db.Grupi, "Id", "EmGrupi");
            ViewBag.VitiId = new SelectList(db.Viti, "Id", "Id");
            return View();
        }

        // POST: Ditet/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Dita,Lenda,Pedagogu,LlojiOres,Ora,Salla,DegaId,VitiId,GrupiId")] Ditet ditet)
        {
            if (ModelState.IsValid)
            {
                db.Ditet.Add(ditet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DegaId = new SelectList(db.Dega, "Id", "Emri", ditet.DegaId);
            ViewBag.GrupiId = new SelectList(db.Grupi, "Id", "EmGrupi", ditet.GrupiId);
            ViewBag.VitiId = new SelectList(db.Viti, "Id", "Id", ditet.VitiId);
            return View(ditet);
        }

        // GET: Ditet/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ditet ditet = db.Ditet.Find(id);
            if (ditet == null)
            {
                return HttpNotFound();
            }
            ViewBag.DegaId = new SelectList(db.Dega, "Id", "Emri", ditet.DegaId);
            ViewBag.GrupiId = new SelectList(db.Grupi, "Id", "EmGrupi", ditet.GrupiId);
            ViewBag.VitiId = new SelectList(db.Viti, "Id", "Id", ditet.VitiId);
            return View(ditet);
        }

        // POST: Ditet/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Dita,Lenda,Pedagogu,LlojiOres,Ora,Salla,DegaId,VitiId,GrupiId")] Ditet ditet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ditet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DegaId = new SelectList(db.Dega, "Id", "Emri", ditet.DegaId);
            ViewBag.GrupiId = new SelectList(db.Grupi, "Id", "EmGrupi", ditet.GrupiId);
            ViewBag.VitiId = new SelectList(db.Viti, "Id", "Id", ditet.VitiId);
            return View(ditet);
        }

        // GET: Ditet/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ditet ditet = db.Ditet.Find(id);
            if (ditet == null)
            {
                return HttpNotFound();
            }
            return View(ditet);
        }

        // POST: Ditet/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ditet ditet = db.Ditet.Find(id);
            db.Ditet.Remove(ditet);
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
