using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySozlukWebGit.Infrastructure;

namespace MySozlukWebGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult KeyCreate()
        {
            ViewBag.Message = "Your Key Create page.";

            //if (ModelState.IsValid)
            return View();
        }

        [HttpPost]
        public ActionResult KeyCreate(KeySet key)
        {
            using (CompanyEntities context = new CompanyEntities())
            {
                context.KeySet.Add(key);
                context.SaveChanges();
            }

            return RedirectToAction("Keys");
        }

        public ActionResult Keys()
        {
            ViewBag.Message = "Keys";


            using (CompanyEntities context = new CompanyEntities())
            {
                var keys = context.KeySet.ToList();

                return View(keys);
            }

        }
    }
}