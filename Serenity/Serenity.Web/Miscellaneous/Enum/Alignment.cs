#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  Alignment.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum Alignment
    {
        [StringValue("C")]
        [DisplayText("Center")]
        Center,

        [StringValue("L")]
        [DisplayText("Left")]
        Left,

        [StringValue("R")]
        [DisplayText("Right")]
        Right
    }
}
