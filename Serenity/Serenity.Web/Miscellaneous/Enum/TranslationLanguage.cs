#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  AccoutingReportLayoutType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum TranslationLanguage
    {
        [Description("English")]
        [StringValue("0")]
        English='0',

        [Description("Traditional Chinese")]
        [StringValue("1")]
        TraditionalChinese='1',

        [Description("Simplified Chinese")]
        [StringValue("2")]
        SimplifiedChinese='2'
    }
}
