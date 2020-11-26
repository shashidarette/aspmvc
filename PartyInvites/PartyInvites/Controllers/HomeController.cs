using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int currentHour = DateTime.Now.Hour;

            ViewBag.Greeting = currentHour > 12 ? "Good Afternoon" : "Good morning";

            return View();
        }
    }
}