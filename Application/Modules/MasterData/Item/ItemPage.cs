#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MasterData/Item"), Route("{action=index}")]    
    public class ItemController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/Item/ItemIndex.cshtml");
        }

        public ActionResult Approval()
        {
            return View("~/Modules/Administration/Approval/ItemApprovalndex.cshtml");
        }
    }
}