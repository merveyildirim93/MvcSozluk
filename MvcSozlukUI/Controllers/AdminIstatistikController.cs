using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSozlukUI.Controllers
{
    public class AdminIstatistikController : Controller
    {
        Context context = new Context();
        // GET: AdminIstatistik
        public ActionResult Index()
        {
            var toplamKategori = context.Categories.Count().ToString();
            ViewBag.ToplamKategori = toplamKategori;

            var yazilimBasliklari = context.Headings.Count(x => x.CategoryId == 8).ToString();
            ViewBag.YazilimBasliklari = yazilimBasliklari;

            var icindeAHarfiOlanYazarlar = context.Writers
                .Where(x => x.WriterName.Contains("a"))
                .Count();
            ViewBag.IcindeAHarfiOlanYazarlar = icindeAHarfiOlanYazarlar;

            var enConBasligaSahipKategori = context.Headings.GroupBy(x => x.Category.CategoryName).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault();
            ViewBag.EnConBasligaSahipKategori = enConBasligaSahipKategori;

            var kategoriTrue = context.Categories.Count(x => x.CategoryStatus == true);
            var kategoriFalse = context.Categories.Count(x => x.CategoryStatus == false);
            var trueFalse = kategoriTrue - kategoriFalse;
            ViewBag.TrueFalse = trueFalse;

            return View();
        }
    }
}