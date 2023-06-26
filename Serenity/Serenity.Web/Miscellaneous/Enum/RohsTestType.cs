#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  RohsTestType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum RohsTestType
    {
        [StringValue("0")]
        [DisplayText("Internal Lab")]
        InternalLab = 0,

        [StringValue("1")]
        [DisplayText("External Lab")]
        ExternalLab = 1,

        [StringValue("2")]
        [DisplayText("Supplier Lab")]
        SupplierLab = 2
    }
}
