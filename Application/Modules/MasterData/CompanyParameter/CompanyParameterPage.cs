#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanyParameterPage.cs
// Date: 2018/04/03 20:51

#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CopyPropertiesFromOneObjectToAnother;
using Matrix.Basic.Entities;
using Matrix.EnterpriseSys.Entities;
using MVC;
using Serenity.Data;

namespace Matrix.Basic.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("MasterData/CompanyParameter"), Route("{action=index}")]    
    public class CompanyParameterController : Controller
    {
        public ActionResult Index()
        {
            using (var connection = SqlConnections.NewByKey("BasicInformation"))
            {
                var companyParameterRows = connection.List<CompanyParameterRow>();
                var companySettingRows = connection.List<CompanySettingRow>();

                CompanyParameterRow companyParameter = companyParameterRows.FirstOrDefault();
                CompanySettingRow companySetting = companySettingRows.FirstOrDefault();
                PropertiesCopier.CopyProperties(companySetting, companyParameter);

                return View("~/Modules/MasterData/CompanyParameter/CompanyParameterIndex.cshtml", companyParameter);
            }
        }
    }
}