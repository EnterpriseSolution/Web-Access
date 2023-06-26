#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  EstimationBasis.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum EstimationBasis
    {
        [StringValue("A")]
        [DisplayText("Operations Standard")]
        Operations,

        [StringValue("B")]
        [DisplayText("Work Centre Standard")]
        WorkCentre,

        [StringValue("C")]
        [DisplayText("Routing Standards")]
        Routing
    }
}
