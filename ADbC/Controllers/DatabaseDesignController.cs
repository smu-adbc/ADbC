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
            ERNotationModelDataContext ERdc = new ERNotationModelDataContext();
            ERdc.ObjectTrackingEnabled = false;

            ERdc.module = ERdc.SelectModuleByName("ER Notation").ToList().First();
            ERdc.sections = ERdc.SelectModuleIntroSectionsByModuleID(ERdc.keysModules.First().ModuleID).OrderBy(x => x.SectionOrder).ToList();
            ERdc.contents = ERdc.SelectModuleIntroContentByModuleID(ERdc.keysModules.First().ModuleID).OrderBy(x => x.ContentOrder).ToList();

            ERdc.NotationList = ERdc.SelectERNotations().ToList();
            ERdc.RelationshipList = ERdc.SelectERRelationships().ToList();

            return View(ERdc);
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
    }
}