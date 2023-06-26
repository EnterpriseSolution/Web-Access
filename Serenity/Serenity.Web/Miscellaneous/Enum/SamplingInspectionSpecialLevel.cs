#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  SamplingInspectionSpecialLevel.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum SamplingInspectionSpecialLevel
    {
        [StringValue("1")]
        [DisplayText("Level 1")]
        Level1,

        [StringValue("2")]
        [DisplayText("Level 2")]
        Level2,

        [StringValue("3")]
        [DisplayText("Level 3")]
        Level3,

        [StringValue("4")]
        [DisplayText("Level 4")]
        Level4,
    }
}
