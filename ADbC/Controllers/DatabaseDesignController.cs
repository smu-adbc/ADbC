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
            ERMultipleChoiceModelDataContext MCdc = new ERMultipleChoiceModelDataContext();
            MCdc.ObjectTrackingEnabled = false;

            MCdc.module = MCdc.SelectModuleByName("Scenario To ER").ToList().First();
            MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
            MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

            MCdc.Question = MCdc.SelectERQuestionByDescShort("employees").ToList().First();
            MCdc.Answers = MCdc.SelectERAnswersByQuestionID(MCdc.Question.ERQuestionID).ToList();

            return View(MCdc);
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