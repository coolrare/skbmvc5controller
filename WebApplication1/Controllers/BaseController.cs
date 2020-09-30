using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public abstract class BaseController : Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            if (ControllerContext.HttpContext.Request.HttpMethod.ToUpper() == "GET")
            {
                Redirect("/").ExecuteResult(ControllerContext);
            }
            else
            {
                base.HandleUnknownAction(actionName);
            }
        }
    }
}