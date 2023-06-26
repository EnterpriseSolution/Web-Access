#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ChartsController.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.AdminLTE
{
    using System.Web.Mvc;

    [Authorize, RoutePrefix("AdminLTE/Charts"), Route("{action=index}")]
    public class ChartsController : Controller
    {
        public ActionResult ChartJS()
        {
            return View(MVC.Views.AdminLTE.Charts.ChartJS);
        }

        public ActionResult Flot()
        {
            return View(MVC.Views.AdminLTE.Charts.Flot);
        }

        public ActionResult InlineCharts()
        {
            return View(MVC.Views.AdminLTE.Charts.InlineCharts);
        }

        public ActionResult Morris()
        {
            return View(MVC.Views.AdminLTE.Charts.Morris);
        }
    }
}