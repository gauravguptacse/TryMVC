using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TryMVC.Models;
using TryMVC.Helper;

namespace TryMVC.Controllers
{
    public class RangeController : Controller
    {
        //
        // GET: /Range/RangeIndicator/

        public ActionResult RangeIndicator()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RangeIndicator(RangeModel rangeInfo)
        {
            rangeInfo.indicator = ViewBag.color = ModelHelper.GetRangeIndicator(rangeInfo);

            ViewBag.criticality = ModelHelper.GetRangeCriticality(rangeInfo);
            
            return View(rangeInfo);
        }

    }
}
