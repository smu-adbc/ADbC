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
            using (ERNotationModelDataContext ERdc = new ERNotationModelDataContext())
            {
                ERdc.ObjectTrackingEnabled = false;

                ERdc.module = ERdc.SelectModuleByName("ER Notation").ToList().First();
                ERdc.sections = ERdc.SelectModuleIntroSectionsByModuleID(ERdc.keysModules.First().ModuleID).OrderBy(x => x.SectionOrder).ToList();
                ERdc.contents = ERdc.SelectModuleIntroContentByModuleID(ERdc.keysModules.First().ModuleID).OrderBy(x => x.ContentOrder).ToList();

                ERdc.NotationList = ERdc.SelectERNotations().ToList();
                ERdc.RelationshipList = ERdc.SelectERRelationships().ToList();

                return View(ERdc);
            }                
        }

        public ActionResult ScenarioToER()
        {
            using (ERMultipleChoiceModelDataContext MCdc = new ERMultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                MCdc.MenuQuestions = MCdc.SelectERQuestionsByModuleName("Scenario To ER").OrderBy(x => x.ERQuestionID).ToList();

                MCdc.module = MCdc.SelectModuleByName("Scenario To ER").ToList().First();
                MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MCdc);
            }            
        }

        public PartialViewResult GetERMultipleChoiceQuestion(string shortDescription)
        {
            using (ERMultipleChoiceModelDataContext MCdc = new ERMultipleChoiceModelDataContext())
            {
                MCdc.Question = MCdc.SelectERQuestionByDescShort(shortDescription).ToList().First();
                MCdc.Answers = MCdc.SelectERAnswersByQuestionID(MCdc.Question.ERQuestionID).ToList();

                return PartialView("/Views/DatabaseDesign/ERMultipleChoicePartialView.cshtml", MCdc);
            }
        }

        [ChildActionOnly]
        public PartialViewResult ERMultipleChoiceResultModal(string descShort, int relativeAnswerID)
        {
            using (ERMultipleChoiceModelDataContext MCdc = new ERMultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                MCdc.Question = MCdc.SelectERQuestionByDescShort(descShort).ToList().First();
                keysERAnswer answer = MCdc.SelectERAnswersByQuestionID(MCdc.Question.ERQuestionID).ToList().Where(x => x.RelativeAnswerID == relativeAnswerID).First();

                return PartialView("/Views/DatabaseDesign/ERMultipleChoiceResultModal", answer);
            }
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