using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;

namespace MVCBlog.Controllers
{
    using MVCBlog.Models;

    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            var posts = db.Posts.Include(p => p.Author).OrderByDescending(p => p.Date).Take(3);

            return View(posts.ToList());
        }

    }
}