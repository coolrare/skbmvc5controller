using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
    }
}