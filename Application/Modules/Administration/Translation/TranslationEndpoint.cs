#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TranslationEndpoint.cs
// Date: 2018/04/03 20:51

#endregion

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Script.Serialization;
using Dapper;
using Matrix.Administration.Entities;
using Matrix.EnterpriseSys.Entities;

namespace Matrix.Administration.Endpoints
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using System.Web.Mvc;
    using MyRepository = Repositories.TranslationRepository;
    using MyRow = Entities.TranslationRow;

    [RoutePrefix("Services/Administration/Translation"), Route("{action}")]
    [ConnectionKey(typeof(MyRow)), ServiceAuthorize(typeof(MyRow))]
    public class TranslationController : ServiceEndpoint
    {
        //[HttpPost, AuthorizeCreate(typeof(MyRow))]
        //public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        //{
        //    return new MyRepository().Create(uow, request);
        //}

        //[HttpPost, AuthorizeUpdate(typeof(MyRow))]
        //public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        //{
        //    return new MyRepository().Update(uow, request);
        //}
 
        //[HttpPost, AuthorizeDelete(typeof(MyRow))]
        //public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        //{
        //    return new MyRepository().Delete(uow, request);
        //}

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            //request.Criteria &= new Criteria(MyRow.Fields.LanguageCode) == StringEnum<TranslationLanguage>.GetStringValue(TranslationLanguage.SimplifiedChinese);
            return new MyRepository().List(connection, request);
        }

        private string sessionId = "";
        //private int pageNumber = 0;
        private int pageSize = 10;
        private string companyCode = "";

        public ItemLookupResponse Lookup(IDbConnection connection, ItemLookupRequest request)
        {
            var response = new ItemLookupResponse();

            string queryId = string.Empty;

            LookupDialogRow lookup = GetLookup(request.LookupName, request.LookupFilter);
            queryId = lookup.QueryId;

            JsonResult rows = null;
            List<ColumnEntity> columns = new List<ColumnEntity>();

            //IUserDefinedQueryManager udqManager = new UserDefinedQueryManager();
            DataSet dataSet = new DataSet();//  udqManager.GetQueryResultDataSet(sessionId, queryId, request.CurrentPageIndex, pageSize, companyCode);
            DataTable table = null;
            int recordNumber = 0;
            double pageCount = 0;

            if (dataSet.Tables.Count > 0)
            {
                table = dataSet.Tables[0];
                recordNumber =Convert.ToInt32(table.ExtendedProperties["RecordNumber"]);
                pageCount = (double)((decimal)recordNumber / Convert.ToDecimal(pageSize));
            }
            
            response.PageCount = (int)Math.Ceiling(pageCount);
            response.CurrentPageIndex = request.CurrentPageIndex;
            response.Description = lookup.Description;
            response.KeyField1 = lookup.KeyField1;
            response.KeyField1 = lookup.KeyField1;
            response.KeyField1 = lookup.KeyField1;

            if (table!=null)
            {
                var jsonResult = Json(table, JsonRequestBehavior.AllowGet);
                jsonResult.MaxJsonLength = int.MaxValue;
                rows = jsonResult;

                foreach (DataColumn col in table.Columns)
                {
                    columns.Add(new ColumnEntity
                    {
                        Field = col.ColumnName,
                        Caption = col.ColumnName,
                        Width = 300
                    });
                }
            }

            response.Columns = columns;
            response.RowData = rows;
            
            return response;
        }

        private LookupDialogRow GetLookup(string lookupname,string filter)
        {
            using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
            {
                const string query =
                    @" SELECT LookupName,Description,QueryId,KeyField1,KeyField2,KeyField3 
                       FROM dbo.LookupDialog
                       WHERE LookupName=@LookupName";
                return connection.QuerySingle<LookupDialogRow>(query, new { LookupName = lookupname });
            }
        }

        //public static string ConvertDataTabletoString(DataTable table)
        //{
        //    JavaScriptSerializer serializer = new JavaScriptSerializer();
        //    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
        //    Dictionary<string, object> row;
        //    foreach (DataRow dr in table.Rows)
        //    {
        //        row = new Dictionary<string, object>();
        //        foreach (DataColumn col in table.Columns)
        //        {
        //            row.Add(col.ColumnName, dr[col]);
        //        }
        //        rows.Add(row);
        //    }
        //    return serializer.Serialize(rows);
        //}
    }


    public class ItemLookupResponse : ServiceResponse
    {
        public ItemLookupResponse()
        {
            this.Columns = new List<ColumnEntity>();
        }

        public List<ColumnEntity> Columns { get; set; }
        public JsonResult RowData { get; set; }
        public int PageCount { get; set; }
        public int CurrentPageIndex { get; set; }

        public string Description { get; set; }
        public string KeyField1 { get; set; }
        public string KeyField2 { get; set; }
        public string KeyField3 { get; set; }
    }

    public class ItemLookupRequest: ServiceRequest
    {
        public string LookupName { get; set; }
        public string LookupFilter { get; set; }

        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; }
    }

    public class ColumnEntity
    {
        public string Field { get; set; }
        public string Caption { get; set; }
        public decimal Width { get; set; }
    }
}
