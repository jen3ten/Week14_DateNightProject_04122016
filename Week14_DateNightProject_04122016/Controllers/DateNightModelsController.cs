using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week14_DateNightProject_04122016.Models;

namespace Week14_DateNightProject_04122016.Controllers
{
    public class DateNightModelsController : Controller
    {
        private Week14_DateNightProject_04122016Context db = new Week14_DateNightProject_04122016Context();

        // GET: DateNightModels
        public ActionResult Index()
        {
            return View(db.DateNightModels.ToList());
        }

        // GET: DateNightModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateNightModel dateNightModel = db.DateNightModels.Find(id);
            if (dateNightModel == null)
            {
                return HttpNotFound();
            }
            return View(dateNightModel);
        }

        // GET: DateNightModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DateNightModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RecordNum,Title,Type,FullAddress,Street,City,State,Zip,PhoneNum,Photo,Website,Cost")] DateNightModel dateNightModel)
        {
            if (ModelState.IsValid)
            {
                db.DateNightModels.Add(dateNightModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dateNightModel);
        }

        // GET: DateNightModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateNightModel dateNightModel = db.DateNightModels.Find(id);
            if (dateNightModel == null)
            {
                return HttpNotFound();
            }
            return View(dateNightModel);
        }

        // POST: DateNightModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RecordNum,Title,Type,FullAddress,Street,City,State,Zip,PhoneNum,Photo,Website,Cost")] DateNightModel dateNightModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dateNightModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dateNightModel);
        }

        // GET: DateNightModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DateNightModel dateNightModel = db.DateNightModels.Find(id);
            if (dateNightModel == null)
            {
                return HttpNotFound();
            }
            return View(dateNightModel);
        }

        // POST: DateNightModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DateNightModel dateNightModel = db.DateNightModels.Find(id);
            db.DateNightModels.Remove(dateNightModel);
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
