#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  MassChangeRequestType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum MassChangeRequestType
    {
        [StringValue("A")]
        [DisplayText("Add Component Item")]
        AddComponentItem,

        [StringValue("B")]
        [DisplayText("Change Component Item")]
        ChangeComponentItem,

        [StringValue("C")]
        [DisplayText("Delete Component Items")]
        DeleteComponentItems,

        [StringValue("D")]
        [DisplayText("Add Position")]
        AddPosition,

        [StringValue("E")]
        [DisplayText("Change Pos1")]
        ChangePos1,

        [StringValue("F")]
        [DisplayText("Delete Positions")]
        DeletePositions,

        [StringValue("G")]
        [DisplayText("Change Pos2")]
        ChangePos2,

        [StringValue("H")]
        [DisplayText("Change Position Qty")]
        ChangePositionQty,

        [StringValue("I")]
        [DisplayText("Add Alternate Parts")]
        AddAlternateParts
    }
}
