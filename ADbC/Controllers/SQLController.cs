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
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Interactive SQL").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult SQLPseudocode()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("SQL Pseudocode").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult EmbeddedSQL()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;
                               
                MBdc.module = MBdc.SelectModuleByName("Embedded SQL").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult SP_Triggers()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Stored Procedures and Triggers").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult ReferentialIntegrity()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Referential Integrity").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }
    }
}