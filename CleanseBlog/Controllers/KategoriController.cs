using CleanseBlog.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanseBlog.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        DataContext con = new DataContext();

        public ActionResult Index(int id)
        {
            return View(id);
        }
        public ActionResult MakaleListeleWİdget(int id)
        {
            var kategori = con.Makales.Where(a => a.kategoriId == id).ToList();
            return View(kategori);
        }


    }
}