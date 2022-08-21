using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19072237_HW04.Models;

namespace u19072237_HW04.Controllers
{
    public class PatientController : Controller
    {



        // GET: Patient
        public ActionResult Index()
        {

            List<HIVpatient> hivpatients = new List<HIVpatient>();
            hivpatients.Add(new HIVpatient(1, "Vision Shikwambane", "M", 19, true, 120));
            hivpatients.Add(new HIVpatient(2, "Tintswalo Shikwambane", "F", 12, false, 400));

            return View("Index", hivpatients);
        }


        public ActionResult Create()
        {
            return View("hivPatientForm");
        }


        public ActionResult ProcessCreate(HIVpatient  hivpatient)
        {

            
            return View("Details", hivpatient);
        }


    }
}