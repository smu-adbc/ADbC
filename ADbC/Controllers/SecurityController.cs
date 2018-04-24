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
                MBdc.GenerateBaseElements("Access Control");

                return View(MBdc);
            }
        }

        public ActionResult SecurityMatrix()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Security Matrix");

                return View(MBdc);
            }
        }

        public ActionResult RowLevelSecurity()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Row Level Security");

                return View(MBdc);
            }
        }

        public ActionResult SQLInjection()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("SQL Injection");

                return View(MBdc);
            }
        }

        public ActionResult DatabaseInference()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Database Inference");

                return View(MBdc);
            }
        }

        public ActionResult DatabaseAuditing()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Database Auditing");

                return View(MBdc);
            }
        }
    }
}