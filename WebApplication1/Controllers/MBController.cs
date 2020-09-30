using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MBController : Controller
    {
        // GET: MB
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ViewResultTestModel model)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "您輸入的姓名為 " + model.Name;

                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult List()
        {
            var db = new ContosoUniversityEntities();

            var data = db.Course.ToList();

            return View(data);
        }

        [HttpPost]
        public ActionResult List(IList<CourseBatchViewModel> data)
        {
            var db = new ContosoUniversityEntities();

            if (ModelState.IsValid)
            {
                foreach (var item in data)
                {
                    var dbitem = db.Course.Find(item.CourseID);
                    dbitem.Title = item.Title;
                    dbitem.Credits = item.Credits;
                }

                db.SaveChanges();

                //return Json(data);
                return RedirectToAction("List");
            }
            else
            {
                return View(db.Course.ToList());
            }
        }
    }
}