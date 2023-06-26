#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableJournalPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Finance/AccountsPayableJournal"), Route("{action=index}")]    
    public class AccountsPayableJournalController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Finance/AccountsPayableJournal/AccountsPayableJournalIndex.cshtml");
        }
    }
}