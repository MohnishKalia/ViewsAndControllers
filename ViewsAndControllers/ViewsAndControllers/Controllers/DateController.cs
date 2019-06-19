using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class DateController : Controller
    {
        // GET: Date
         public ActionResult Index()
        {
            return View(viewName: "Index", model: DateTime.Now.ToString("d"));
        }
        [HttpPost]
        public ActionResult DateData(DateTime inputDate)
        {
            return View(viewName: "Index", model: inputDate.ToString("d"));
        }
    }
}