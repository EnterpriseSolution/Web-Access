﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportRepository.cs
// Date: 2018/04/03 20:51

#endregion
namespace Matrix
{
    using Serenity;
    using Serenity.PropertyGrid;
    using Serenity.Reporting;
    using Serenity.Services;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    [Matrix.Modules.Common.RepositoryService("ReportRepository")]
    public class ReportRepository : Matrix.Modules.Common.RepositoryBase
    {
        public byte[] Render(IDataOnlyReport report)
        {
            //var columns = report.GetColumnList();

            //var data = new List<object>();
            //var input = report.GetData();
            //var list = (input as IEnumerable) ?? new List<object> { input };
            //foreach (var item in list)
            //    data.Add(item);

            //return ExcelReportGenerator.GeneratePackageBytes(columns, data);
            throw new NotImplementedException();
        }

        public ReportTree GetReportTree(string category)
        {
            var reports = ReportRegistry.GetAvailableReportsInCategory(category);
            return ReportTree.FromList(reports, category);
        }

        public ReportRetrieveResponse Retrieve(ReportRetrieveRequest request)
        {
            request.CheckNotNull();

            if (request.ReportKey.IsEmptyOrNull())
                throw new ArgumentNullException("reportKey");

            var reportInfo = ReportRegistry.GetReport(request.ReportKey);
            if (reportInfo == null)
                throw new ArgumentOutOfRangeException("reportKey");

            if (reportInfo.Permission != null)
                Authorization.ValidatePermission(reportInfo.Permission);

            var response = new ReportRetrieveResponse();

            response.Properties = PropertyItemHelper.GetPropertyItemsFor(reportInfo.Type);
            response.ReportKey = reportInfo.Key;
            response.Title = reportInfo.Title;
            var reportInstance = Activator.CreateInstance(reportInfo.Type);
            response.InitialSettings = reportInstance;
            response.IsDataOnlyReport = reportInstance is IDataOnlyReport;

            return response;
        }
    }
}