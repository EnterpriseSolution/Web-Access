#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Purchasing/VendorQuotation"), Route("{action=index}")]    
    public class VendorQuotationController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Purchasing/VendorQuotation/VendorQuotationIndex.cshtml");
        }
    }
}