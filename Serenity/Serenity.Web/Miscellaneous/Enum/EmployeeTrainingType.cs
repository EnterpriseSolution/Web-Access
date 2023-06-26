#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  EmployeeTrainingType.cs 
// Date: 2015/03/01 8:52

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum EmployeeTrainingType
    {
        [StringValue("C")]
        [DisplayText("Contracted")]
        Contracted,

        [StringValue("R")]
        [DisplayText("Regular")]
        UnlimitedTime
    }
}
