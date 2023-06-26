#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AllocationMethod.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Common;
using Serenity.ComponentModel;

namespace Matrix
{
    [EnumKey("Enums.AllocationMethod")]
    public enum AllocationMethod
    {
        [Description("No Allocation")]
        NoAllocation='N',

        [Description("First-In-First-Out")]
        FifoAllocation='F',

        [Description("Last-In-First-Out")]
        LifoAllocation='L',

        [Description("Actual Cost")]
        ActualCost='A'
    }
}
