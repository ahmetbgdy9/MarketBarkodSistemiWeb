using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketBarkodApp.Models.Siniflar;

namespace MarketBarkodApp.Controllers
{
    //buraya çalış
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.kategoris.ToList();
            return View(degerler);
        }
        //ActionResult, Controller yapısına gelen isteklere göre işlem yapıp kullanıcıya View ile isteğe göre bilgileri geri döndüren metotlara verilen isimdir.
        [HttpGet]
        public ActionResult KategoriEkle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult KategoriEkle(Kategori k)
        {
            c.kategoris.Add(k);
            c.SaveChanges();
            return RedirectToAction("Index");
        } 

        public ActionResult KategoriSil(int id)
        {
            var ktg = c.kategoris.Find(id);
            c.kategoris.Remove(ktg);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult KategoriGetir(int id)
        {
            var kategori = c.kategoris.Find(id);
            return View("KategoriGetir", kategori); 
        }

        public ActionResult KategoriGuncelle(Kategori k)
        {
            var ktgr = c.kategoris.Find(k.KategoriID);
            ktgr.KategoriAd = k.KategoriAd;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}