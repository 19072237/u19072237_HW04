using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19072237_HW04.Models;

namespace u19072237_HW04.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }




        
    }
}