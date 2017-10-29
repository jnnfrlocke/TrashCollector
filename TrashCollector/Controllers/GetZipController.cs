using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class GetZipController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GetZip
        public ActionResult Index()
        {
            return View();
        }

        // GET: GetZip/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: GetZip/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GetZip/Create
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id, ZipCode")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                //db.Customers.Add();
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer);
        }
    }
}


        //// GET: GetZip/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: GetZip/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: GetZip/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: GetZip/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
//    }
//}
