#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  SalaryCategory.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum SalaryCategory
    {
        [StringValue("M")]
        [DisplayText("Monthly")]
        Monthly,

        [StringValue("W")]
        [DisplayText("Weekly")]
        Weekly,

        [StringValue("D")]
        [DisplayText("Daily")]
        Daily,

        [StringValue("H")]
        [DisplayText("Hourly")]
        Hourly
    }
}
