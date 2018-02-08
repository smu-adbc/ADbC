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