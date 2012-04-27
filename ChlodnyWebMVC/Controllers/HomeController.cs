using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChlodnyWebMVC.Controllers
{
    using System.Json;
    using System.Net.Http;
    using System.Net.Http.Headers;

    using DataAccess.Entities;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           ViewBag.Message = "Your quintessential app Home page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your quintessential app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
