#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ErrorsController.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Matrix.Modules.Common
{
    public sealed class ErrorsController : Controller
    {
        public ActionResult Error404()
        {
            ActionResult result;

            object model = Request.Url.PathAndQuery;

            //if (!Request.IsAjaxRequest())
                result = View("~/Views/Shared/Error.cshtml");
            //else
            //    result = PartialView("_NotFound", model);

            return result;
        }


    }
}