using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutomotiveForum.Models;

namespace AutomotiveForum.Controllers
{
    public class MarketPlacesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MarketPlaces
        public ActionResult Index()
        {
            var marketPlaces = db.MarketPlaces.Include(m => m.User);
            return View(marketPlaces.ToList());
        }

        // GET: MarketPlaces/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketPlace marketPlace = db.MarketPlaces.Find(id);
            if (marketPlace == null)
            {
                return HttpNotFound();
            }
            return View(marketPlace);
        }

        // GET: MarketPlaces/Create
        public ActionResult Create()
        {
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserRole");
            return View();
        }

        // POST: MarketPlaces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Date,Description,ItemsForSale,UserId,Price")] MarketPlace marketPlace)
        {
            if (ModelState.IsValid)
            {
                db.MarketPlaces.Add(marketPlace);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.UserId = new SelectList(db.Users, "Id", "UserRole", marketPlace.UserId);
            return View(marketPlace);
        }

        // GET: MarketPlaces/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketPlace marketPlace = db.MarketPlaces.Find(id);
            if (marketPlace == null)
            {
                return HttpNotFound();
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserRole", marketPlace.UserId);
            return View(marketPlace);
        }

        // POST: MarketPlaces/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Timestamp,Topic,Items_For_Sale,UserId")] MarketPlace marketPlace)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marketPlace).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.UserId = new SelectList(db.Users, "Id", "UserRole", marketPlace.UserId);
            return View(marketPlace);
        }

        // GET: MarketPlaces/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketPlace marketPlace = db.MarketPlaces.Find(id);
            if (marketPlace == null)
            {
                return HttpNotFound();
            }
            return View(marketPlace);
        }

        // POST: MarketPlaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MarketPlace marketPlace = db.MarketPlaces.Find(id);
            db.MarketPlaces.Remove(marketPlace);
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
