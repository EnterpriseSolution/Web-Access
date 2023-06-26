#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TranslationRepository.cs
// Date: 2018/04/03 20:51

#endregion
using Matrix.Administration.Endpoints;
using Microsoft.Common;
using Microsoft.Enums;
using MVC;

namespace Matrix.Administration.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.TranslationRow;

    [Matrix.Modules.Common.RepositoryService("TranslationRepository")]
    public class TranslationRepository : Matrix.Modules.Common.RepositoryBase
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        //public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        //{
        //    return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        //}

        //public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        //{
        //    return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        //}

        //public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        //{
        //    return new MyDeleteHandler().Process(uow, request);
        //}

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        //public ItemLookupResponse<MyRow> Lookup(IDbConnection connection, ItemLookupRequest request)
        //{
        //    return new MyListHandler().Process(connection, request);
        //}

        //private class MySaveHandler : SaveRequestHandler<MyRow>
        //{

        //}

        //private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }

        private class MyListHandler : ListRequestHandler<MyRow>
        {
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);
                query.Where(fld.LanguageCode == "2");
            }
        }
    }
}