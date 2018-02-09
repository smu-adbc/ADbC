using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADbC.Controllers
{
    public class TransactionsController : Controller
    {
        public ActionResult Concurrency()
        {
            return View();
        }

        public ActionResult Recovery()
        {
            return View();
        }
    }
}