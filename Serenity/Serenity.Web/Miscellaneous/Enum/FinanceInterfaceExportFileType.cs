#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  FinanceInterfaceExportFileType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FinanceInterfaceExportFileType
    {
        [DisplayText("DBase Format")]
        [StringValue("DBF")]
        DBase,

        [DisplayText("Line-delimited Text File")]
        [StringValue("TXT")]
        LineDelimited,

        [DisplayText("Comma-delimited Text File")]
        [StringValue("CSV")]
        CommaDelimited
    }
}
