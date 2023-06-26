#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemLookup.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Matrix.Administration.Entities;
using Matrix.Inventory.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace Matrix.Inventory.Columns
{
    [LookupScript("Inventory.ItemLotSerialItemLookup")]
    public sealed class ItemLookup : RowLookupScript<ItemLotSerialRow>
    {
        public ItemLookup()
        {
            IdField = ItemLotSerialRow.Fields.ItemNo.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            query.Select(ItemLotSerialRow.Fields.ItemNo);
        }
    }

}