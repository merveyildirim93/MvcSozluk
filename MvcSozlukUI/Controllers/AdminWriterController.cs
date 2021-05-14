using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Entity;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozlukUI.Controllers
{
    public class AdminWriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var writers = writerManager.GetList();
            return View(writers);
        }

        [HttpPost]
        public ActionResult AddWriter(Writer writer)
        {
            WriterValidator writerValidator = new WriterValidator();
            ValidationResult validationResult = writerValidator.Validate(writer);
            if (validationResult.IsValid)
            {
                writerManager.WriterAdd(writer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult DeleteWriter(int id)
        {
            var writer = writerManager.GetById(id);
            writerManager.WriterDelete(writer);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult updateWriter(int id)
        {
            var writerValue = writerManager.GetById(id);
            return View(writerValue);
        }

        [HttpPost]
        public ActionResult UpdateWriter(Writer writer)
        {
            writerManager.WriterUpdate(writer);
            return RedirectToAction("Index");
        }
    }
}