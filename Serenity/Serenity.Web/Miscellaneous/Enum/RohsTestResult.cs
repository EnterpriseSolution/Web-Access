#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  RohsTestResult.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum RohsTestResult
    {
        [StringValue("0")]
        [DisplayText("Failed")]
        Failed = 0,

        [StringValue("1")]
        [DisplayText("Passed")]
        Passed = 1
    }
}
