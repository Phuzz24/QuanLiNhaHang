using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
       public ActionResult TrangChu()
        {
            return View();
        }
        public ActionResult Menu()
        {
            return View();

        }
        public ActionResult AboutUs() 
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
    }
}