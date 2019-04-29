using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NpvWebApplication.Controllers
{
    public class HomeController : Controller
    {        
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult NpvCalculator()
        {
            return View();
        }
    }
}