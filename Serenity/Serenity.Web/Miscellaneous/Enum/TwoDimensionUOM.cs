#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  TwoDimensionUOM.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased")]
    public enum TwoDimensionUOM
    {   
        [StringValue("sqcm")]
        [DisplayText("sqcm")]
        SquareCentimeter,

        [StringValue("sqm")]
        [DisplayText("sqm")]
        SquareMeter,

        [StringValue("sqin")]
        [DisplayText("sqin")]
        SquareInch,

        [StringValue("sqft")]
        [DisplayText("sqft")]
        SquareFeet
    }
}
