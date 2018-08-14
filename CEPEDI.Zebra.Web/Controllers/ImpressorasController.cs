using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CEPEDI.Zebra.Web.Models;

namespace CEPEDI.Zebra.Web.Controllers
{
    public class ImpressorasController : Controller
    {
        private ZebraDBContext db = new ZebraDBContext();

        // GET: Impressoras
        public ActionResult Index()
        {
            return View(db.Impressoras.ToList());
        }

        // GET: Impressoras/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Impressora impressora = db.Impressoras.Find(id);
            if (impressora == null)
            {
                return HttpNotFound();
            }
            return View(impressora);
        }

        // GET: Impressoras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Impressoras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Guid,Nome,Modelo,Path,Ribbon,Criacao,Atualizacao,Status")] Impressora impressora)
        {
            if (ModelState.IsValid)
            {
                impressora.Guid = Guid.NewGuid();
                db.Impressoras.Add(impressora);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(impressora);
        }

        // GET: Impressoras/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Impressora impressora = db.Impressoras.Find(id);
            if (impressora == null)
            {
                return HttpNotFound();
            }
            return View(impressora);
        }

        // POST: Impressoras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Guid,Nome,Modelo,Path,Ribbon,Criacao,Atualizacao,Status")] Impressora impressora)
        {
            if (ModelState.IsValid)
            {
                db.Entry(impressora).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(impressora);
        }

        // GET: Impressoras/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Impressora impressora = db.Impressoras.Find(id);
            if (impressora == null)
            {
                return HttpNotFound();
            }
            return View(impressora);
        }

        // POST: Impressoras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Impressora impressora = db.Impressoras.Find(id);
            db.Impressoras.Remove(impressora);
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
