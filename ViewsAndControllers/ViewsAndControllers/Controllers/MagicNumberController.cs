using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewsAndControllers.Controllers
{
    public class MagicNumberController : Controller
    {
        // GET: MagicNumber
        public ActionResult Index()
        {
            return View(viewName: "Index", model: 0);
        }
        [HttpPost]
        public ActionResult MagicNumber(int num1, int num2)
        {
            Random gen = new Random();
            return View(viewName: "Index", model: gen.Next(Math.Min(num1, num2), Math.Max(num1, num2)));
        }
    }
}