#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemLotSerialPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventory/ItemLotSerial"), Route("{action=index}")]    
    public class ItemLotSerialController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Inventory/Serial/ItemLotSerialIndex.cshtml");
        }
    }
}