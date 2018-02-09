using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADbC.Models;

namespace ADbC.Controllers
{
    public class DatabaseDesignController : Controller
    {
        public ActionResult ERNotation()
        {            
            return View();
        }

        public ActionResult ScenarioToER()
        {
            return View();
        }

        public ActionResult ERToTables()
        {
            return View();
        }

        public ActionResult FunctionalDependencies()
        {
            return View();
        }

        public ActionResult Normalization()
        {
            return View();
        }

        public ActionResult Denormalization()
        {
            return View();
        }

        public ActionResult Anomalies()
        {
            return View();
        }

        public ActionResult ShowERNotationOutput(int rel, int not)
        {
            ERNotationModel model;

            //normally here we'd get the database data and pass
            //these in to select from that list, but it's all
            //hard coded for now, just testing
            if (rel > 0 && not > 0)
            {
                model = new ERNotationModel(rel, not);
                return PartialView("ERNotationOutputPartial", model);
            }
            else
            {
                return null;
            }
        }
    }
}