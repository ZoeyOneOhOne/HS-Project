using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HSVersion1.Models;

namespace HSVersion1.Controllers
{
    public class LocalEventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public LocalEventsController()
        {
           db = new ApplicationDbContext();
        }
        // GET: LocalEvents1
        public ActionResult IndexPartial()
        {
            var events = db.Event.ToList();
            return View(events);
        }

        // GET: LocalEvents1/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

  
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id,Event,Description,Location,Time")] LocalEvents localEvents)
        {
            if (ModelState.ContainsKey("id"))
                ModelState["id"].Errors.Clear();
            if (ModelState.IsValid)
            {
                db.Event.Add(localEvents);
                db.SaveChanges();
                return RedirectToAction("IndexPartial");
            }

            return View(localEvents);
        }

        // GET: LocalEvents1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalEvents localEvents = db.Event.Find(id);
            if (localEvents == null)
            {
                return HttpNotFound();
            }
            return View(localEvents);
        }

        // POST: LocalEvents1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Event,Description,Location,Time")] LocalEvents localEvents)
        {
            if (ModelState.IsValid)
            {
                db.Entry(localEvents).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("IndexPartial");
            }
            return View(localEvents);
        }

        // GET: LocalEvents1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LocalEvents localEvents = db.Event.Find(id);
            if (localEvents == null)
            {
                return HttpNotFound();
            }
            return View(localEvents);
        }

        [HttpPost, ActionName("DoDelete")]
        public ActionResult DoDelete(int? id)
        {
            var localEvents = db.Event.SingleOrDefault(v => v.Id == id);
            if (localEvents == null) return HttpNotFound();
            db.Event.Remove(localEvents);
            db.SaveChanges();
            return RedirectToAction("IndexPartial");
        }

        // POST: LocalEvents1/Delete/5
      /* [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LocalEvents localEvents = db.Event.Find(id);
            db.Event.Remove(localEvents);
            db.SaveChanges();
            return RedirectToAction("IndexPartial");
        }
        */
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
