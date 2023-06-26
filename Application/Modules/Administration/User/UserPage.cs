#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  UserPage.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Pages
{
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix(Administration.Route + "/User"), Route("{action=index}")]
    public class UserController : Controller
    {
        public ActionResult Index()
        {
            return View(MVC.Views.Administration.User.UserIndex);
        }
    }
}