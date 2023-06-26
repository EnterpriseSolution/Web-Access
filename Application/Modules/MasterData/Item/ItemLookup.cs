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
using Matrix.MasterData.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace Matrix.MasterData.Pages
{
    //[LookupScript("Administration.Company")]
    [LookupScript("MasterData.ItemRow")]
    public sealed class ItemLookup : RowLookupScript<ItemRow>
    {
        public ItemLookup()
        {
            IdField = ItemRow.Fields.ItemNo.PropertyName;
            TextField = ItemRow.Fields.ItemNo.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);
            query.SelectTableFields(ItemRow.Fields.ItemNo, ItemRow.Fields.Description);
        }
    }

}