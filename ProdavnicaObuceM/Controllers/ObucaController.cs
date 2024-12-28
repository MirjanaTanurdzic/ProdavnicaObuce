using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProdavnicaObuceM.Controllers
{
    public class ObucaController : Controller
    {
        // GET: Obuca
        public ActionResult Muska()
        {
            ViewBag.Title = "Muška obuća";
            return View();
        }
        public ActionResult Zenska()
        {
            ViewBag.Title = "Ženska obuća";
            return View();
        }
        public ActionResult Decija()
        {
            ViewBag.Title = "Dečija obuća";
            return View();
        }
    }
}