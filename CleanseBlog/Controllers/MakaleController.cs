using CleanseBlog.Models;
using CleanseBlog.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanseBlog.Controllers
{
    public class MakaleController : Controller
    {
        // GET: Makale
        DataContext con = new DataContext();
        public ActionResult Index(int id)
        {
            return View(id);
        }
        public ActionResult Detay(int id)
        {
            var detay = con.Makales.Where(a=>a.id==id).FirstOrDefault();
            return View(detay);
        }
        public ActionResult TariheGoreListe(int yil , int ay)
        {
            return View();
        }
        public ActionResult MakeleListele(int yil, int ay)
        {
            var makale = con.Makales.Where(x => x.yayinTarihi.Year == yil && x.yayinTarihi.Month == ay);
            return View("MakaleListeleWİdget", makale);
        }
        public ActionResult MakaleYaz()
        {
            ViewBag.cat = con.Kategoris.ToList();

            return View();
        }
        [HttpPost]
        public ActionResult MakaleYaz(Makale mak,string etiketler)
        {
            
            if (mak != null)
            {
                mak.yazarId = 4;
                mak.yayinTarihi = DateTime.Now;
                mak.resimId = 1;
                con.Makales.Add(mak);
                con.SaveChanges();
                
            }
            string[] etikets = etiketler.Split(',');

            foreach (var tag in etikets)
            {
                Etiket etk = con.Etikets.FirstOrDefault(a => a.adi.ToLower() == tag.ToLower().Trim());

                if (etk==null)
                {

                    etk= new Etiket();
                    etk.adi = tag;
                    con.Etikets.Add(etk);
                    con.SaveChanges();
                }
                mak.Etikets.Add(etk);
                con.SaveChanges();
            }
            return View();
        }

      
    }
}
