#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  CostType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum CostType
    {
        [StringValue("0")]
        [DisplayText("Standard Cost")]
        StandardCost,

        [StringValue("1")]
        [DisplayText("Average Cost")]
        AverageCost,

        [StringValue("2")]
        [DisplayText("Latest Cost")]
        LatestCost
    }
}
