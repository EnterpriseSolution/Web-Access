#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  CostFormula.cs 
// Date: 2015/10/31 10:33

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum CostFormula
    {
        [StringValue("A")]
        [DisplayText("Qty * Unit Cost")]
        QtyUnitCost,

        [StringValue("B")]
        [DisplayText("Qty * Unit Cost * KM")]
        QtyUnitCostKm,

        [StringValue("C")]
        [DisplayText("Fixed Freight")]
        FixedFreight
    }
}
