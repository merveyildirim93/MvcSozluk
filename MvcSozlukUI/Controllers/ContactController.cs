using BusinessLayer.Concrete;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozlukUI.Controllers
{
    public class ContactController : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public ActionResult Index()
        {
            var messages = contactManager.GetList();
            return View(messages);
        }
    }
}