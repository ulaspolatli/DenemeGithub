using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DenemeProject.Controllers
{
    public class BranchController : Controller
    {
        // GET: Branch
        public ActionResult Index()
        {
            ViewBag.Message = "Bu controller Dev1 adlı Branch'te (Yedekte) oluşturuldu";
            return View();
        }
    }
}