#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ColorPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MasterData/Color"), Route("{action=index}")]    
    public class ColorController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/Color/ColorIndex.cshtml");
        }
    }
}