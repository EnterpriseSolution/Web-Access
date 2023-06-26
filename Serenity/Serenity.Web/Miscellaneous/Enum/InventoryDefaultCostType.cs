#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  InventoryDefaultCostType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum InventoryDefaultCostType
    {
        [StringValue("0")]
        [DisplayText("Std. Cost")]
        StdCost,

        [StringValue("1")]
        [DisplayText("Avg. Cost")]
        AvgCost,

        [StringValue("2")]
        [DisplayText("Latest Cost")]
        LatestCost

    }
}
