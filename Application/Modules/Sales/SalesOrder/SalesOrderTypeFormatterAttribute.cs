#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesOrderTypeFormatterAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serenity.ComponentModel;

namespace Matrix.Modules.Basic.ItemGroup
{
    public partial class SalesOrderTypeFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Matrix.Enterprise.SalesOrderTypeFormatter";

        public SalesOrderTypeFormatterAttribute()
            : base(Key)
        {

        }
    }
}