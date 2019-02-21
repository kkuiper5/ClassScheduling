using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassScheduling.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index()
        {
            //return "This is Index action method of StudentController";
            return View("~/Views/Home/Index.cshtml");
        }
    }
}
