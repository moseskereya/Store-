using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using App2.Models;

namespace App2.Controllers
{
    public class CategotiesController : Controller
    {
        private App2DBContext db = new App2DBContext();

        // GET: Categoties
        public ActionResult Index()
        {
            return View(db.categoties.ToList());
        }

        // GET: Categoties/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoty categoty = db.categoties.Find(id);
            if (categoty == null)
            {
                return HttpNotFound();
            }
            return View(categoty);
        }

        // GET: Categoties/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Categoties/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryID,CategoryName,Description")] Categoty categoty)
        {
            if (ModelState.IsValid)
            {
                db.categoties.Add(categoty);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoty);
        }

        // GET: Categoties/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoty categoty = db.categoties.Find(id);
            if (categoty == null)
            {
                return HttpNotFound();
            }
            return View(categoty);
        }

        // POST: Categoties/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryID,CategoryName,Description")] Categoty categoty)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoty).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoty);
        }

        // GET: Categoties/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Categoty categoty = db.categoties.Find(id);
            if (categoty == null)
            {
                return HttpNotFound();
            }
            return View(categoty);
        }

        // POST: Categoties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Categoty categoty = db.categoties.Find(id);
            db.categoties.Remove(categoty);
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
