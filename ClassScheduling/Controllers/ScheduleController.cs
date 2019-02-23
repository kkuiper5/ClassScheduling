using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassScheduling.Controllers
{
    public class ScheduleController : Controller
    {
        public ActionResult ViewSchedule()
        {
            return View("~/Views/Student/View.cshtml");
        }

        public ActionResult AddDrop()
        {
            return View("~/Views/Student/AddDrop.cshtml");
        }

        public ActionResult Builder()
        {
            return View("~/Views/Student/Builder.cshtml");
        }

        public ActionResult Lookup()
        {
            return View("~/Views/Student/Lookup.cshtml");
        }
    }
}
