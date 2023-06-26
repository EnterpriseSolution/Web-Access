#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  UserType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum UserType
    {
        [StringValue("G")]
        [DisplayText("Group")]
        Group,     

        [StringValue("U")]
        [DisplayText("User")]
        User
    }
}
