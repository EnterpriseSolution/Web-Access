#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  DimensionUOM.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased")]
    public enum DimensionUOM
    {
        [StringValue("cm")]
        [DisplayText("cm")]
        Centimeter,

        [StringValue("m")]
        [DisplayText("m")]
        Meter,

        [StringValue("in")]
        [DisplayText("in")]
        Inch,

        [StringValue("ft")]
        [DisplayText("ft")]
        Feet
    }
}
