#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogFilterColumnDetailPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Administration/LookupDialogFilterColumnDetail"), Route("{action=index}")]    
    public class LookupDialogFilterColumnDetailController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Administration/LookupDialogFilterColumnDetail/LookupDialogFilterColumnDetailIndex.cshtml");
        }
    }
}