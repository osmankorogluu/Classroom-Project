using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDERSHANE.Models.Entitiy;

namespace MVCDERSHANE.Controllers
{
    public class OdevController : Controller
    {
        // GET: Odev
        DbMvcDershaneEntities1 db = new DbMvcDershaneEntities1();
       
        public ActionResult Index()
        {
            var degerler = db.TBLODEV.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult OdevEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OdevEkle(TBLODEV p)
        {
            db.TBLODEV.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult OdevSil(int id)
        {
            var degerler = db.TBLODEV.Find(id);
            db.TBLODEV.Remove(degerler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult OdevGetir(int id)
        {
            var degerler = db.TBLODEV.Find(id);
            return View("OdevGetir", degerler);
        }
        public ActionResult Guncelle(TBLODEV p)
        {
            var degerler = db.TBLODEV.Find(p.İD);
            degerler.OGRAD = p.OGRAD;
            degerler.OGRSOYAD = p.OGRSOYAD;
            degerler.SINIFI = p.SINIFI;
            degerler.VERİLİSTARİH = p.VERİLİSTARİH;
            degerler.TESLİMTARİH = p.TESLİMTARİH;
            degerler.VERİLENNOT = p.VERİLENNOT;
            degerler.MAİL = p.MAİL;
            degerler.BOLUMU = p.BOLUMU;
            degerler.DERS = p.DERS;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}