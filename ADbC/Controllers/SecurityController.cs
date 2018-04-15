using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADbC.Models;

namespace ADbC.Controllers
{
    public class SecurityController : Controller
    {
        public ActionResult AccessControl()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Access Control").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult SecurityMatrix()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Security Matrix").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult RowLevelSecurity()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Row Level Security").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult SQLInjection()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("SQL Injection").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult DatabaseInference()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Database Inference").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult DatabaseAuditing()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Database Auditing").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }
    }
}