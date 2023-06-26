#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  UnfullPackedAction.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum UnfullPackedAction
    {
        [StringValue("E")]
        [DisplayText("Warning and Cannot Save")]
        Error,

        [StringValue("W")]
        [DisplayText("Warning")]
        Warning,

        [StringValue("I")]
        [DisplayText("No Action")]
        Ignore
    }
}
