#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  SamplingInspectionConclusion.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum SamplingInspectionConclusion
    {
        [StringValue("N")]
        [DisplayText("No decision yet")]
        NoDecisionYet,

        [StringValue("A")]
        [DisplayText("Reject All")]
        RejectAll,

        [StringValue("B")]
        [DisplayText("Accept All")]
        AcceptAll,

        [StringValue("I")]
        [DisplayText("Accept Partially For Urgent Case")]
        AcceptPartiallyForUrgentCase,

        [StringValue("C")]
        [DisplayText("Accept But Reclassify Item")]
        AcceptButReclassifyItem,

        [StringValue("D")]
        [DisplayText("Accept With Sorting")]
        AcceptWithSorting,

        [StringValue("E")]
        [DisplayText("Accept With Conditions")]
        AcceptWithConditions,

        [StringValue("H")]
        [DisplayText("Accept For Other Reasons")]
        AcceptForOtherReasons,

        [StringValue("F")]
        [DisplayText("Rework With Pro-Rated Rebate")]
        ReworkWithProRatedRebate,

        [StringValue("G")]
        [DisplayText("Rework With Rebate on Total Cost")]
        ReworkWithRebateOnTotalCost,

        [StringValue("J")]
        [DisplayText("RTV and Supplement")]
        RTVAndSupplement,

        [StringValue("K")]
        [DisplayText("RTV and Charge Cost")]
        RTVAndChargeCost,

        [StringValue("L")]
        [DisplayText("UAI (Use As Is) or Waive")]
        UAIOrWaive,

        [StringValue("M")]
        [DisplayText("Sorting or Reworking by Supplier")]
        SortingOrReworkingBySupplier,

        [StringValue("Q")]
        [DisplayText("Sorting or Reworking by Quasar Product Line")]
        SortingOrReworkingByQuasarProductLine,

        [StringValue("P")]
        [DisplayText("Quasar Sort or Rework for Supplier")]
        QuasarSortOrReworkingForSupplier,

        [StringValue("O")]
        [DisplayText("Other")]
        Other

    }
}
