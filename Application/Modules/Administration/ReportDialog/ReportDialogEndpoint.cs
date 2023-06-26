#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogEndpoint.cs
// Date: 2018/04/03 20:51

#endregion
using System.Collections.Generic;
using Matrix.EnterpriseSys.Entities;
using Serenity;
using Serenity.Data;
using Serenity.Services;
using System.Data;
using System.Web.Mvc;

namespace Matrix.EnterpriseSys.Endpoints
{
    using MyRepository = Repositories.ReportDialogRepository;
    using MyRow = Entities.ReportDialogRow;

    [RoutePrefix("Services/EnterpriseSys/ReportDialog"), Route("{action}")]
    [ConnectionKey(typeof(MyRow))]
    public class ReportDialogController : ServiceEndpoint
    {
        [HttpPost, AuthorizeCreate(typeof(MyRow))]
        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Create(uow, request);
        }

        [HttpPost, AuthorizeUpdate(typeof(MyRow))]
        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MyRepository().Update(uow, request);
        }
 
        [HttpPost, AuthorizeDelete(typeof(MyRow))]
        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyRepository().Delete(uow, request);
        }

        [HttpPost]
        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRepository().Retrieve(connection, request);
        }

        [HttpPost]
        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyRepository().List(connection, request);
        }

        public ReportDetailResponse ReportDetail(IDbConnection connection, ReportDetailRequest request)
        {
            var response = new ReportDetailResponse();
            List<ReportDialogOptionRow> details = null;
            //using (var connection = SqlConnections.NewByKey(SiteInitialization.Database))
            {
                details = connection.List<ReportDialogOptionRow>(q =>
                {
                    q.SelectTableFields()
                        .Where(new Criteria(ReportDialogOptionRow.Fields.ReportId) == request.ReportId);
                });
            }
            response.Rows = details;
           // string json = JsonConvert.SerializeObject(details, Formatting.None, JsonSettings.Strict);
            //return Json(json, JsonRequestBehavior.AllowGet);
            return response;
        }

        public ReportDetailResponse ReportPreview(IDbConnection connection, ReportPreviewRequest request)
        {
            var response = new ReportDetailResponse();
            Session["Reports"] = request;

            return response;
        }
    }

    public class ReportDetailRequest : ServiceRequest
    {
        public string ReportId { get; set; }
    }

    public class ReportDetailResponse : ServiceResponse
    {
        public List<ReportDialogOptionRow> Rows { get; set; }
    }

    public class ReportPreviewRequest : ServiceRequest
    {
        public string ReportId { get; set; }
        public List<ReportPreviewUserInput> Values { get; set; }
    }

    public class ReportPreviewUserInput
    {
        public int OptionNo { get; set; }
        public object Value { get; set; }
    }
}
