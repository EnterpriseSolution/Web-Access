#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  SeriesCode.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum SeriesCode
    {
        [StringValue("GLARIM")]
        [DisplayText("Customer Invoice Registry")]
        CustomerInvoice,

        [StringValue("GLARDN")]
        [DisplayText("Debit Note")]
        DebitNote,

        [StringValue("PUGRRE")]
        [DisplayText("GRN")]
        GRN,

        [StringValue("ICIMSI")]
        [DisplayText("Inventory Issue")]
        InventoryIssue,

        [StringValue("PRPMJE")]
        [DisplayText("Job Order")]
        JobOrder,

        [StringValue("SQPRTJO")]
        [DisplayText("Job Order Enquiry")]
        JobOrderEnquiry,

        [StringValue("PRPMMI")]
        [DisplayText("Material Kit Issue")]
        MaterialKitIssue,

        [StringValue("PRPMME")]
        [DisplayText("Mold Order")]
        MoldOrder,

        [StringValue("GLAPAA")]
        [DisplayText("Open Debit Allocation")]
        OpenDebitAllocation,

        [StringValue("GLARAA")]
        [DisplayText("Open Credit Allocation")]
        OpenCreditAllocation,

        [StringValue("PUPOOE")]
        [DisplayText("Purchase Order")]
        PurchaseOrder,

        [StringValue("SLSOJED")]
        [DisplayText("SLSOJED")]
        SLSOJED,

        [StringValue("SLSOSO")]
        [DisplayText("Sales Order")]
        SalesOrder,

        [StringValue("PRPMSE")]
        [DisplayText("Sub Job Order")]
        SubJobOrder,

        [StringValue("GLTRVP")]
        [DisplayText("Voucher")]
        Voucher
    }
}
