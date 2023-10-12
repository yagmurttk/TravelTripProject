using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        public ActionResult Index()
        {
            // var bloglar = c.Blogs.ToList();
            by.Deger1 = c.Blogs.ToList();
            by.Deger3 = c.Blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }
        
        public ActionResult BlogDetay(int id)
        {
            // var blogbul = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.Blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.Yorumlars.Where(x => x.BlogID == id).ToList();
            return View(by);
        }
    }
}