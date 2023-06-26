#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockLedgerPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventory/StockLedger"), Route("{action=index}")]    
    public class StockLedgerController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/StockLedger/StockLedgerIndex.cshtml");
        }
    }
}