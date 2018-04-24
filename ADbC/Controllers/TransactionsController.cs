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
                MBdc.GenerateBaseElements("Concurrency");

                return View(MBdc);
            }
        }

        public ActionResult Recovery()
        {
            using (ModuleBaseModelDataContext MBdc = new ModuleBaseModelDataContext())
            {
                MBdc.GenerateBaseElements("Recovery");

                return View(MBdc);
            }
        }
    }
}