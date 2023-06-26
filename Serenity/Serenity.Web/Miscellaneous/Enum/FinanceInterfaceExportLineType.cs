#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  FinanceInterfaceExportLineType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FinanceInterfaceExportLineType
    {
        [DisplayText("Header Information")]
        [StringValue("H")]
        Header,

        [DisplayText("Detail Information")]
        [StringValue("D")]
        Detail
    }
}
