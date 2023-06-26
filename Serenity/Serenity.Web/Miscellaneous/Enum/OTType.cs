#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  OTType.cs 
// Date: 2015/03/01 9:12

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum OTType
    {
        [StringValue("1")]
        [DisplayText("1.5 Times")]
        OT15,

        [StringValue("2")]
        [DisplayText("2.0 Times")]
        OT20,

        [StringValue("3")]
        [DisplayText("3.0 Times")]
        OT30
    }
}
