#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobOrderPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Production/JobOrder"), Route("{action=index}")]    
    public class JobOrderController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Production/JobOrder/JobOrderIndex.cshtml");
        }
    }
}