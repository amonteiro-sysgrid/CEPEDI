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
    public class RelatoriosController : Controller
    {
        private ZebraDBContext db = new ZebraDBContext();

        // GET: Relatorios
        public ActionResult Index()
        {
            return View(db.Relatorios.ToList());
        }

        // GET: Relatorios/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relatorio relatorio = db.Relatorios.Find(id);
            if (relatorio == null)
            {
                return HttpNotFound();
            }
            return View(relatorio);
        }

        // GET: Relatorios/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Relatorios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Guid,Codigo,Nome,Margens,Dimensoes,Colunas,Linhas,ArquivoLayout,Layout,Criacao,Atualizacao,Status")] Relatorio relatorio)
        {
            if (ModelState.IsValid)
            {
                relatorio.Guid = Guid.NewGuid();
                db.Relatorios.Add(relatorio);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(relatorio);
        }

        // GET: Relatorios/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relatorio relatorio = db.Relatorios.Find(id);
            if (relatorio == null)
            {
                return HttpNotFound();
            }
            return View(relatorio);
        }

        // POST: Relatorios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Guid,Codigo,Nome,Margens,Dimensoes,Colunas,Linhas,ArquivoLayout,Layout,Criacao,Atualizacao,Status")] Relatorio relatorio)
        {
            if (ModelState.IsValid)
            {
                db.Entry(relatorio).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(relatorio);
        }

        // GET: Relatorios/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Relatorio relatorio = db.Relatorios.Find(id);
            if (relatorio == null)
            {
                return HttpNotFound();
            }
            return View(relatorio);
        }

        // POST: Relatorios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Relatorio relatorio = db.Relatorios.Find(id);
            db.Relatorios.Remove(relatorio);
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
