#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  CustomDeclarationDirection.cs 
// Date: 2015/01/26 16:12

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum CustomDeclarationDirection
    {
        [StringValue("I")]
        [DisplayText("Import")]
        Import,

        [StringValue("E")]
        [DisplayText("Export")]
        Export
    }
}
