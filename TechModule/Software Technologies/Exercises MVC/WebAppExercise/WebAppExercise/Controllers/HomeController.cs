using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<string> items = (List<string>)this.Session["item"] ?? new List<string>();
            return View(items);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AddItem(string newItem)
        {
            List<string> items = (List<string>)this.Session["item"] ?? new List<string>();
            items.Add(newItem);
            this.Session["item"] = items;
            return this.RedirectToAction("Index");
        }

        public ActionResult RemoveItem(int index)
        {
            List<string> items = (List<string>)this.Session["item"];

            if (items != null && index < items.Count)
            {
                items.RemoveAt(index);
                this.Session["Items"] = items;
            }

            return this.RedirectToAction("Index");
        }
    }
}