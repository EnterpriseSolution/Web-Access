#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  Depreciation.cs 
// Date: 2015/02/02 21:39

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum Depreciation
    {
        [StringValue("D")]
        [DisplayText("Double Declining Balance")]
        DoubleDecliningBalance,

        [StringValue("S")]
        [DisplayText("Sum of The Years Digits")]
        SumofTheYearsDigits,

        [StringValue("A")]
        [DisplayText("Average of The Years Digits")]
        AverageTheYearsDigits,

        [StringValue("P")]
        [DisplayText("Units of Production")]
        UnitsofProduction,

        [StringValue("L")]
        [DisplayText("Straight Line")]
        StraightLine

    }
}
