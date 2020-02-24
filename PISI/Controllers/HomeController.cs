using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PISI.Controllers
{
    public class HomeController : Controller
    {
        PISIEntities db = new PISIEntities();
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
        [HttpPost]
        public ActionResult Search(FormCollection form)
        {
            string keyword = form["keyword"];
            var listWord = (from w in db.WORDs
                            where ((w.Word_English.ToLower().Contains(keyword.ToLower())) || (w.Word_Vietnamese.ToLower().Contains(keyword.ToLower())))
                            select w).ToList();
            return View("SearchResult", listWord);
        }
    }
}