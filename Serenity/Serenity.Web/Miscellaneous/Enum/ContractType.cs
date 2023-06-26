#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  ContractType.cs 
// Date: 2015/02/28 22:00

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum ContractType
    {
        [StringValue("F")]
        [DisplayText("Fixed Time")]
        FixedTime,

        [StringValue("U")]
        [DisplayText("Unlimited Time")]
        UnlimitedTime
    }
}
