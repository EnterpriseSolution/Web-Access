#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MasterData/Vendor"), Route("{action=index}")]
    public class VendorController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/Vendor/VendorIndex.cshtml",model:"I");
        }

        public ActionResult Approval()
        {
            return View("~/Modules/Administration/Approval/VendorApprovalIndex.cshtml");
        }

        public ActionResult VendorControl()
        {
            ViewData["Title"] = "Vendor Control";
            return View("~/Modules/MasterData/Vendor/VendorIndex.cshtml", model:"C");
        }
    }
}