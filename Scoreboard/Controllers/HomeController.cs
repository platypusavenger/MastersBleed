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

            return RedirectToAction("BritishOpen_2014", "Home");
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

    }
}