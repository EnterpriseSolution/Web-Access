#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  AutoLicenseType.cs 
// Date: 2015/10/30 19:22

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum AutoLicenseType
    {
        [StringValue("A")]
        [DisplayText("A1")]
        A1,

        [StringValue("B")]
        [DisplayText("A2")]
        A2,

        [StringValue("C")]
        [DisplayText("A3")]
        A3,

        [StringValue("J")]
        [DisplayText("B1")]
        B1,

        [StringValue("K")]
        [DisplayText("B2")]
        B2,

        [StringValue("F")]
        [DisplayText("C1")]
        C1,
        
        [StringValue("G")]
        [DisplayText("C2 ")]
        C2,

        [StringValue("H")]
        [DisplayText("C3")]
        C3,


        [StringValue("I")]
        [DisplayText("C4")]
        C4,

        [StringValue("D")]
        [DisplayText("D")]
        D,

        [StringValue("E")]
        [DisplayText("E")]
        E,

        [StringValue("M")]
        [DisplayText("M")]
        M,

        [StringValue("N")]
        [DisplayText("N")]
        N,

        [StringValue("P")]
        [DisplayText("P")]
        P
    }
}
