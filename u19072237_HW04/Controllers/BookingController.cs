using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u19072237_HW04.Models;


namespace u19072237_HW04.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {

            List<MakeBooking> listofBookings = new List<MakeBooking>();

            listofBookings.Add(new MakeBooking("Vision Shilkwambane", new DateTime(2022, 8, 31, 3, 15, 0), "Collect Medicine"));
            listofBookings.Add(new MakeBooking("Enock Asss", new DateTime(2022, 9, 01, 1, 15, 0), "Collect Medicine"));
            listofBookings.Add(new MakeBooking("Papi Andish", new DateTime(2022, 9, 06, 2, 30, 0), "HIV testing"));
            listofBookings.Add(new MakeBooking("Naruto Uzumaki", new DateTime(2022, 9, 10, 11, 00, 0), "HIV testing"));

            return View("Index", listofBookings);
  
        }

        public ActionResult Create()
        {
            return View("listOfBookingsForm");
        }


        public ActionResult ProcessCreate(MakeBooking makeBooking)
        {

            return View("Details", makeBooking);
        }



    }
}