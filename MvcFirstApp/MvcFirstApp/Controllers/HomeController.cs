using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
           return View();
           
        }

        public string MyController()
        {
            return "Home Controller";
        }

        public ActionResult MyView()
        {
            return View();
        }
    }
}