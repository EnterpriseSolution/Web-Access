#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  FinishedGoodsCostingLimitation.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FinishedGoodsCostingLimitation
    {
        [StringValue("M")]
        [DisplayText("Material Only")]
        MaterialOnly,

        [StringValue("L")]
        [DisplayText("Material+Labor Only")]
        MaterialLaborOnly,
        
        [StringValue("S")]
        [DisplayText("Material+Labor+Subcontract")]
        MaterialLaborSubcontract,

        [StringValue("A")]
        [DisplayText("Material+Labor+Subcontract+Overhead")]
        MaterialLaborSubcontractOverhead
    }
}
