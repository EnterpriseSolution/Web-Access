#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  MrpRequirementType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum MrpRequirementType
    {
        [DisplayText("Sales Order")]
        [StringValue("SALES")]
        SalesOrder,

        [DisplayText("Assortment")]
        [StringValue("ASSORTMENT")]
        Assortment,

        [DisplayText("Material")]
        [StringValue("MATERIAL")]
        Material,

        [DisplayText("Forecast")]
        [StringValue("FORECAST")]
        Forecast,

        [DisplayText("Planned Order")]
        [StringValue("PLAN ORDER")]
        PlannedOrder,

        [DisplayText("Place Holder")]
        [StringValue("LEVELLING")]
        PlaceHolder
    }
}
