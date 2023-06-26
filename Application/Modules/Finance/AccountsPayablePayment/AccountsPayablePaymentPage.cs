﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayablePaymentPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Finance/AccountsPayablePayment"), Route("{action=index}")]    
    public class AccountsPayablePaymentController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Finance/AccountsPayablePayment/AccountsPayablePaymentIndex.cshtml");
        }
    }
}