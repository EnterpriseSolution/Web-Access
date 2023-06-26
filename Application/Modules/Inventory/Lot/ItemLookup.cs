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

namespace Matrix.Modules.Administration.Company
{
    [LookupScript("Inventory.ItemLotItemLookup")]
    public sealed class ItemLookup : RowLookupScript<ItemLotRow>
    {
        public ItemLookup()
        {
            IdField = ItemLotRow.Fields.ItemNo.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            query.Select(ItemLotRow.Fields.ItemNo);
        }
    }

}