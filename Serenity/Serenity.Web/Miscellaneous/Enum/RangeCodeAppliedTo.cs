#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  RangeCodeAppliedTo.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum RangeCodeAppliedTo
    {
        [StringValue("CCY")]
        [DisplayText("Currency")]
        Currency,

        [StringValue("CUS-ANLYS1")]
        [DisplayText("Customer Analysis 1")]
        CustomerAnalysis1,

        [StringValue("CUS-ANLYS2")]
        [DisplayText("Customer Analysis 2")]
        CustomerAnalysis2,

        [StringValue("CUS-ANLYS3")]
        [DisplayText("Customer Analysis 3")]
        CustomerAnalysis3,

        [StringValue("CUS-ANLYS4")]
        [DisplayText("Customer Analysis 4")]
        CustomerAnalysis4,

        [StringValue("CUSTGRP")]
        [DisplayText("Customer Group")]
        CustomerGroup,

        [StringValue("CUSTOMER")]
        [DisplayText("Customer No.")]
        CustomerNo,

        [StringValue("ITEM")]
        [DisplayText("Item No.")]
        ItemNo,

        [StringValue("LOC")]
        [DisplayText("Shipment Location")]
        ShipmentLocation,

        [StringValue("ORD-ANLYS1")]
        [DisplayText("Order Analysis 1")]
        OrderAnalysis1,

        [StringValue("ORD-ANLYS2")]
        [DisplayText("Order Analysis 2")]
        OrderAnalysis2,

        [StringValue("PRODGRP")]
        [DisplayText("Product Group")]
        ProductGroup,

        [StringValue("SALESMAN")]
        [DisplayText("Salesman No.")]
        SalesmanNo,

        [StringValue("TERMS")]
        [DisplayText("Pay Terms")]
        PayTerms,

        [StringValue("BRANCH-NO")]
        [DisplayText("Branch No.")]
        BranchNo,

        [StringValue("#PRICE")]
        [DisplayText("Base Price in Item Master")]
        BasePriceInItemMaster,

        [StringValue("#MAX-PRICE")]
        [DisplayText("Maximum Price in Item Master")]
        MaximumPriceInItemMaster,

        [StringValue("#MIN-PRICE")]
        [DisplayText("Minimum Price in Item Master")]
        MinimumPriceInItemMaster,

        [StringValue("#PRICEA")]
        [DisplayText("Price A in Item Master")]
        PriceAInItemMaster,

        [StringValue("#PRICEB")]
        [DisplayText("Price B in Item Master")]
        PriceBInItemMaster,

        [StringValue("#PRICEC")]
        [DisplayText("Price C in Item Master")]
        PriceCInItemMaster,

        [StringValue("#QTY")]
        [DisplayText("Qty Ordered")]
        QtyOrdered,

        [StringValue("#SUB-TOTAL")]
        [DisplayText("Computation Sub-Total")]
        ComputationSubTotal
        
    }
}
