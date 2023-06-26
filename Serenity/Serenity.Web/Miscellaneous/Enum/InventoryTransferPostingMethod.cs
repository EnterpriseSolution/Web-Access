#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  InventoryTransferPostingMethod.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum InventoryTransferPostingMethod
    {
        [StringValue("S")]
        [DisplayText("Source")]
        Source,

        [StringValue("D")]
        [DisplayText("Destination")]
        Destination,

        [StringValue("O")]
        [DisplayText("Once")]
        Once,

        [StringValue("U")]
        [DisplayText("Undefined")]
        Undefined

    }
}

