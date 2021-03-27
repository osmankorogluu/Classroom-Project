using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDERSHANE.Models.Entitiy;
using System.Web.Security;

namespace MVCDERSHANE.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        DbMvcDershaneEntities1 db = new DbMvcDershaneEntities1();
        public ActionResult Giris()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Giris(TBLADMİN t)
        {
            var bilgiler = db.TBLADMİN.FirstOrDefault(x => x.kulanici == t.kulanici && x.sifre == t.sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.kulanici, false);
                return RedirectToAction("Index", "Veli");
            }
            else
            {
                return View();
            }
           
        }
    }
}
