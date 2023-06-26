#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  DashboardEndpoint.cs
// Date: 2018/04/03 20:51

#endregion

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Matrix.EnterpriseSys.Entities;
using Matrix.Finance.Entities;
using Serenity;
using Serenity.Data;
using Serenity.Services;

//SELECT PERIOD, Amt = SUM(ISNULL(LOCAL_BAL_END, 0)) FROM dbo.APLEDG
//    WHERE PERIOD IN ('2017/08','2017/07','2017/06','2017/05','2017/04','2017/03')
//GROUP BY PERIOD

//SELECT PERIOD,Amt=SUM(ISNULL(LOCAL_BAL_END,0)) FROM dbo.ARLEDG
//WHERE PERIOD IN ('2017/08','2017/07','2017/06','2017/05','2017/04','2017/03')
//GROUP BY PERIOD

namespace Matrix.Common
{
    [RoutePrefix("Services/Dashboard/Repository"), Route("{action}")]
    [Matrix.Modules.Common.RepositoryService("DashboardRepository")]
    public class DashboardController : ServiceEndpoint
    {
        //private string db = "MasterData";

        public DashboardPageModel GetBoxData()
        {
            var userdefin = HttpRuntime.Cache["COMPANY_INFO"] as IUserDefinition;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = userdefin.DataSource;
            builder.InitialCatalog = userdefin.InitialCatalog;
            builder.UserID = userdefin.UserID;
            builder.Password = userdefin.Password;

            DashboardPageModel model = new DashboardPageModel();
           
            using (var connection = SqlConnections.NewByConnectionString(builder.ConnectionString))
            {
                string query = "  SELECT START_DATE,END_DATE  FROM dbo.GBPERD WHERE PERIOD= ( SELECT TOP 1   CURRENT_PERIOD FROM dbo.GBPARM ) ";
                var param = connection.Query(query).SingleOrDefault();
                DateTime dtBegin = Convert.ToDateTime(param.START_DATE);
                DateTime dtEnd = Convert.ToDateTime(param.END_DATE);
                string begin = dtBegin.ToString("yyyy-MM-dd");
                string end = dtEnd.ToString("yyyy-MM-dd");

                query = "  SELECT CURRENT_PERIOD  FROM dbo.GBPARM ";
                var parm = connection.Query(query).SingleOrDefault();
                string period = (string)parm.CURRENT_PERIOD;

                query = string.Format(@"SELECT NoOfRecord=COUNT(1) FROM dbo.SLORDH WHERE POSTED='Y'  AND  ORDER_DATE BETWEEN '{0}' AND '{1}'   ", begin, end);
                var saleOrder = connection.Query(query).SingleOrDefault();

                query = string.Format(@"SELECT NoOfRecord=COUNT(1) FROM dbo.PUORDH WHERE POSTED='Y'  AND  ORDER_DATE BETWEEN '{0}' AND '{1}'   ", begin, end);
                var purchaseOrder = connection.Query(query).SingleOrDefault();

                query = string.Format(@"SELECT NoOfRecord=COUNT(1) FROM dbo.PRJOBH WHERE POSTED='Y'  AND  ISSUE_DATE BETWEEN '{0}' AND '{1}'   ", begin, end);
                var jobOrder = connection.Query(query).SingleOrDefault();

                query = string.Format(@"SELECT NoOfRecord=COUNT(1) FROM dbo.PRCOMH WHERE POSTED='Y'  AND  TRAN_DATE BETWEEN '{0}' AND '{1}'   ", begin, end);
                var workCompletion = connection.Query(query).SingleOrDefault();
                
                query = string.Format(@"SELECT Amount=ISNULL(SUM(ISNULL(LOCAL_BAL_END,0)),0)  FROM dbo.APLEDG WHERE PERIOD='{0}'    ", period);
                var vendorLedger = connection.Query(query).SingleOrDefault();

                query = string.Format(@"SELECT Amount=ISNULL(SUM(ISNULL(LOCAL_BAL_END,0)),0)  FROM dbo.ARLEDG WHERE PERIOD='{0}'    ", period);
                var customerLedger = connection.Query(query).SingleOrDefault();

                model.SalesOrderCount = saleOrder?.NoOfRecord;
                model.PurchaseOrderCount = purchaseOrder?.NoOfRecord;
                model.JobOrderCount = jobOrder?.NoOfRecord;
                model.WorkCompletionCount = workCompletion?.NoOfRecord;

                model.AmountPaied = vendorLedger?.Amount;
                model.AmountReceived = customerLedger?.Amount;
            }

            return model;
        }

        public DashboardPageModel GetOrderData()
        {
            DashboardPageModel model = new DashboardPageModel();

            var userdefin = HttpRuntime.Cache["COMPANY_INFO"] as IUserDefinition;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = userdefin.DataSource;
            builder.InitialCatalog = userdefin.InitialCatalog;
            builder.UserID = userdefin.UserID;
            builder.Password = userdefin.Password;

            using (var connection = SqlConnections.NewByConnectionString(builder.ConnectionString))
            {
                string query = "  SELECT START_DATE,END_DATE  FROM dbo.GBPERD WHERE PERIOD= ( SELECT TOP 1   CURRENT_PERIOD FROM dbo.GBPARM ) ";
                var param = connection.Query(query).SingleOrDefault();
                DateTime dtBegin = Convert.ToDateTime(param.START_DATE);
                DateTime dtEnd = Convert.ToDateTime(param.END_DATE);
                string begin = dtBegin.ToString("yyyy-MM-dd");
                string end = dtEnd.ToString("yyyy-MM-dd");
                
                query = string.Format(@" SELECT TOP 4 ORDER_NO,CUSTOMER_NAME,ORDER_DATE  FROM dbo.SLORDH
                                                WHERE POSTED='Y'  AND  ORDER_DATE BETWEEN '{0}' AND '{1}'
                                                ORDER BY ORDER_DATE DESC   ", begin, end);
                var saleOrder = connection.Query(query).ToList();
                foreach (var so in saleOrder)
                {
                    model.SalesOrder.Add(new LatestOrderRow()
                    {
                        OrderNo = so.ORDER_NO,
                        Vendor = so.CUSTOMER_NAME,
                        Status = "Shipped",
                        OrderDate = Convert.ToDateTime(so.ORDER_DATE).ToString("yyyy-MM-dd")
                    });
                }

                query = string.Format(@" SELECT TOP 4 ORDER_NO,VENDOR_NAME,ORDER_DATE  FROM dbo.PUORDH
                                                WHERE POSTED='Y'  AND  ORDER_DATE BETWEEN '{0}' AND '{1}'
                                                ORDER BY ORDER_DATE DESC   ", begin, end);
                var purchaseOrder = connection.Query(query).ToList();
                foreach (var so in purchaseOrder)
                {
                    model.PurchaseOrder.Add(new LatestOrderRow()
                    {
                        OrderNo = so.ORDER_NO,
                        Vendor = so.VENDOR_NAME,
                        Status = "Shipped",
                        OrderDate = Convert.ToDateTime(so.ORDER_DATE).ToString("yyyy-MM-dd")
                    });
                }

                query = @" SELECT TOP 3 PROJECT,PROJECT_NAME,PROJECT_LEADER ,REVISED_DATE FROM SLPRJH
                                         ORDER BY REVISED_DATE DESC   ";
                var project = connection.Query(query).ToList();
                foreach (var so in project)
                {
                    model.Project.Add(new LatestProjectRow()
                    {
                        ProjectName = so.PROJECT,
                        Description = so.PROJECT_NAME,
                        Leader = so.PROJECT_LEADER,
                        EstimatedAmount = "3463.23$"
                    });
                }
            }

            return model;
        }

        public DashboardPageModel GetReportData()
        {
            var userdefin = HttpRuntime.Cache["COMPANY_INFO"] as IUserDefinition;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = userdefin.DataSource;
            builder.InitialCatalog = userdefin.InitialCatalog;
            builder.UserID = userdefin.UserID;
            builder.Password = userdefin.Password;

            DashboardPageModel model = new DashboardPageModel();
            using (var connection = SqlConnections.NewByConnectionString(builder.ConnectionString))
            {
                string query = "  SELECT CURRENT_PERIOD  FROM dbo.GBPARM ";
                var parm = connection.Query(query).SingleOrDefault();
                string currentPeriod = (string)parm.CURRENT_PERIOD;

                query = string.Format(@" SELECT TOP 6 FISCAL_YEAR,PERIOD_NO,PERIOD,START_DATE,END_DATE FROM  dbo.GBPERD
                                         WHERE RECNUM <= (SELECT    RECNUM FROM dbo.GBPERd WHERE PERIOD = '{0}') 
                                         ORDER BY RECNUM DESC ", currentPeriod);
                var periods = connection.Query(query).ToList();
                foreach (dynamic period in periods.OrderBy(en=>en.PERIOD))
                {
                    model.Graph.Add(new ReportModel()
                    {
                        Period = period.PERIOD,
                        StartDate = period.START_DATE,
                        EndDate = period.END_DATE
                    });
                }

                query =string.Format(@"SELECT PERIOD,Amt=SUM(ISNULL(LOCAL_BAL_END,0)) FROM  dbo.APLEDG
                        WHERE PERIOD IN({0})
                        GROUP BY PERIOD",string.Join("," ,model.Graph.Select(en=>"'" +en.Period+"'")));
                var ap = connection.Query(query).ToList();
                query = string.Format(@"SELECT PERIOD,Amt=SUM(ISNULL(LOCAL_BAL_END,0)) FROM  dbo.ARLEDG
                        WHERE PERIOD IN({0})
                        GROUP BY PERIOD", string.Join(",", model.Graph.Select(en => "'" + en.Period + "'")));
                var ar = connection.Query(query).ToList();

                foreach (ReportModel reportModel in model.Graph)
                {
                    var apLedger = ap.Where(en => en.PERIOD == reportModel.Period).FirstOrDefault();
                    if (apLedger != null)
                        reportModel.AP = apLedger.Amt;
                    var arLedger = ar.Where(en => en.PERIOD == reportModel.Period).FirstOrDefault();
                    if (arLedger != null)
                        reportModel.AR = arLedger.Amt;
                }

                //var sorted = model.Graph.OrderByDescending(en => en.Period).ToList();
                //for (int i = 0; i < sorted.Count(); i++)
                //{
                //    ReportModel reportModel = sorted[i];
                //    if (i + 1 < sorted.Count)
                //    {
                //        reportModel.DebitRatio = CalculateChange(Convert.ToDouble(sorted[i + 1].Debit), Convert.ToDouble(reportModel.Debit));
                //        reportModel.CreditRatio = CalculateChange(Convert.ToDouble(sorted[i + 1].Credit), Convert.ToDouble(reportModel.Credit));
                //    }
                //    else
                //    {
                //        reportModel.DebitRatio = 0;
                //        reportModel.CreditRatio = 0;
                //    }
                //}

                //inventory lendger
                query = string.Format(@"SELECT ValueBegin= SUM(ISNULL(VALUE_BEG,0) ),CostIN=SUM(ISNULL(COST_IN,0)) , CostOut=SUM(ISNULL(COST_OUT,0))  FROM  ICLEDG
                                        WHERE PERIOD='{0}'   ", currentPeriod);
                var icLedger = connection.Query(query).SingleOrDefault();
                if (icLedger != null)
                {
                    model.InventoryLedgerIn = icLedger.CostIN;
                    model.InventoryLedgerOut = icLedger.CostOut;
                }

                query = "SELECT BASE_CURRENCY  FROM dbo.GBPARM  ";
                var gbparm = connection.Query(query).SingleOrDefault();
                if (gbparm != null)
                {
                    model.Ccy = gbparm.BASE_CURRENCY;
                }

                return model;
            }
        }

        decimal CalculateChange(double previous, double current)
        {
            if (current == 0)
                return 0;
            return (int)Math.Round((double)(100 * previous) / current);
        }
    }

    public class DashboardPageModel
    {
        public DashboardPageModel()
        {
            SalesOrder = new List<LatestOrderRow>();
            PurchaseOrder = new List<LatestOrderRow>();
            Project = new List<LatestProjectRow>();
            Graph = new List<ReportModel>();
        }

        public int SalesOrderCount { get; set; }
        public int PurchaseOrderCount { get; set; }
        public int JobOrderCount { get; set; }
        public int WorkCompletionCount { get; set; }

        public decimal AmountReceived { get; set; }
        public decimal AmountPaied { get; set; }

        public List<LatestOrderRow> SalesOrder { get; set; }
        public List<LatestOrderRow> PurchaseOrder { get; set; }
        public List<LatestProjectRow> Project { get; set; }

        public List<ReportModel> Graph { get; set; }
        public string Ccy { get; set; }
        public decimal ValueBegin { get; set; }
        public decimal DebitCredit { get; set; }
        public decimal InventoryLedgerIn { get; set; }
        public decimal InventoryLedgerOut { get; set; }

      
    }

    public class LatestOrderRow
    {
        public string OrderNo { get; set; }
        public string Vendor { get; set; }
        public string Status { get; set; }
        public string OrderDate { get; set; }
    }

    public class LatestProjectRow
    {
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string Leader { get; set; }
        public string EstimatedAmount  { get; set; }
    }

    public class ReportModel
    {
        public int LineNo { get; set; }
        public string Period { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal DebitRatio { get; set; }
        public decimal CreditRatio { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal AP { get; set; }
        public decimal AR { get; set; }
    }
}