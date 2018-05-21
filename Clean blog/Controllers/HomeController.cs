using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clean_blog.Models;

namespace Clean_blog.Controllers
{
    public class HomeController : Controller
    {
        BlogsEntities2 db = new BlogsEntities2();
        public ActionResult Index()
        {
            ViewBag.Home_header = db.Headers.First(f => f.Page == "Home");
            ViewBag.Home_text = db.Homes.ToList();
            return View();
        }

        
    }
}