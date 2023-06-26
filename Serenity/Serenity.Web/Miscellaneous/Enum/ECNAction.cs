#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  ECNAction.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum ECNAction
    {
        [StringValue("A")]
        [DisplayText("Add")]
        Add,

        [StringValue("C")]
        [DisplayText("Change")]
        Change,

        [StringValue("D")]
        [DisplayText("Delete")]
        Delete
    }
}
