using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDERSHANE.Models.Entitiy;

namespace MVCDERSHANE.Controllers
{
    public class VeliController : Controller
    {
        // GET: Veli
        DbMvcDershaneEntities1 db = new DbMvcDershaneEntities1();
       
        public ActionResult Index()
        {
            var listele = db.TBLVELİ.ToList();
            return View(listele);
        }
        [HttpGet]
        public ActionResult VeliEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult VeliEkle(TBLVELİ p)
        {
            db.TBLVELİ.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult VeliSil(int id)
        {
            var veriler = db.TBLVELİ.Find(id);
            db.TBLVELİ.Remove(veriler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult VeliGetir(int id)
        {
            var degerler = db.TBLVELİ.Find(id);
            return View("VeliGetir", degerler);
        }
        public ActionResult Guncelle(TBLVELİ p)
        {
            var v = db.TBLVELİ.Find(p.İD);
            v.AD = p.AD;
            v.SOYAD = p.SOYAD;
            v.YAKINLIK = p.YAKINLIK;
            v.ADRES = p.ADRES;
            v.POSTAKOD = p.POSTAKOD;
            v.TELEFON = p.TELEFON;
            v.TC = p.TC;
            v.GELİRİ = p.GELİRİ;
            db.SaveChanges();
            return RedirectToAction("Index","Veli");
        }
    }
}