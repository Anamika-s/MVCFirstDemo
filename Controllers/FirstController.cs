using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {// Pass some data from controller to view
            // 1. ViewBag
            // 2. ViewData
            // 3. Tempdata
            ViewBag.msg = "Hello";
            return View();
        }
        public ActionResult First()
        {
            ViewData["msg"] = DateTime.Now.ToString();
            return View();
        }
    }
}