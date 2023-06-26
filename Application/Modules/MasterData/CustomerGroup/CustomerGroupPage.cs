#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CustomerGroupPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MasterData/CustomerGroup"), Route("{action=index}")]
    public class CustomerGroupController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/CustomerGroup/CustomerGroupIndex.cshtml");
        }
    }
}