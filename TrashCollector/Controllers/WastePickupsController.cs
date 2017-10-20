using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace TrashCollector.Models
{
    public class WastePickupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: WastePickups
        public ActionResult Index()
        {
            return View(db.Pickups.ToList());
        }

        // GET: WastePickups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WastePickups wastePickups = db.Pickups.Find(id);
            if (wastePickups == null)
            {
                return HttpNotFound();
            }
            return View(wastePickups);
        }

        // GET: WastePickups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WastePickups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerID,CollectionDay,Begin,End,CollectionDates,CostPerPickup,Balance")] WastePickups wastePickups)
        {
            if (ModelState.IsValid)
            {
                db.Pickups.Add(wastePickups);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(wastePickups);
        }

        // GET: WastePickups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WastePickups wastePickups = db.Pickups.Find(id);
            if (wastePickups == null)
            {
                return HttpNotFound();
            }
            return View(wastePickups);
        }

        // POST: WastePickups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerID,CollectionDay,Begin,End,CollectionDates,CostPerPickup,Balance")] WastePickups wastePickups)
        {
            if (ModelState.IsValid)
            {
                db.Entry(wastePickups).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(wastePickups);
        }

        // GET: WastePickups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            WastePickups wastePickups = db.Pickups.Find(id);
            if (wastePickups == null)
            {
                return HttpNotFound();
            }
            return View(wastePickups);
        }

        // POST: WastePickups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            WastePickups wastePickups = db.Pickups.Find(id);
            db.Pickups.Remove(wastePickups);
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
