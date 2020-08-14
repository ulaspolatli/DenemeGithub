using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenemeProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Proje oluşturuldu ve üzerinde değişiklikler yapıldı.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Proje github klasörüne eklenip github'a ilk commit olarak gönderildi";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Projenin bu kısmında değişiklik yapıldı ve githuba commit edildi (ikinci commit)";

            return View();
        }
    }
}