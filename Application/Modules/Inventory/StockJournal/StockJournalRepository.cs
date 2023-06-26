#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockJournalRepository.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.StockJournalRow;

    [Matrix.Modules.Common.RepositoryService("StockJournalRepository")]
    public class StockJournalRepository : Matrix.Modules.Common.RepositoryBase
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, StockJournalListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
        

        public class StockJournalListRequest : ListRequest
        {
            public string Location  { get; set; }
            public string ItemNo { get; set; }
        }

        private class MyListHandler : ListRequestHandler<MyRow, StockJournalListRequest>
        {
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);
                if (!string.IsNullOrWhiteSpace(Request.Location))
                {
                    query.Where(MyRow.Fields.Loc == Request.Location);
                }
                if (!string.IsNullOrWhiteSpace(Request.ItemNo))
                {
                    query.Where(MyRow.Fields.ItemNo == Request.ItemNo);
                }
            }
        }
    }
}