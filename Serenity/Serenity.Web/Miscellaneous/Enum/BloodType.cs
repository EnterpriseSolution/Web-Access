#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  BloodType.cs 
// Date: 2015/02/28 22:05

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum BloodType
    {
        [StringValue("A")]
        [DisplayText("A")]
        A,

        [StringValue("B")]
        [DisplayText("B")]
        B,

        [StringValue("AB")]
        [DisplayText("AB")]
        AB,

        [StringValue("O")]
        [DisplayText("O")]
        O
    }
}
