#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockJournalPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventory/StockJournal"), Route("{action=index}")]    
    public class StockJournalController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/StockJournal/StockJournalIndex.cshtml");
        }
    }
}