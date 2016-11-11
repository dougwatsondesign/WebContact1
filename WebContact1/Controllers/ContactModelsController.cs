using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebContact1.Models;

namespace WebContact1.Controllers
{
    public class ContactModelsController : Controller
    {
        private WebContact1Context db = new WebContact1Context();

        // GET: ContactModels
        public ActionResult Index()
        {
            return View(db.ContactModels.ToList());
        }

        // GET: ContactModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactModel contactModel = db.ContactModels.Find(id);
            if (contactModel == null)
            {
                return HttpNotFound();
            }
            return View(contactModel);
        }

        // GET: ContactModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ContactID,FirstName,LastName,Email,Phone,AltPhone,Birthday,Address1,Address2,City,State,Zip")] ContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                db.ContactModels.Add(contactModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contactModel);
        }

        // GET: ContactModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactModel contactModel = db.ContactModels.Find(id);
            if (contactModel == null)
            {
                return HttpNotFound();
            }
            return View(contactModel);
        }

        // POST: ContactModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ContactID,FirstName,LastName,Email,Phone,AltPhone,Birthday,Address1,Address2,City,State,Zip")] ContactModel contactModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contactModel);
        }

        // GET: ContactModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactModel contactModel = db.ContactModels.Find(id);
            if (contactModel == null)
            {
                return HttpNotFound();
            }
            return View(contactModel);
        }

        // POST: ContactModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactModel contactModel = db.ContactModels.Find(id);
            db.ContactModels.Remove(contactModel);
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
