#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FormsController.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.AdminLTE
{
    using System.Web.Mvc;

    [Authorize, RoutePrefix("AdminLTE/Forms"), Route("{action=index}")]
    public class FormsController : Controller
    {
        public ActionResult GeneralElements()
        {
            return View(MVC.Views.AdminLTE.Forms.GeneralElements);
        }

        public ActionResult AdvancedElements()
        {
            return View(MVC.Views.AdminLTE.Forms.AdvancedElements);
        }

        public ActionResult TextEditors()
        {
            return View(MVC.Views.AdminLTE.Forms.TextEditors);
        }
    }
}