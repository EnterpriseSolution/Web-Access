#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  InventoryReturnType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum InventoryReturnType
    {
        [StringValue("0")]
        [DisplayText("Inventory Receipt")]
        InventoryReceipt,

        [StringValue("0")]
        [DisplayText("Inventory Issue")]
        InventoryIssue,

        [StringValue("1")]
        [DisplayText("Inventory Return")]
        InventoryReturn,

        [StringValue("1")]
        [DisplayText("Sales Return")]
        SalesReturn,

        [StringValue("2")]
        [DisplayText("Material Return")]
        MaterialReturn,

        [StringValue("3")]
        [DisplayText("Inventory Transfer")]
        InventoryTransfer,

        [StringValue("4")]
        [DisplayText("Inspection Transfer Issue")]
        InspectionTransferIssue,

        [StringValue("4")]
        [DisplayText("Inspection Transfer Receipt")]
        InspectionTransferReceipt
             
    }
}
