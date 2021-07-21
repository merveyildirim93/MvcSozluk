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
    public class AdminHeadingController : Controller
    {
        // GET: AdminHeading
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var heading = headingManager.GetList();
            return View(heading);
        }

        [HttpGet]
        public ActionResult addHeading()
        {
            List<SelectListItem> categoryList = (from x in categoryManager.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.categories = categoryList;

            List<SelectListItem> writerList = (from x in writerManager.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.WriterName,
                                                     Value = x.WriterId.ToString()
                                                 }).ToList();
            ViewBag.writers = writerList;

            return View();
        }

        [HttpPost]
        public ActionResult AddHeading(Heading heading)
        {
                headingManager.HeadingAdd(heading);
                return RedirectToAction("Index");
        }

        public ActionResult updateHeading(int Id)
        {
            List<SelectListItem> categoryList = (from x in categoryManager.GetList()
                                                 select new SelectListItem
                                                 {
                                                     Text = x.CategoryName,
                                                     Value = x.CategoryId.ToString()
                                                 }).ToList();
            ViewBag.categories = categoryList;
            List<SelectListItem> writerList = (from x in writerManager.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.WriterName,
                                                   Value = x.WriterId.ToString()
                                               }).ToList();
            ViewBag.writers = writerList;
            var headingValue = headingManager.GetById(Id);
            return View(headingValue);
        }

        [HttpPost]
        public ActionResult UpdateHeading(Heading heading)
        {
            headingManager.HeadingUpdate(heading);
            return RedirectToAction("Index");
        }

        public ActionResult DeleteHeading(int Id)
        {
            var headingValue = headingManager.GetById(Id);
            headingValue.HeadingStatus = false;
            headingManager.HeadingDelete(headingValue);
            return RedirectToAction("Index");
        }

    }
}