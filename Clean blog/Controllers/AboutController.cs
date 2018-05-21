using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clean_blog.Models;

namespace Clean_blog.Controllers
{
    public class AboutController : Controller
    {
        BlogsEntities2 db = new BlogsEntities2();
        // GET: About
        public ActionResult Index()
        {
            ViewBag.About_header = db.Headers.First(f=>f.Page=="About");
            ViewBag.About_text = db.Abouts.ToList();
            return View();
        }
    }
}