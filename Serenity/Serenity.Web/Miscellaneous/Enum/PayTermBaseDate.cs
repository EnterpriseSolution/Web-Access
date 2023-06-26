#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  PayTermBaseDate.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum PayTermBaseDate
    {
        [StringValue("A")]
        [DisplayText("Invoice Date")]
        InvoiceDate,

        [StringValue("B")]
        [DisplayText("Today's Date")]
        TodayDate,

        [StringValue("C")]
        [DisplayText("End of Month")]
        EndOfMonth,

        [StringValue("D")]
        [DisplayText("15/30th of Month")]
        MidAndEndOfMonth,

        [StringValue("E")]
        [DisplayText("Delivery Date")]
        DeliveryDate
    }
}
