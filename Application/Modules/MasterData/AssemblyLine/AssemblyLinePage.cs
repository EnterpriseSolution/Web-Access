#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AssemblyLinePage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MasterData/AssemblyLine"), Route("{action=index}")]    
    public class AssemblyLineController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/AssemblyLine/AssemblyLineIndex.cshtml");
        }
    }
}