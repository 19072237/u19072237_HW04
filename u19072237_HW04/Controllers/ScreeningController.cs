using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19072237_HW04.Models;

namespace u19072237_HW04.Controllers
{
    public class ScreeningController : Controller
    {
        // GET: Screening
        public ActionResult Index()
        {

            List<CovidScreening> listOfScreenings = new List<CovidScreening>();
            listOfScreenings.Add(new CovidScreening(true, false, false));
            listOfScreenings.Add(new CovidScreening(false, false,false));
            listOfScreenings.Add(new CovidScreening(false, false, false));
            listOfScreenings.Add(new CovidScreening(false, true, true));

            return View("Index", listOfScreenings);
            
        }

        public ActionResult Create()
        {
            return View("ScreeningForm");
        }


        public ActionResult ProcessCreate(CovidScreening covidScreening)
        {
            return View("Details", covidScreening);
        }

    }
}