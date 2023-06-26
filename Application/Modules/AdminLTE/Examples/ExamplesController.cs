#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ExamplesController.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.AdminLTE
{
    using System.Web.Mvc;

    [Authorize, RoutePrefix("AdminLTE/Examples"), Route("{action=index}")]
    public class ExamplesController : Controller
    {
        public ActionResult BlankPage()
        {
            return View(MVC.Views.AdminLTE.Examples.BlankPage);
        }

        public ActionResult Error404()
        {
            return View(MVC.Views.AdminLTE.Examples.Error404);
        }

        public ActionResult Error500()
        {
            return View(MVC.Views.AdminLTE.Examples.Error500);
        }

        public ActionResult Invoice()
        {
            return View(MVC.Views.AdminLTE.Examples.Invoice);
        }

        public ActionResult InvoicePrint()
        {
            return View(MVC.Views.AdminLTE.Examples.InvoicePrint);
        }

        public ActionResult Lockscreen()
        {
            return View(MVC.Views.AdminLTE.Examples.Lockscreen);
        }

        public ActionResult Login()
        {
            return View(MVC.Views.AdminLTE.Examples.Login);
        }

        public ActionResult PacePage()
        {
            return View(MVC.Views.AdminLTE.Examples.PacePage);
        }

        public new ActionResult Profile()
        {
            return View(MVC.Views.AdminLTE.Examples.Profile);
        }

        public ActionResult Register()
        {
            return View(MVC.Views.AdminLTE.Examples.Register);
        }
    }
}