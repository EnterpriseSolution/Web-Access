#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  RohsItemType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum RohsItemType
    {
        [StringValue("0")]
        [DisplayText("Low Risk")]
        LowRisk = 0,

        [StringValue("1")]
        [DisplayText("Medium Risk")]
        MediumRisk = 1,

        [StringValue("2")]
        [DisplayText("High Risk")]
        HighRisk = 2
    }
}
