using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDERSHANE.Models.Entitiy;

namespace MVCDERSHANE.Controllers
{
    public class İletişimController : Controller
    {
        // GET: İletişim
        DbMvcDershaneEntities1 db = new DbMvcDershaneEntities1();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult İletisimEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult İletisimEkle(TBLİLETİSİM P)
        {
            db.TBLİLETİSİM.Add(P);
            return View();
        }
    }
}