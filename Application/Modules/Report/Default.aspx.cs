#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  Default.aspx.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
//using Dapper;
using Matrix;
using Matrix.Administration.Entities;
using Matrix.EnterpriseSys.Endpoints;
using Matrix.EnterpriseSys.Entities;
using Microsoft.Common;
using Serenity.Data;


public partial class _Default : System.Web.UI.Page
{
    //protected global::CrystalDecisions.Web.CrystalReportViewer crystalReportViewer;
    //private ReportDocument _reportDocument;

    private void Page_Init(object sender, EventArgs e)
    {
        if (Session["Reports"] == null)
        {
            Response.Redirect("~/" + Matrix.Administration.Pages.Administration.Route + "/ReportDialog");
        }

        ReportPreviewRequest request = Session["Reports"] as ReportPreviewRequest;
        
        string reportId = request.ReportId;

        //var dialg = GetReportDialog(reportId);
        //this.Title = dialg.Description;

        //string file = Server.MapPath(string.Format("~/Report/{0}.rpt", reportId));
        //_reportDocument = new ReportDocument();
        //_reportDocument.Load(file);

        //CompanyRow company = HttpContext.Current.Cache["COMPANY_ENTITY"] as CompanyRow;
        //if (company == null)
        //{
        //    throw new UnauthorizedAccessException("Access denied");
        //}

        //ConnectionInfo connectionInfo = new ConnectionInfo();
        ////connectionInfo.DatabaseName = "dbEnterprise";
        ////connectionInfo.UserID = "SA";
        ////connectionInfo.Password = "Enterprise";
        ////connectionInfo.ServerName = "(LOCAL)";
        //connectionInfo.DatabaseName = company.DbDatabase;
        //connectionInfo.UserID = company.DbUser;
        //connectionInfo.Password = company.DbPassword;
        //connectionInfo.ServerName = company.DbServer;

        //SetDBLogonForReport(connectionInfo, _reportDocument);
        //SetDBLogonForSubreports(connectionInfo, _reportDocument);


        //PrepareReport(reportId, request);
        

        //crystalReportViewer.ReportSource = _reportDocument;
        //crystalReportViewer.RefreshReport();
    }

    private void PrepareReport(string reportId, ReportPreviewRequest request)
    {
        Dictionary<string, object> dictionaryParamerter=new Dictionary<string, object>();
        Dictionary<string, object> dictionaryFormula = new Dictionary<string, object>();

        List<ReportDialogOptionRow> fields = null;
        using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
        {
            fields = connection.List<ReportDialogOptionRow>(q =>
            {
                q.SelectTableFields()
                    .Where(new Criteria(ReportDialogOptionRow.Fields.ReportId) == reportId);
            });
        }

        string stringValue = string.Empty;
        string selectionFormulaExpression = string.Empty;
        List<string> selectionFormulaList = new List<string>();
        foreach (ReportDialogOptionRow option in fields)
        {
            #region SelectionFormula

            if (option.FieldType == (int) ReportFieldType.SelectionFormula)
            {
                SelectionFormulaOperator selectionOperator = SelectionFormulaOperator.Equal;
                stringValue = StringEnum<SelectionFormulaOperator>.GetStringValue(selectionOperator);
                selectionFormulaExpression = string.Empty;

                ReportFieldDataType dataType = StringEnum<ReportFieldDataType>.Parse(option.DataType.ToString());
                var elementValue = request.Values.FirstOrDefault(t => t.OptionNo == option.OptionNo);

                switch (dataType)
                {
                    case ReportFieldDataType.String:
                        selectionFormulaExpression = string.Format("({{{0}}}{1}\"{2}\")", option.FieldName, stringValue, elementValue.Value);
                        break;
                   
                    case ReportFieldDataType.DateTime:
                        DateTime time;
                        DateTime.TryParse(elementValue.Value.ToString(), out time);
                        selectionFormulaExpression = string.Format("({{{0}}}{1}Date({2},{3},{4}))",
                            new object[] {option.FieldName, stringValue, time.Year, time.Month, time.Day});
                        break;

                    case ReportFieldDataType.Numeric:
                        selectionFormulaExpression = string.Format("({{{0}}}{1}{2})", option.FieldName, stringValue, elementValue.Value);
                        break;
                }
                if (!string.IsNullOrEmpty(selectionFormulaExpression))
                {
                    selectionFormulaList.Add(selectionFormulaExpression);
                }
            }

            #endregion

            #region Parameter

            if (option.FieldType == (int) ReportFieldType.Parameter)
            {
                var elementValue = request.Values.FirstOrDefault(t => t.OptionNo == option.OptionNo);
                dictionaryParamerter.Add(option.FieldName, elementValue.Value);
            }

            #endregion

            #region FormulaField

            if (option.FieldType == (int)ReportFieldType.FormulaField)
            {
                var elementValue = request.Values.FirstOrDefault(t => t.OptionNo == option.OptionNo);
                dictionaryParamerter.Add(option.FieldName, elementValue.Value);
            }

            #endregion
        }

        //if (selectionFormulaList.Count > 0)
        //{
        //    string selectionFormula = string.Join("  AND  ", selectionFormulaList);
        //    crystalReportViewer.SelectionFormula = selectionFormula;
        //}

        //if (dictionaryParamerter.Count > 0)
        //{
        //    ParameterFields parameterFields = crystalReportViewer.ParameterFieldInfo;
        //    PrepareForParameterField(parameterFields, dictionaryParamerter);
        //}

        //if (dictionaryFormula.Count > 0)
        //{
        //    FormulaFieldDefinitions formulaFields = _reportDocument.DataDefinition.FormulaFields;
        //    PrepareForFormulaField(formulaFields, dictionaryFormula);
        //}
    }
   
    //protected void sortOrderAscending_Click(object sender, EventArgs e)
    //{
    //    SortFields sortFields = _reportDocument.DataDefinition.SortFields;
    //    SortField firstSortField = sortFields[0];
    //    firstSortField.SortDirection = CrystalDecisions.Shared.SortDirection.AscendingOrder;
    //    crystalReportViewer.ReportSource = _reportDocument;
    //}
    
    //private void PrepareForParameterField(ParameterFields parameterFields, Dictionary<string,object> arrayList)
    //{
    //    foreach (var parameterNameValue in arrayList)
    //    {
    //        ParameterValues currentParameterValues = new ParameterValues();
    //        ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
    //        parameterDiscreteValue.Value = parameterNameValue.Value;
    //        currentParameterValues.Add(parameterDiscreteValue);


    //        ParameterField parameterField = parameterFields[parameterNameValue.Key];
    //        parameterField.CurrentValues = currentParameterValues;
    //    }
    //}

    //private void PrepareForFormulaField(FormulaFieldDefinitions parameterFields, Dictionary<string, object> arrayList)
    //{
    //    foreach (var parameterNameValue in arrayList)
    //    {
    //        parameterFields[parameterNameValue.Key].Text = Convert.ToString(parameterNameValue.Value);
    //    }
    //}

    //private void SetDBLogonForReport(ConnectionInfo connectionInfo, ReportDocument reportDocument)
    //{
    //    Tables tables = reportDocument.Database.Tables;
    //    foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
    //    {
    //        TableLogOnInfo tableLogonInfo = table.LogOnInfo;
    //        tableLogonInfo.ConnectionInfo = connectionInfo;
    //        table.ApplyLogOnInfo(tableLogonInfo);

    //    }
    //}

    //private void SetDBLogonForSubreports(ConnectionInfo connectionInfo, ReportDocument reportDocument)
    //{
    //    Sections sections = reportDocument.ReportDefinition.Sections;
    //    foreach (Section section in sections)
    //    {
    //        ReportObjects reportObjects = section.ReportObjects;
    //        foreach (ReportObject reportObject in reportObjects)
    //        {
    //            if (reportObject.Kind == ReportObjectKind.SubreportObject)
    //            {
    //                SubreportObject subreportObject = (SubreportObject)reportObject;
    //                ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
    //                SetDBLogonForReport(connectionInfo, subReportDocument);
    //            }
    //        }
    //    }
    //}

    //public ReportDialogRow GetReportDialog(string reportId)
    //{
    //    using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
    //    {
    //        const string query =
    //            @"SELECT ReportId,Description,DataSource 
    //                               FROM dbo.ReportDialog                       
    //                        WHERE ReportId = @ReportId";
    //        return connection.QuerySingle<ReportDialogRow>(query, new { ReportId = reportId });
    //    }
    //}


    public enum SelectionFormulaOperator
    {
        [StringValue("=")]
        Equal = 0,
        [StringValue(">")]
        GreaterThan = 3,
        [StringValue(">=")]
        GreaterThanOrEqual = 4,
        [StringValue("<>")]
        NotEqual = 5,
        [StringValue("<")]
        SmallerThan = 1,
        [StringValue("<=")]
        SmallerThanOrEqual = 2
    }

    public enum ReportFieldType
    {
        [DisplayText("Selection Formula"), StringValue("0")]
        SelectionFormula = 0,

        [StringValue("1"), DisplayText("Formula Field")]
        FormulaField = 1,

        [DisplayText("Parameter"), StringValue("2")]
        Parameter = 2
    }

    public enum ReportFieldDataType
    {
        [DisplayText("String"), StringValue("0")]
        String = 0,

        [DisplayText("Numeric"), StringValue("1")]
        Numeric = 1,

        [DisplayText("Date"), StringValue("2")]
        DateTime = 2
    }
}
