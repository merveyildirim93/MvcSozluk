using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozlukUI.Controllers
{
    public class AdminAboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public ActionResult Index()
        {
            var abouts = aboutManager.GetList();
            return View(abouts);
        }

        public PartialViewResult aboutAdd()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult AboutAdd(About about)
        {
            aboutManager.AboutAdd(about);
            return RedirectToAction("Index");
        }
    }
}