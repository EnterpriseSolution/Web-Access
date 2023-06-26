#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  PriceCodeFormulaComputationBase.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum PriceCodeFormulaComputationBase
    {
        [StringValue("BASE PRICE")]
        [DisplayText("Base Price in Item Master")]
        BasePriceInItemMaster,

        [StringValue("ACT COST")]
        [DisplayText("Inventory Cost at Shipment Location")]
        InventoryCostAtShipmentLocation,

        [StringValue("LAT COST")]
        [DisplayText("Latest Cost at Shipment Location")]
        LatestCostAtShipmentLocation,

        [StringValue("STD COST")]
        [DisplayText("Standard Cost in Item Master")]
        StandardCostInItemMaster,

        [StringValue("MAX PRICE")]
        [DisplayText("Maximum Price in Item Master")]
        MaximumPriceInItemMaster,

        [StringValue("MIN PRICE")]
        [DisplayText("Minimum Price in Item Master")]
        MinimumPriceInItemMaster,

        [StringValue("PRICEA")]
        [DisplayText("Price A in Item Master")]
        PriceAInItemMaster,

        [StringValue("PRICEB")]
        [DisplayText("Price B in Item Master")]
        PriceBInItemMaster,

        [StringValue("PRICEC")]
        [DisplayText("Price C in Item Master")]
        PriceCInItemMaster,

        [StringValue("QTY")]
        [DisplayText("Qty Ordered")]
        QtyOrdered,

        [StringValue("CONSTANT")]
        [DisplayText("Constant Value")]
        ConstantValue
    }
}
