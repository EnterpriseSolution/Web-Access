#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  AccountsReceivableAdjustmentType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum AccountsReceivableAdjustmentType
    {
        [StringValue("R")]
        [DisplayText("Sales Return")]
        SalesReturn,

        [StringValue("M")]
        [DisplayText("Credit Memo")]
        CreditMemo,

        [StringValue("N")]
        [DisplayText("Credit Note")]
        CreditNote
    }
}
