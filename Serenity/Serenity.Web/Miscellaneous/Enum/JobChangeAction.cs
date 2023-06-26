#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  JobChangeAction.cs 
// Date: 2015/05/25 21:41

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum JobChangeAction
    {
        [StringValue("P")]
        [DisplayText("Promote")]
        P,

        [StringValue("D")]
        [DisplayText("Demotion")]
        D,

        [StringValue("T")]
        [DisplayText("Job Transfer")]
        T,

        [StringValue("N")]
        [DisplayText("None")]
        N
    }

}
