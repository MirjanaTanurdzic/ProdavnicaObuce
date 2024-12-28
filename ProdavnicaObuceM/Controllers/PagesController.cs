using ProdavnicaObuceM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ProdavnicaObuceM.Controllers
{
    public class PagesController : Controller
    {
        public ActionResult Pocetna()
        {
            ViewBag.Title = "Pocetna";
            return View();
        }
        public ActionResult Brendovi() 
        {
            ViewBag.Title = "Brendovi";
            return View();
        }
        [HttpGet]
        public ActionResult NarudzbaM()
        {
            return View();
        }
        [HttpPost]
        public ViewResult NarudzbaM(Models.mainModel prikaz)
        {
            return View("NaruceniProizvodM", prikaz);
        }
        [HttpGet]
        public ActionResult NarudzbaZ()
        {
            return View();
        }
        [HttpPost]
        public ViewResult NarudzbaZ(Models.mainModel prikaz) 
        {
            return View("NaruceniProizvodZ", prikaz);
        }
        [HttpGet]
        public ActionResult NarudzbaD()
        {
            return View();
        }
        [HttpPost]
        public ViewResult NarudzbaD(Models.mainModel prikaz) 
        {
            return View("NaruceniProizvodD", prikaz);
        }
    }
}