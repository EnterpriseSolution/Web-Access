#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemGroupRepository.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;
using Microsoft.Common;
using Microsoft.Enums;

namespace Matrix.Enterprise.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.ItemGroupRow;

    [Matrix.Modules.Common.RepositoryService("ItemGroupRepository")]
    public class ItemGroupRepository : Matrix.Modules.Common.RepositoryBase
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

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }

        private class MyListHandler : ListRequestHandler<MyRow>
        {
            //protected override void OnReturn()
            //{
            //    base.OnReturn();
            //    List<MyRow> response = Connection.List<Entities.ItemGroupRow>(q => q
            //            .SelectTableFields());
            //    foreach (var entity in response)
            //    {
            //        ItemType itemType = StringEnum<ItemType>.Parse(entity.ItemType);
            //        entity.ItemTypeDescription = StringEnum<ItemType>.GetDisplayText(itemType);


            //        //AllocationMethod allocationMethod = StringEnum<AllocationMethod>.Parse(entity.AllocMethod);
            //        //entity.AllocMethodDescription = StringEnum<AllocationMethod>.GetDisplayText(allocationMethod);
            //    }
            //}
        }
    }
}