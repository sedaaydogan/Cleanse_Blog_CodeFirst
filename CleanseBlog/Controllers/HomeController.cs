using CleanseBlog.Models.DataManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanseBlog.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        DataContext con = new DataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult WidgetCategories()
        {
            var cat = con.Kategoris.ToList();
            return View(cat);
        }
        public ActionResult WidgetPosts()
        {
            ViewBag.populer = con.Makales.OrderByDescending(a => a.begeni);
            ViewBag.fresh = con.Makales.OrderByDescending(a => a.yayinTarihi);

            return View();
        }
        public ActionResult WidgetTag()
        {
            var tag = con.Etikets.ToList();
            return View(tag);
        }
        public ActionResult MakaleListeleWİdget()
        {
            var makale = con.Makales.ToList();
            return View("MakaleListeleWİdget", makale);
            
        }
        public PartialViewResult Search()
        {

            return PartialView();
        }

    }
}