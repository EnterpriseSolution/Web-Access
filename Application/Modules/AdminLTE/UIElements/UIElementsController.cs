#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UIElementsController.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.AdminLTE
{
    using System.Web.Mvc;

    [Authorize, RoutePrefix("AdminLTE/UIElements"), Route("{action=index}")]
    public class UIElementsController : Controller
    {
        public ActionResult Buttons()
        {
            return View(MVC.Views.AdminLTE.UIElements.Buttons);
        }

        public ActionResult General()
        {
            return View(MVC.Views.AdminLTE.UIElements.General);
        }

        public ActionResult Icons()
        {
            return View(MVC.Views.AdminLTE.UIElements.Icons);
        }

        public ActionResult Modals()
        {
            return View(MVC.Views.AdminLTE.UIElements.Modals);
        }

        public ActionResult Sliders()
        {
            return View(MVC.Views.AdminLTE.UIElements.Sliders);
        }

        public ActionResult Timeline()
        {
            return View(MVC.Views.AdminLTE.UIElements.Timeline);
        }
    }
}