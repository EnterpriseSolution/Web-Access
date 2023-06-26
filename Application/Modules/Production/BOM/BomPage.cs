#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BomPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Production/Bom"), Route("{action=index}")]    
    public class BomController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Production/Bom/BomIndex.cshtml");
        }
    }
}