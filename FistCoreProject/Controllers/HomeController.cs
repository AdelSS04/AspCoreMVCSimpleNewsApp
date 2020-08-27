using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FistCoreProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace FistCoreProject.Controllers
{
    public class HomeController : Controller
    {

        DBContext db;

        public HomeController (DBContext bContext)
        {
            db = bContext;


        }
        public IActionResult Index()
        {
           var ListOfCategories = db.Categories.ToList();
            return View(ListOfCategories);
        }
        public IActionResult Messages()
        {
          

            return View( db.ContactUs.ToList());
        }
        public IActionResult Contact()
        {
            
            return View();
        }
        [Authorize]
        public IActionResult News(int id)
        {
            Category c = db.Categories.Find(id);
            ViewBag.cat = c.Name;
                var ListNews= db.News.Where(x => x.CategoryId==id).OrderByDescending(x=>x.Date).ToList();
            return View(ListNews);
        }
       
        public IActionResult DeleteNews(int id)
        {
            var news = db.News.Find(id);
            db.News.Remove(news);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SendContact(ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                db.ContactUs.Add(contactUs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("contact",contactUs);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
