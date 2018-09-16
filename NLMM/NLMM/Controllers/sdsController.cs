using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NLMM.Models;

namespace NLMM.Controllers
{
    public class sdsController : Controller
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: sds
        public ActionResult Index()
        {
            return View(db.sd.ToList());
        }

        // GET: sds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sd sd = db.sd.Find(id);
            if (sd == null)
            {
                return HttpNotFound();
            }
            return View(sd);
        }

        // GET: sds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: sds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id")] sd sd)
        {
            if (ModelState.IsValid)
            {
                db.sd.Add(sd);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sd);
        }

        // GET: sds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sd sd = db.sd.Find(id);
            if (sd == null)
            {
                return HttpNotFound();
            }
            return View(sd);
        }

        // POST: sds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id")] sd sd)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sd).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sd);
        }

        // GET: sds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sd sd = db.sd.Find(id);
            if (sd == null)
            {
                return HttpNotFound();
            }
            return View(sd);
        }

        // POST: sds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sd sd = db.sd.Find(id);
            db.sd.Remove(sd);
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
