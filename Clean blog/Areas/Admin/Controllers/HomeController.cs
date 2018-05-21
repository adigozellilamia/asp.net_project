﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Clean_blog.Models;
using System.Web.Helpers;

namespace Clean_blog.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        BlogsEntities2 db = new BlogsEntities2();
        // GET: Admin/Home
        public ActionResult Index()
        {
            string Password = Crypto.HashPassword("123321");
            return View();

        }
        [HttpPost]
        public ActionResult Login(User usr)
        {
            User loginned = db.Users.FirstOrDefault(u => u.Email == usr.Email);
            if(loginned!=null)
            {
                if (Crypto.VerifyHashedPassword( loginned.Password,usr.Password))
                {
                    Session["Loginned"] = true;
                    Session["user_id"] = loginned.id;
                    return RedirectToAction("index", "dashboard");
                }
            }
            Session["Login_invalid"] = true;
            return RedirectToAction("index");
        }
    }
}