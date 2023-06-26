#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  InventoryFlowType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum InventoryFlowType
    {
        [StringValue("R")]
        [DisplayText("Receipt")]
        Receipt,

        [StringValue("I")]
        [DisplayText("Issue")]
        Issue,

        [StringValue("T")]
        [DisplayText("Transfer")]
        Transfer,

        [StringValue("A")]
        [DisplayText("Adjustment")]
        Adjustment,

        [StringValue("V")]
        [DisplayText("Revaluation")]
        Revaluation
             
    }
}
