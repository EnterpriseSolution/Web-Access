#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  CostBasis.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum CostBasis
    {
        [StringValue("1")]
        [DisplayText("Inventory Cost")]
        InventoryCost,

        [StringValue("2")]
        [DisplayText("Latest Cost")]
        LatestCost,

        [StringValue("3")]
        [DisplayText("Standard Cost")]
        StandardCost,

        [StringValue("4")]
        [DisplayText("Manually Entered")]
        ManuallyEntered

    }
}
