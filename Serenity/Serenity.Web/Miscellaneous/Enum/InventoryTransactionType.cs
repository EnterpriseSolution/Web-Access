﻿#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  InventoryTransactionType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum InventoryTransactionType
    {
        [StringValue("MVMT")]
        [DisplayText("Movement")]
        Movement,

        [StringValue("MTIS")]
        [DisplayText("Materials Issue")]
        MaterialsIssue,

        [StringValue("SPIS")]
        [DisplayText("Spares Issue")]
        SparesIssue,

        [StringValue("MTRE")]
        [DisplayText("Materials Return")]
        MaterialsReturn,

        [StringValue("FNGD")]
        [DisplayText("Finished Goods")]
        FinishedGoods,    

        [StringValue("RVAL")]
        [DisplayText("Revaluation")]
        Revaluation
    }
}
