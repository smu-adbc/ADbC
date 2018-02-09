using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADbC.Controllers
{
    public class SQLController : Controller
    {
        public ActionResult InteractiveSQL()
        {
            return View();
        }

        public ActionResult SQLPseudocode()
        {
            return View();
        }

        public ActionResult EmbeddedSQL()
        {
            return View();
        }

        public ActionResult SP_Triggers()
        {
            return View();
        }

        public ActionResult ReferentialIntegrity()
        {
            return View();
        }
    }
}