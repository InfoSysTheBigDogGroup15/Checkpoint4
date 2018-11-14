using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Rentals()
        {
            ViewBag.Message = "Your Rental page.";

            return View();
        }

        public ActionResult Trumpet()
        {
            return View();
        }

        public ActionResult Trombone()
        {
            return View();
        }

        public ActionResult Tuba()
        {
            return View();
        }

        public ActionResult Clarinet()
        {
            return View();
        }

        public ActionResult Flute()
        {
            return View();
        }

        public ActionResult Saxophone()
        {
            return View();
        }

    }
}