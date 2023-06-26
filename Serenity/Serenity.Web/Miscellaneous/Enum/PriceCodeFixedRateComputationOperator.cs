#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  PriceCodeFixedRateComputationOperator.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum PriceCodeFixedRateComputationOperator
    {
        [StringValue("+")]
        [DisplayText("Add to Base Price")]
        AddToBasePrice,

        [StringValue("-")]
        [DisplayText("Subtract from Base Price")]
        SubtractFromBasePrice,

        [StringValue("*")]
        [DisplayText("Multiply Base Price")]
        MultiplyBasePrice,

        [StringValue("/")]
        [DisplayText("Divide Base Price")]
        DivideBasePrice
    }
}
