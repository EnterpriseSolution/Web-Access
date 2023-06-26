#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogPage.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Matrix.EnterpriseSys.Entities;
using MVC;
using Newtonsoft.Json;
using Serenity.Data;

namespace Matrix.EnterpriseSys.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix(Administration.Pages.Administration.Route + "/ReportDialog"), Route("{action=index}")]
    public class ReportDialogController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Administration/ReportDialog/ReportDialogIndex.cshtml");
        }

        //public JsonResult ReportDetail(string reportId)
        //{
        //    List<ReportDialogOptionRow> details = null;
        //    using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
        //    {
        //        details = connection.List<ReportDialogOptionRow>(q =>
        //        {
        //            q.SelectTableFields()
        //                .Where(new Criteria(ReportDialogOptionRow.Fields.ReportId) == reportId);
        //        });
        //    }

        //    string json=JsonConvert.SerializeObject(details, Formatting.None, JsonSettings.Strict);
        //    return Json(json, JsonRequestBehavior.AllowGet);
        //}
    }
}