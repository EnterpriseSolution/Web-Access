#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  EmployeeTrainingMethod.cs 
// Date: 2015/03/01 9:01

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum EmployeeTrainingMethod
    {
        [StringValue("I")]
        [DisplayText("In-House")]
        Contracted,

        [StringValue("O")]
        [DisplayText("On-Site")]
        UnlimitedTime
    }
}
