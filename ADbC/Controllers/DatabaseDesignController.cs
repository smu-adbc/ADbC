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
                ERdc.GenerateBaseElements("ER Notation");
                
                ERdc.NotationList = ERdc.SelectERNotations().ToList();
                ERdc.RelationshipList = ERdc.SelectERRelationships().ToList();

                return View(ERdc);
            }                
        }

        public ActionResult ScenarioToER()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.GenerateBaseElements("Scenario To ER");
                
                return View(MCdc);
            }            
        }
        
        public ActionResult ERToTables()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.GenerateBaseElements("ER to Tables");

                return View(MCdc);
            }
        }

        public ActionResult FunctionalDependencies()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.GenerateBaseElements("Functional Dependencies");
                return View(MCdc);
            }
        }

        public ActionResult Normalization()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.GenerateBaseElements("Normalization");

                return View(MCdc);
            }
        }

        public ActionResult Denormalization()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.GenerateBaseElements("Denormalization");

                return View(MCdc);
            }
        }

        public ActionResult Anomalies()
        {
            using (MultipleChoiceModelDataContext MCdc = new MultipleChoiceModelDataContext())
            {
                MCdc.GenerateBaseElements("Anomalies");

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

                MCdc.module = MCdc.SelectModuleByID(MCdc.Question.ModuleID).First();

                return PartialView("/Views/DatabaseDesign/TextualMultipleChoicePartialView.cshtml", MCdc);
            }
        }

        [ChildActionOnly]
        public PartialViewResult MultipleChoiceResultModal(MCAnswer answer)
        {
            return PartialView("/Views/DatabaseDesign/MultipleChoiceResultModal", answer);
        }
    }
}