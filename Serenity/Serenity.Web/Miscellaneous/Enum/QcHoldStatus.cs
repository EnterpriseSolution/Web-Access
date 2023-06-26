#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  QcHoldStatus.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum QcHoldStatus
    {
        [StringValue("N/A")]
        [DisplayText("N/A")]
        NotApplicable,

        [StringValue("Pending")]
        [DisplayText("Pending")]
        Pending,

        [StringValue("T/A")]
        [DisplayText("T/A")]
        TotallyAccepted,

        [StringValue("P/A")]
        [DisplayText("P/A")]
        PartiallyAccepted,

        [StringValue("T/R")]
        [DisplayText("T/R")]
        TotallyRejected
    }
}
