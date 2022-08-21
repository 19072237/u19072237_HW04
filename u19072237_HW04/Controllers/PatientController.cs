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





        // HIVpatient Actions
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


        public ActionResult ProcessCreate(HIVpatient hivpatient)
        {


            return View("Details", hivpatient);
        }







        //CoronaVirusPatient Actions
        public ActionResult Index2()
        {
            List<CoronaVirusPatient> coronaVirusPatients = new List<CoronaVirusPatient>();
            coronaVirusPatients.Add(new CoronaVirusPatient(1, "Erick Erickson", "M", 55, false, "Severe"));
            coronaVirusPatients.Add(new CoronaVirusPatient(2, "Swop Fap", "M", 44, true, "Mild"));
            coronaVirusPatients.Add(new CoronaVirusPatient(3, "Pot Cat", "F", 22, true, "Severe"));

            return View("Index2", coronaVirusPatients);
        }

        public ActionResult Create2()
        {
            return View("cvPatientForm");
        }

        public ActionResult ProcessCreate2(CoronaVirusPatient coronaVirusPatient)
        {
            return View("Details2", coronaVirusPatient);

        }


        //Diabetes PatienActions
        public ActionResult Index3()
        {

            List<DiabetesPatient> diabetesPatients = new List<DiabetesPatient>();
            diabetesPatients.Add(new DiabetesPatient(1, "Noko Mashaba", "M", 66, true, 200));
            diabetesPatients.Add(new DiabetesPatient(2, "Andy Sefahla", "F", 18, false, 100));
            diabetesPatients.Add(new DiabetesPatient(3, "Eja Mpsa", "F", 45, true, 77));
            diabetesPatients.Add(new DiabetesPatient(3, "Davido Marala", "M", 76, true, 130));

            return View("Index3", diabetesPatients);
        }


        public ActionResult Create3()
        {
            return View("diabetesPatientForm");
        }


        public ActionResult ProcessCreate3(DiabetesPatient diabetesPatient)
        {
            return View("Details3", diabetesPatient);
        }





    }
}