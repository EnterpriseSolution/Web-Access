#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  HireType.cs 
// Date: 2015/02/28 21:58

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum HireType
    {
        [StringValue("F")]
        [DisplayText("Full Time")]
        FullTime,

        [StringValue("P")]
        [DisplayText("Part Time")]
        PartTime
    }
}
