#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  MrpMessageType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum MrpMessageType
    {
        [DisplayText("Action")]
        [StringValue("Act")]
        Action,

        [DisplayText("Information")]
        [StringValue("Info")]
        Information,

        [DisplayText("Warning")]
        [StringValue("Warn")]
        Warning
    }
}
