using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADbC.Controllers
{
    public class SecurityController : Controller
    {
        public ActionResult AccessControl()
        {
            return View();
        }

        public ActionResult SecurityMatrix()
        {
            return View();
        }

        public ActionResult RowLevelSecurity()
        {
            return View();
        }

        public ActionResult SQLInjection()
        {
            return View();
        }

        public ActionResult DatabaseInference()
        {
            return View();
        }

        public ActionResult DatabaseAuditing()
        {
            return View();
        }
    }
}