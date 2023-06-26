#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  OrderPolicy.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum OrderPolicy
    {
        [StringValue("LFL")]
        [DisplayText("Lot for Lot")]
        LotForLot,

        [StringValue("LOM")]
        [DisplayText("Order Multiple Lot for Lot")]
        MultipleLotForLot,

        [StringValue("PRQ")]
        [DisplayText("Periodic Requirements")]
        [HiddenEnum(true)]
        PeriodicRequirements,

        [StringValue("FPRQ")]
        [DisplayText("Fixed Qty per Period")]
        [HiddenEnum(true)]
        FixedQtyPerPeriod,

        [StringValue("ROP")]
        [DisplayText("Reorder Point")]
        ReorderPoint
    }
}
