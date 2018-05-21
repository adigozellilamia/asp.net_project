using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clean_blog.Models;

namespace Clean_blog.Controllers
{
    public class ContactController : Controller
    {
        BlogsEntities2 db = new BlogsEntities2();
        // GET: Contact
        public ActionResult Index()
        {
            ViewBag.Contact_header = db.Headers.First(f => f.Page == "Contact");
          
            return View();
        }
    }
}