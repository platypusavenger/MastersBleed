using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Scoreboard.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Scoreboard()
        {
            ViewBag.Message = "Current Scoreboard";

            return RedirectToAction("PGAChampionship_2017", "Home");
        }

        public ActionResult PGAChampionship_2015()
        {
            ViewBag.Message = "PGA Championship Scoreboard";

            return View();
        }

        public ActionResult PGAChampionship_2017()
        {
            ViewBag.Message = "PGA Championship Scoreboard";

            return View();
        }

        public ActionResult BritishOpen_2015()
        {
            ViewBag.Messsage = "The Open Championship Scoreboard";

            return View();
        }

        public ActionResult BritishOpen_2016()
        {
            ViewBag.Messsage = "The Open Championship Scoreboard";

            return View();
        }


        public ActionResult BritishOpen_2017()
        {
            ViewBag.Messsage = "The Open Championship Scoreboard";

            return View();
        }

        public ActionResult Masters_2017()
        {
            ViewBag.Message = "Master's Scoreboard";

            return View();
        }
        
        public ActionResult Masters_2016()
        {
            ViewBag.Message = "Master's Scoreboard";

            return View();
        }

        public ActionResult Masters_2015()
        {
            ViewBag.Message = "Master's Scoreboard";

            return View();
        }

        public ActionResult Masters_2014()
        {
            ViewBag.Message = "Master's Scoreboard";

            return View();
        }

        public ActionResult USO_2014()
        {
            ViewBag.Messsage = "US Open Scorebaord";

            return View();
        }

        public ActionResult BritishOpen_2014()
        {
            ViewBag.Message = "British Open Scoreboard";

            return View();
        }
        public ActionResult USO_2015()
        {
            ViewBag.Messsage = "US Open Scorebaord";

            return View();
        }

        public ActionResult USO_2016()
        {
            ViewBag.Messsage = "US Open Scorebaord";

            return View();
        }

        public ActionResult USO_2017()
        {
            ViewBag.Messsage = "US Open Scorebaord";

            return View();
        }
        public ActionResult PGAChampionship_2014()
        {
            ViewBag.Message = "PGA Championship Scoreboard";

            return View();
        }
    }
}