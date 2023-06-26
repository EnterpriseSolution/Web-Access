﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AllocationMethodFormatterAttribute.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Serenity.ComponentModel;

namespace Matrix.Modules.Basic.ItemGroup
{
    public partial class AllocationMethodFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "Matrix.Enterprise.AllocationMethodFormatter";

        public AllocationMethodFormatterAttribute()
            : base(Key)
        {

        }
    }
}