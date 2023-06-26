#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  CommissionComputationBase.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum CommissionComputationBase
    {
        [StringValue("A")]
        [DisplayText("Qty")]
        Qty,

        [StringValue("B")]
        [DisplayText("Effective Price")]
        EffectivePrice,

        [StringValue("C")]
        [DisplayText("Discount Amt")]
        DiscountAmt,

        [StringValue("D")]
        [DisplayText("Price Tax")]
        PriceTax,

        [StringValue("E")]
        [DisplayText("Add-on Tax")]
        AddOnTax,

        [StringValue("F")]
        [DisplayText("Standard Cost")]
        StandardCost,

        [StringValue("G")]
        [DisplayText("Actual Cost")]
        ActualCost
    }
}
