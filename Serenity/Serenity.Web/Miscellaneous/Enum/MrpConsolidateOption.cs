#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  MrpConsolidateOption.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum MrpConsolidateOption
    {
        [DisplayText("None")]
        [StringValue("0")]
        None = 0,

        [DisplayText("Day")]
        [StringValue("1")]
        Day = 1,

        [DisplayText("Month")]
        [StringValue("2")]
        Month = 2,

        [DisplayText("Week")]
        [StringValue("3")]
        Week = 3,

        [DisplayText("All")]
        [StringValue("4")]
        All = 4
    }
}
