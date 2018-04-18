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
                ERdc.sections = ERdc.SelectModuleIntroSectionsByModuleID(ERdc.Modules.First().ModuleID).OrderBy(x => x.SectionOrder).ToList();
                ERdc.contents = ERdc.SelectModuleIntroContentByModuleID(ERdc.Modules.First().ModuleID).OrderBy(x => x.ContentOrder).ToList();

                ERdc.NotationList = ERdc.SelectERNotations().ToList();
                ERdc.RelationshipList = ERdc.SelectERRelationships().ToList();

                return View(ERdc);
            }                
        }

        public ActionResult ScenarioToER()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                MCdc.MenuQuestions = MCdc.SelectMCQuestionsByModuleName("Scenario To ER").OrderBy(x => x.MCQuestionID).ToList();

                MCdc.module = MCdc.SelectModuleByName("Scenario To ER").ToList().First();
                MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MCdc);
            }            
        }

        public PartialViewResult GetERMultipleChoiceQuestion(string shortDescription)
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.Question = MCdc.SelectMCQuestionByDescShort(shortDescription).ToList().First();
                MCdc.Answers = MCdc.SelectMCAnswersByQuestionID(MCdc.Question.MCQuestionID).ToList();

                return PartialView("/Views/DatabaseDesign/ERMultipleChoicePartialView.cshtml", MCdc);
            }
        }

        public PartialViewResult GetTextualMultipleChoiceQuestion(string shortDescription)
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.Question = MCdc.SelectMCQuestionByDescShort(shortDescription).ToList().First();
                MCdc.Answers = MCdc.SelectMCAnswersByQuestionID(MCdc.Question.MCQuestionID).ToList();

                return PartialView("/Views/DatabaseDesign/TextualMultipleChoicePartialView.cshtml", MCdc);
            }
        }

        [ChildActionOnly]
        public PartialViewResult MultipleChoiceResultModal(string descShort, int relativeAnswerID)
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                MCdc.Question = MCdc.SelectMCQuestionByDescShort(descShort).ToList().First();
                MCAnswer answer = MCdc.SelectMCAnswersByQuestionID(MCdc.Question.MCQuestionID).ToList().Where(x => x.RelativeAnswerID == relativeAnswerID).First();

                return PartialView("/Views/DatabaseDesign/MultipleChoiceResultModal", answer);
            }
        }

        public ActionResult ERToTables()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                MCdc.MenuQuestions = MCdc.SelectMCQuestionsByModuleName("ER to Tables").OrderBy(x => x.MCQuestionID).ToList();

                MCdc.module = MCdc.SelectModuleByName("ER to Tables").ToList().First();
                MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MCdc);
            }
        }

        public ActionResult FunctionalDependencies()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                //MCdc.MenuQuestions = MCdc.SelectMCQuestionsByModuleName("Functional Dependencies").OrderBy(x => x.MCQuestionID).ToList();

                MCdc.module = MCdc.SelectModuleByName("Functional Dependencies").ToList().First();
                MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MCdc);
            }
        }

        public ActionResult Normalization()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                //MCdc.MenuQuestions = MCdc.SelectMCQuestionsByModuleName("Normalization").OrderBy(x => x.MCQuestionID).ToList();

                MCdc.module = MCdc.SelectModuleByName("Normalization").ToList().First();
                MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MCdc);
            }
        }

        public ActionResult Denormalization()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                //MCdc.MenuQuestions = MCdc.SelectMCQuestionsByModuleName("Denormalization").OrderBy(x => x.MCQuestionID).ToList();

                MCdc.module = MCdc.SelectModuleByName("Denormalization").ToList().First();
                MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MCdc);
            }
        }

        public ActionResult Anomalies()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.ObjectTrackingEnabled = false;

                //MCdc.MenuQuestions = MCdc.SelectMCQuestionsByModuleName("Anomalies").OrderBy(x => x.MCQuestionID).ToList();

                MCdc.module = MCdc.SelectModuleByName("Anomalies").ToList().First();
                MCdc.sections = MCdc.SelectModuleIntroSectionsByModuleID(MCdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MCdc.contents = MCdc.SelectModuleIntroContentByModuleID(MCdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MCdc);
            }
        }
    }
}