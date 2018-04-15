using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADbC.Models;

namespace ADbC.Controllers
{
    public class TransactionsController : Controller
    {
        public ActionResult Concurrency()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Concurrency").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }

        public ActionResult Recovery()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.ObjectTrackingEnabled = false;

                MBdc.module = MBdc.SelectModuleByName("Recovery").ToList().First();
                MBdc.sections = MBdc.SelectModuleIntroSectionsByModuleID(MBdc.module.ModuleID).OrderBy(x => x.SectionOrder).ToList();
                MBdc.contents = MBdc.SelectModuleIntroContentByModuleID(MBdc.module.ModuleID).OrderBy(x => x.ContentOrder).ToList();

                return View(MBdc);
            }
        }
    }
}