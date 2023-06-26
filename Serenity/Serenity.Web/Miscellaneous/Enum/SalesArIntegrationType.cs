#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  SalesArIntegrationType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1706:ShortAcronymsShouldBeUppercase")]
    public enum SalesArIntegrationType
    {
        [StringValue("A")]
        [DisplayText("Auto")]
        Auto,

        [StringValue("B")]
        [DisplayText("Two-Steps")]
        TwoSteps,

        [StringValue("C")]
        [DisplayText("Selective - Default Auto")]
        SelectiveDefaultAuto,

        [StringValue("D")]
        [DisplayText("Selective - Default Two-Steps")]
        SelectiveDefaultTwoSteps
    }
}
