#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  FinanceInterfaceExportSeparator.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FinanceInterfaceExportSeparator
    {
        [DisplayText("New Line")]
        [StringValue("NL")]
        NewLine,

        [DisplayText("Tab Character")]
        [StringValue("TAB")]
        TabCharacter,

        [DisplayText("Comma Delimited")]
        [StringValue("COMMA")]
        CommaDelimited
    }
}
