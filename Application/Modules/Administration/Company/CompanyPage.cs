#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanyPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Administration/Company"), Route("{action=index}")]    
    public class CompanyController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Administration/Company/CompanyIndex.cshtml");
        }
    }
}