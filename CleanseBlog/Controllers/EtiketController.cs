using CleanseBlog.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanseBlog.Controllers
{
    public class EtiketController : Controller
    {
        // GET: Etiket
        DataContext con = new DataContext();
        public ActionResult Index(int id)
        {
            return View(id);
        }
        public ActionResult MakaleListeleWİdget(int id)
        {
            var makale = con.Makales.Where(m=>m.Etikets.Any(y=>y.id==id)).ToList();
          
            return View("MakaleListeleWİdget",makale);
        }
    }
}