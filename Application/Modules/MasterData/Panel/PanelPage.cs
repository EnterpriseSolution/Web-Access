#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PanelPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MasterData/Panel"), Route("{action=index}")]    
    public class PanelController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/Panel/PanelIndex.cshtml");
        }
    }
}