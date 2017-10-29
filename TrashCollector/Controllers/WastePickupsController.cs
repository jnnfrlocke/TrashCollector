using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;
using Microsoft.AspNet.Identity;

namespace TrashCollector.Models
{
    public class WastePickupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private UserManager<ApplicationUser> UserManager { get; set; }

        // GET: WastePickups
        public ActionResult Index()
        {
            return View(db.Pickups.ToList());
        }

        // GET: WastePickups/Details/5
        public ActionResult Details()
        {
            string id = User.Identity.GetUserId();

            var detailData = from wp in db.Pickups
                             where (wp.CustomerID == id)
                             select wp;

            WastePickups viewData = new WastePickups();
            foreach (WastePickups result in detailData)
            {
                viewData = result;
            }

            if (viewData.CustomerID == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            return View(viewData);
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
        public ActionResult Create([Bind(Include = "CollectionDay,Begin,End")] WastePickups wastePickups)
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

        public ActionResult TodaysPickups()
        {

            string id = User.Identity.GetUserId();
            
            var todayZipQuery = from wp in db.Pickups
                             where (wp.CustomerID == id)
                             select wp.Zip;
            
            string todayZip = null;

            foreach (string result in todayZipQuery)
            {
               todayZip = result;
            }

            var today = DateTime.Now.DayOfWeek.ToString();

            var pickupToday = db.Pickups.Where(x => x.CollectionDay == today);
            var zipToday = pickupToday.Where(y => y.Zip == todayZip);
            
            return View(zipToday);
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
