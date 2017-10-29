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

namespace TrashCollector.Controllers
{
    public class NewlyWastePickupsController : Controller
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
            string usrId = User.Identity.GetUserId();

            var detailData = from wp in db.Pickups
                             where (wp.CustomerID == usrId)
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
        [HttpPost]
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
        public ActionResult Edit(int? id) { 
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
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: WastePickups/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: WastePickups/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
