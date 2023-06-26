#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  RecordActionTaken.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum RecordActionTaken
    {
        [StringValue("NEW")]
        [DisplayText("New")]
        New,

        [StringValue("CHANGED")]
        [DisplayText("Changed")]
        Changed,

        [StringValue("DELETED")]
        [DisplayText("Deleted")]
        Deleted,

        [StringValue("CANCELLED")]
        [DisplayText("Cancelled")]
        Cancelled
    }
}
