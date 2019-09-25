using CleanseBlog.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanseBlog.Controllers
{
    public class YazarController : Controller
    {
        // GET: Yazar
        DataContext con = new DataContext();

        public ActionResult Index(int id)
        {
            return View(id);
        }
        public ActionResult MakaleListele(int id)
        {
            var makale = con.Makales.Where(a => a.yazarId == id).ToList();

            return View("MakaleListeleWİdget",makale); 
        }
    }
}