#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  PackingVolumeDimensionUOM.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1705:LongAcronymsShouldBePascalCased")]
    public enum PackingVolumeDimensionUOM
    {
        [StringValue("cbm")]
        [DisplayText("cbm")]
        CubicMeter,

        [StringValue("cft")]
        [DisplayText("cft")]
        CubicFeet
    }
}
