using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PlumRain.Areas.ThreeLearn.Controllers
{
    public class ThreeController : Controller
    {
        //
        // GET: /ThreeLearn/Home/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cube()
        {
            return View();
        }
	}
}