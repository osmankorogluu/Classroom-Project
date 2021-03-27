using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDERSHANE.Models.Entitiy;

namespace MVCDERSHANE.Controllers
{
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        DbMvcDershaneEntities1 db = new DbMvcDershaneEntities1();
      
        public ActionResult Index(string p)
        {
            var kitaplar = from k in db.TBLOGRENCİ select k;
            if (!string.IsNullOrEmpty(p))
            {
                kitaplar = kitaplar.Where(m => m.AD.Contains(p));
            }

            //  var kitap = db.TBLKİTAP.ToList();
            return View(kitaplar.ToList());
           // var veriler=db.TBLOGRENCİ.ToList();
           // return View(kitaplar);
        }
        public ActionResult OgrenciSil(int id)
        {
            var veriler = db.TBLOGRENCİ.Find(id);
            db.TBLOGRENCİ.Remove(veriler);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult OgrenciEkle()
        {
            List<SelectListItem> deger1 = (from i in db.TBLBOLUM.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.BOLUMU,
                                               Value = i.İD.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;

            return View();

        }
        [HttpPost]
        public ActionResult OgrenciEkle(TBLOGRENCİ p)
        {
            var veriler = db.TBLOGRENCİ.Add(p);
         //   var ogr = db.TBLBOLUM.Where(k => k.İD == p.TBLBOLUM.İD).FirstOrDefault();
            db.SaveChanges();
            return View();
        }
        
        public ActionResult OgrenciGetir(int id)
        {
            
            var veriler = db.TBLOGRENCİ.Find(id);
            List<SelectListItem> deger1 = (from i in db.TBLBOLUM.ToList()
                                           select new SelectListItem
                                           {
                                               Text = i.BOLUMU,
                                               Value = i.İD.ToString()
                                           }).ToList();
            ViewBag.dgr1 = deger1;
            return View("OgrenciGetir", veriler);

        }
        public ActionResult Guncelle(TBLOGRENCİ p)
        {
            var veriler = db.TBLOGRENCİ.Find(p.İD);
            veriler.AD = p.AD;
            veriler.SOYAD = p.SOYAD;
            veriler.SINIFI = p.SINIFI;
            veriler.CİNSİYETİ = p.CİNSİYETİ;
            veriler.ADRES = p.CİNSİYETİ;
            veriler.POSTAKOD = p.POSTAKOD;
            veriler.SEMT = p.SEMT;
            veriler.SEHİR = p.SEHİR;
            veriler.TELEFON = p.TELEFON;
            veriler.DALI = p.DALI;
           // var ogr = db.TBLBOLUM.Where(k => k.İD == p.TBLBOLUM.İD).FirstOrDefault();
            veriler.BOLUMU = p.BOLUMU;

            db.SaveChanges();
            return RedirectToAction("Index");
            
        }
       

    }
}