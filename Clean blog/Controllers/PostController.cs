using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clean_blog.Models;

namespace Clean_blog.Controllers
{
    public class PostController : Controller
    {
        BlogsEntities2 db = new BlogsEntities2();
        // GET: Post
        public ActionResult Index()
        {
            ViewBag.Post_header = db.Headers.First(f => f.Page == "Post");
            ViewBag.Post_text = db.Posts.ToList();
            return View();
        }
    }
}