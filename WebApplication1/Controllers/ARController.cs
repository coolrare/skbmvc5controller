using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ARController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewResultTest1()
        {
            return View();
        }
        public ActionResult ViewResultTest2()
        {
            return View("ViewResultTest1");
        }
        public ActionResult ViewResultTest3()
        {
            var data = new ViewResultTestModel();

            return View("ViewResultTest1", data);
        }
        public ActionResult ViewResultTest4()
        {
            return View();
        }

        public ActionResult PartialViewResultTest1()
        {
            return PartialView();
        }
        public ActionResult PartialViewResultTest2()
        {
            return PartialView("ViewResultTest1");
        }
        public ActionResult PartialViewResultTest3()
        {
            var data = new ViewResultTestModel();

            return PartialView("ViewResultTest1", data);
        }
        public ActionResult PartialViewResultTest4()
        {
            return PartialView();
        }

    }
}
