using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Atividade_Allbert_Cinema.Models;

namespace Atividade_Allbert_Cinema.Controllers
{
    public class ExibicoesController : Controller
    {
        private ContextoDB db = new ContextoDB();

        // GET: Exibicoes
        public ActionResult Index()
        {
            var exibicoes = db.Exibicoes.Include(e => e.Filme).Include(e => e.Sala);
            return View(exibicoes.ToList());
        }

        // GET: Exibicoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exibicoes exibicoes = db.Exibicoes.Find(id);
            if (exibicoes == null)
            {
                return HttpNotFound();
            }
            return View(exibicoes);
        }

        // GET: Exibicoes/Create
        public ActionResult Create()
        {
            ViewBag.FilmeID = new SelectList(db.Filmes, "Id", "Nome");
            ViewBag.SalaID = new SelectList(db.Salas, "Id", "Nome");
            return View();
        }

        // POST: Exibicoes/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FilmeID,SalaID")] Exibicoes exibicoes)
        {
            if (ModelState.IsValid)
            {
                db.Exibicoes.Add(exibicoes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FilmeID = new SelectList(db.Filmes, "Id", "Nome", exibicoes.FilmeID);
            ViewBag.SalaID = new SelectList(db.Salas, "Id", "Nome", exibicoes.SalaID);
            return View(exibicoes);
        }

        // GET: Exibicoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exibicoes exibicoes = db.Exibicoes.Find(id);
            if (exibicoes == null)
            {
                return HttpNotFound();
            }
            ViewBag.FilmeID = new SelectList(db.Filmes, "Id", "Nome", exibicoes.FilmeID);
            ViewBag.SalaID = new SelectList(db.Salas, "Id", "Nome", exibicoes.SalaID);
            return View(exibicoes);
        }

        // POST: Exibicoes/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FilmeID,SalaID")] Exibicoes exibicoes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(exibicoes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FilmeID = new SelectList(db.Filmes, "Id", "Nome", exibicoes.FilmeID);
            ViewBag.SalaID = new SelectList(db.Salas, "Id", "Nome", exibicoes.SalaID);
            return View(exibicoes);
        }

        // GET: Exibicoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Exibicoes exibicoes = db.Exibicoes.Find(id);
            if (exibicoes == null)
            {
                return HttpNotFound();
            }
            return View(exibicoes);
        }

        // POST: Exibicoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Exibicoes exibicoes = db.Exibicoes.Find(id);
            db.Exibicoes.Remove(exibicoes);
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
