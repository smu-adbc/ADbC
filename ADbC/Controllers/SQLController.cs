using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADbC.Models;

namespace ADbC.Controllers
{
    public class SQLController : Controller
    {
        public ActionResult InteractiveSQL()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Interactive SQL");

                return View(MBdc);
            }
        }

        public ActionResult SQLPseudocode()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("SQL Pseudocode");

                return View(MBdc);
            }
        }

        public ActionResult EmbeddedSQL()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Embedded SQL");

                return View(MBdc);
            }
        }

        public ActionResult SP_Triggers()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Stored Procedures and Triggers");

                return View(MBdc);
            }
        }

        public ActionResult ReferentialIntegrity()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Referential Integrity");

                return View(MBdc);
            }
        }
    }
}