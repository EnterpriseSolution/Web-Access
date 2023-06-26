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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Dapper;
using DevExpress.Web;
using Matrix;
using Matrix.EnterpriseSys.Endpoints;
using Matrix.EnterpriseSys.Entities;
using Microsoft.Common;
using Serenity.Data;

/*
 http://localhost:7451/Modules/Report/Default.aspx?ReportId=GLFRAB


 */


public partial class _Default : System.Web.UI.Page
{
    protected global::CrystalDecisions.Web.CrystalReportViewer crystalReportViewer;

    #region obsolete

    private ReportDocument reportDocument;
    public string reportFile = "~/App_Data/Customer.rpt";
    public string xsdFile = "~/App_Data/Customer.xsd";
    public string dbFile = "~/App_Data/xtreme.mdb";
    private const string QUERY_STRING = "SELECT * FROM CUSTOMER";
    private const string DATATABLE_NAME = "Customer";
    private const string DIRECTORY_FILE_PATH = "";
    private string CONNECTION_STRING
    {
        get
        {
            return string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbFile);
        }
    }

    public DataSet CustomerDataSet
    {
        get
        {
            DataSet dataSet = new DataSet();
            dataSet.ReadXmlSchema(xsdFile);
            OleDbConnection oleDbConnection = new OleDbConnection(CONNECTION_STRING);
            OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(QUERY_STRING, oleDbConnection);
            oleDbDataAdapter.Fill(dataSet, DATATABLE_NAME);
            return dataSet;
        }
    }

    private void ConfigureCrystalReports()
    {
        xsdFile = Server.MapPath(xsdFile);
        dbFile = Server.MapPath(dbFile);
        crystalReportViewer.BestFitPage = false;
        //crystalReportViewer.Width = new Unit("1884px");
        //crystalReportViewer.Height = new Unit("957px");

        reportDocument = new ReportDocument();
        string reportPath = Server.MapPath(reportFile);
        reportDocument.Load(reportPath);


        DataSet dataSet = CustomerDataSet;
        reportDocument.SetDataSource(dataSet);
        crystalReportViewer.ReportSource = reportDocument;
    }

    #endregion


    private void Page_Init(object sender, EventArgs e)
    {
        //if (Session["Reports"] != null)
        //{
        //    ReportPreviewRequest request = Session["Reports"] as ReportPreviewRequest;
        //    string file = Server.MapPath(string.Format("~/Report/{0}.rpt", request.ReportId));
        //    var dialg = GetReportDialog(request.ReportId);
        //    this.Title = dialg.Description;

        //    reportDocument = new ReportDocument();
        //    reportDocument.Load(file);
        //}

        //ConfigureCrystalReports();

        if (Session["Reports"] == null)
        {
            Response.Redirect("~/" + Matrix.Administration.Pages.Administration.Route + "/ReportDialog");
        }

        ReportPreviewRequest request = Session["Reports"] as ReportPreviewRequest;

        //string reportId = Request.QueryString["ReportId"];
        string reportId = request.ReportId;

        var dialg = GetReportDialog(reportId);
        this.Title = dialg.Description;

        string file = Server.MapPath(string.Format("~/Report/{0}.rpt", reportId));
        reportDocument = new ReportDocument();
        reportDocument.Load(file);


        ConnectionInfo connectionInfo = new ConnectionInfo();
        connectionInfo.DatabaseName = "dbEnterprise";
        connectionInfo.UserID = "SA";
        connectionInfo.Password = "Enterprise";
        connectionInfo.ServerName = "(LOCAL)";

        //crystalReportViewer.ReportSource = northwindCustomersReport;

        //reportDocument.SetDataSource(dataSet);
        
        //crystalReportViewer.ReportSource = northwindCustomersReport;

        SetDBLogonForReport(connectionInfo, reportDocument);
        SetDBLogonForSubreports(connectionInfo, reportDocument);


        PrepareReport(reportId, request);


        //string selectFormula = "{Customer.Last Year's Sales} > 11000.00 " + "AND Mid({Customer.Customer Name}, 1, 1) = \"A\"";
        //crystalReportViewer.SelectionFormula = selectFormula;



        //ArrayList arrayList = new ArrayList();
        //arrayList.Add("Paris");
        //arrayList.Add("Tokyo");

        //ParameterFields parameterFields = crystalReportViewer.ParameterFieldInfo;
        //SetCurrentValuesForParameterField(parameterFields, arrayList);

        //string startDate;
        //string endDate;
        //startDate = "8/1/1997";
        //endDate = "8/31/1997";
        //SetDateRangeForOrders(parameterFields, startDate, endDate);


        //string selectionFormula = "{Customer.Last Year's Sales} > ";
        //                           //+ salesAmount
        //                           //+ " AND Mid({Customer.Customer Name}, 1, 1) "
        //                           //+ operatorValue
        //                           //+ "'"
        //                           //+ customerName
        //                           //+ "'";

        //reportDocument.DataDefinition.RecordSelectionFormula = selectionFormula;

        //ReportDocument1.DataDefinition.FormulaFields[Formula name].Text = Value;


        crystalReportViewer.ReportSource = reportDocument;
        crystalReportViewer.RefreshReport();
    }

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

    private void PrepareReport(string reportId, ReportPreviewRequest request)
    {
        //parameter,value
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
        string str2 = string.Empty;
        List<string> selectionFormula = new List<string>();
        foreach (ReportDialogOptionRow option in fields)
        {
            #region SelectionFormula

            if (option.FieldType == (int) ReportFieldType.SelectionFormula)
            {
                SelectionFormulaOperator selectionOperator = SelectionFormulaOperator.Equal;
                stringValue = StringEnum<SelectionFormulaOperator>.GetStringValue(selectionOperator);
                str2 = string.Empty;

                ReportFieldDataType dataType = StringEnum<ReportFieldDataType>.Parse(option.DataType.ToString());
                var elementValue = request.Values.FirstOrDefault(t => t.OptionNo == option.OptionNo);

                switch (dataType)
                {

                    //case "System.String":
                    //case "System.Nullable`1[System.String]":
                    case ReportFieldDataType.String:
                        str2 = string.Format("({{{0}}}{1}\"{2}\")", option.FieldName, stringValue, elementValue.Value);
                        break;

                    //case "System.DateTime":
                    //case "System.Nullable`1[System.DateTime]":
                    case ReportFieldDataType.DateTime:
                        DateTime time;
                        DateTime.TryParse(elementValue.Value.ToString(), out time);
                        str2 = string.Format("({{{0}}}{1}Date({2},{3},{4}))",
                            new object[] {option.FieldName, stringValue, time.Year, time.Month, time.Day});
                        break;

                    case ReportFieldDataType.Numeric:
                        //case "System.Boolean":
                        //case "System.Int64":
                        //case "System.Int32":
                        //case "System.Int16":
                        //case "System.UInt64":
                        //case "System.UInt32":
                        //case "System.UInt16":
                        //case "System.Decimal":
                        //case "System.Double":
                        //case "System.Nullable`1[System.Int64]":
                        //case "System.Nullable`1[System.Int32]":
                        //case "System.Nullable`1[System.Int16]":
                        //case "System.Nullable`1[System.UInt64]":
                        //case "System.Nullable`1[System.UInt32]":
                        //case "System.Nullable`1[System.UInt16]":
                        //case "System.Nullable`1[System.Decimal]":
                        //case "System.Nullable`1[System.Double]":
                        str2 = string.Format("({{{0}}}{1}{2})", option.FieldName, stringValue, elementValue.Value);
                        break;
                }
                if (!string.IsNullOrEmpty(str2))
                {
                    selectionFormula.Add(str2);
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

        if (selectionFormula.Count > 0)
        {
            string SelectionFormula = string.Join("  AND  ", selectionFormula);
            crystalReportViewer.SelectionFormula = SelectionFormula;
        }

        if (dictionaryParamerter.Count > 0)
        {
            ParameterFields parameterFields = crystalReportViewer.ParameterFieldInfo;
            PrepareForParameterField(parameterFields, dictionaryParamerter);
        }

        if (dictionaryFormula.Count > 0)
        {
            FormulaFieldDefinitions formulaFields = reportDocument.DataDefinition.FormulaFields;
            PrepareForFormulaField(formulaFields, dictionaryFormula);
        }
    }

    //Dictionary<string, SelectionFormula> dictionary = new Dictionary<string, SelectionFormula>();
        //List<FormulaField> list = new List<FormulaField>();
        //List<ParameterField> list2 = new List<ParameterField>();
        //foreach (KeyValuePair<string, SelectionFormula> pair in this.SelectionFormulas)
        //{
        //    dictionary.Add(pair.Key, pair.Value);
        //}
        //list.AddRange(this.FormulaFields.ToArray());
        //list2.AddRange(this.ParameterFields.ToArray());
        //foreach (SelectionFormulaElement element in this.SelectionFormulaElements)
        //{

        //}

        //List<ParameterField> list3 = PromptParametersValue(this.ReportId, this.ParameterFields, this);
        //if ((list3 != null) && (list3.Count > 0))
        //{
        //    list2.AddRange(list3.ToArray());
        //}
        //if (string.IsNullOrEmpty(this._reportPath))
        //{
        //    this._reportPath = GetTempPath();
        //}
 

    //public List<SelectionFormulaElement> SelectionFormulaElements
    //{
    //    get
    //    {
    //        return this._selectionFormulaElements;
    //    }
    //}

    //public Dictionary<string, SelectionFormula> SelectionFormulas
    //{
    //    get
    //    {
    //        return this._selectionFormulas;
    //    }
    //}

    //private List<SelectionFormulaElement> _selectionFormulaElements = new List<SelectionFormulaElement>();
    //private Dictionary<string, SelectionFormula> _selectionFormulas = new Dictionary<string, SelectionFormula>();
    //private List<ParameterField> _parameterFields = new List<ParameterField>();

    //public List<ParameterField> ParameterFields
    //{
    //    get
    //    {
    //        return this._parameterFields;
    //    }
    //}

    protected void sortOrderAscending_Click(object sender, EventArgs e)
    {
        SortFields sortFields = reportDocument.DataDefinition.SortFields;
        SortField firstSortField = sortFields[0];
        firstSortField.SortDirection = CrystalDecisions.Shared.SortDirection.AscendingOrder;
        crystalReportViewer.ReportSource = reportDocument;
        
    }

    private const string SUBREPORT_PARAMETER_FIELD_NAME = "OrderDateRange";
    private const string SUBREPORT_NAME = "CustomerOrders";

    private void SetDateRangeForOrders(ParameterFields parameterFields, string startDate, string endDate)
    {
        ParameterRangeValue parameterRangeValue = new ParameterRangeValue();
        parameterRangeValue.StartValue = startDate;
        parameterRangeValue.EndValue = endDate;
        parameterRangeValue.LowerBoundType = RangeBoundType.BoundInclusive;
        parameterRangeValue.UpperBoundType = RangeBoundType.BoundInclusive;
        ParameterField parameterField = parameterFields[SUBREPORT_PARAMETER_FIELD_NAME, SUBREPORT_NAME];
        parameterField.CurrentValues.Clear();
        parameterField.CurrentValues.Add(parameterRangeValue);
    }

    private const string PARAMETER_FIELD_NAME = "City";

    private void SetCurrentValuesForParameterField(ParameterFields parameterFields, ArrayList arrayList)
    {
        ParameterValues currentParameterValues = new ParameterValues();
        foreach (object submittedValue in arrayList)
        {
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            parameterDiscreteValue.Value = submittedValue.ToString();
            currentParameterValues.Add(parameterDiscreteValue);
        }

        ParameterField parameterField = parameterFields[PARAMETER_FIELD_NAME];
        parameterField.CurrentValues = currentParameterValues;

    }

    private void PrepareForParameterField(ParameterFields parameterFields, Dictionary<string,object> arrayList)
    {
        foreach (var parameterNameValue in arrayList)
        {
            ParameterValues currentParameterValues = new ParameterValues();
            ParameterDiscreteValue parameterDiscreteValue = new ParameterDiscreteValue();
            parameterDiscreteValue.Value = parameterNameValue.Value;
            currentParameterValues.Add(parameterDiscreteValue);


            ParameterField parameterField = parameterFields[parameterNameValue.Key];
            parameterField.CurrentValues = currentParameterValues;
        }
    }

    private void PrepareForFormulaField(FormulaFieldDefinitions parameterFields, Dictionary<string, object> arrayList)
    {
        foreach (var parameterNameValue in arrayList)
        {
            parameterFields[parameterNameValue.Key].Text = Convert.ToString(parameterNameValue.Value);
        }
    }

    private void SetDBLogonForReport(ConnectionInfo connectionInfo, ReportDocument reportDocument)
    {
        Tables tables = reportDocument.Database.Tables;
        foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
        {
            TableLogOnInfo tableLogonInfo = table.LogOnInfo;
            tableLogonInfo.ConnectionInfo = connectionInfo;
            table.ApplyLogOnInfo(tableLogonInfo);

        }
    }

    private void SetDBLogonForSubreports(ConnectionInfo connectionInfo, ReportDocument reportDocument)
    {
        Sections sections = reportDocument.ReportDefinition.Sections;
        foreach (Section section in sections)
        {
            ReportObjects reportObjects = section.ReportObjects;
            foreach (ReportObject reportObject in reportObjects)
            {
                if (reportObject.Kind == ReportObjectKind.SubreportObject)
                {
                    SubreportObject subreportObject = (SubreportObject)reportObject;
                    ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);
                    SetDBLogonForReport(connectionInfo, subReportDocument);
                }
            }
        }
    }

    public ReportDialogRow GetReportDialog(string reportId)
    {
        using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
        {
            const string query =
                @"SELECT ReportId,Description,DataSource 
                                   FROM dbo.ReportDialog                       
                            WHERE ReportId = @ReportId";
            return connection.QuerySingle<ReportDialogRow>(query, new { ReportId = reportId });
        }
    }
}
