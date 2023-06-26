#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CompanyLookup.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Matrix.Administration.Entities;
using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Web;

namespace Matrix.Modules.Administration.Company
{
    [LookupScript("Administration.Company")]
    public sealed class CompanyLookup : RowLookupScript<CompanyRow>
    {
        public CompanyLookup()
        {
            IdField = CompanyRow.Fields.CompanyCode.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            query.Select(CompanyRow.Fields.CompanyCode);
        }
    }

}