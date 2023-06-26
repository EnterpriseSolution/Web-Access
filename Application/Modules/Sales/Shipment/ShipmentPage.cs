#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ShipmentPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Sales.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Sales/Shipment"), Route("{action=index}")]    
    public class ShipmentController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Sales/Shipment/ShipmentIndex.cshtml");
        }
    }
}