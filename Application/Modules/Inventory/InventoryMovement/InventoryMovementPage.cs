#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementPage.cs
// Date: 2018/04/03 20:51

#endregion

using Microsoft.Enums;

/*
Be careful if your model type is String because the second parameter of View(string, string) is masterName, not model.You may need to call the overload with object(model) as the second paramater:
Not correct :

protected ActionResult ShowMessageResult(string msg)
{
return View("Message", msg);
}
Correct :

protected ActionResult ShowMessageResult(string msg)
{
return View("Message", (object)msg);
}
OR(provided by bradlis7):

protected ActionResult ShowMessageResult(string msg)
{
return View("Message", model: msg);
}
*/

namespace Matrix.Inventory.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Inventory/InventoryMovement"), Route("{action=issue}")]    
    public class InventoryMovementController : Controller
    {
        //public ActionResult Index()
        //{
        //    return View("~/Modules/Inventory/InventoryMovement/InventoryMovementIndex.cshtml");
        //}
        
        public ActionResult Issue()
        {
            string flowType = StringEnum<InventoryFlowType>.GetStringValue(InventoryFlowType.Issue);
            return View("~/Modules/Inventory/InventoryMovement/InventoryMovementIndex.cshtml",model:flowType);
        }
        
        public ActionResult Receipt()
        {
            string flowType = StringEnum<InventoryFlowType>.GetStringValue(InventoryFlowType.Receipt);
            return View("~/Modules/Inventory/InventoryMovement/InventoryMovementIndex.cshtml", model: flowType);
        }
        
        public ActionResult Transfer()
        {
            string flowType = StringEnum<InventoryFlowType>.GetStringValue(InventoryFlowType.Transfer);
            return View("~/Modules/Inventory/InventoryMovement/InventoryMovementIndex.cshtml", model: flowType);
        }

        public ActionResult Adjustment()
        {
            string flowType = StringEnum<InventoryFlowType>.GetStringValue(InventoryFlowType.Adjustment);
            return View("~/Modules/Inventory/InventoryMovement/InventoryMovementIndex.cshtml", model: flowType);
        }
    }
}