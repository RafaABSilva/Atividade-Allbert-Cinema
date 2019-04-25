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
    public class HomeController : Controller
    {
        private ContextoDB db = new ContextoDB();
        public ActionResult Index()
        {
            var exibicoes = db.Exibicoes.Include(e => e.Filme).Include(e => e.Sala);
            return View(exibicoes.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}