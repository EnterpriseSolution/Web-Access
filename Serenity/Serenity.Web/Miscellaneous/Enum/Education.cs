#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  Education.cs 
// Date: 2015/05/26 19:28

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{

    public enum Education
    {
        [StringValue("P")]
        [DisplayText("Primary School")]
        P,

        [StringValue("M")]
        [DisplayText("Middle School")]
        M,

        [StringValue("S")]
        [DisplayText("Senior Middle")]
        S,

        [StringValue("B")]
        [DisplayText("Bachelor")]
        B,

        [StringValue("R")]
        [DisplayText("Master")]
        R,

        [StringValue("D")]
        [DisplayText("Doctor")]
        D
    }
}
