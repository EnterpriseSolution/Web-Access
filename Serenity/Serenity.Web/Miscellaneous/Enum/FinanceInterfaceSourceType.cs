#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  FinanceInterfaceSourceType.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FinanceInterfaceSourceType
    {
        [StringValue("SL Quote")]
        [DisplayText("Sales Quotation")]
        SalesQuotation = 0,

        [StringValue("Price List")]
        [DisplayText("Sales Price List")]
        SalesPriceList = 1,

        [StringValue("SL Order")]
        [DisplayText("Sales Order")]
        SalesOrder = 2,

        [StringValue("SL Ship")]
        [DisplayText("Sales Shipment")]
        SalesShipment = 3,

        [StringValue("SL Return")]
        [DisplayText("Sales Return")]
        Salesreturn = 4,

        [StringValue("PU Order")]
        [DisplayText("Purchase Order")]
        PurchaseOrder = 5,

        [StringValue("PU Receipt")]
        [DisplayText("Purchase Receipt")]
        PurchaseReceipt = 6,

        [StringValue("PU Inspect")]
        [DisplayText("Purchase Inspection")]
        PurchaseInspection = 7,

        [StringValue("PU Return")]
        [DisplayText("Purchase Return")]
        Purchasereturn = 8,

        [StringValue("AR Invo")]
        [DisplayText("A/R Invoice")]
        ArInvoice = 9,

        [StringValue("AR Memo")]
        [DisplayText("A/R Credit Memo")]
        ArCreditMemo = 10,

        [StringValue("AR Adj")]
        [DisplayText("A/R Adjustment")]
        ArAdjustment = 11,

        [StringValue("AR Payment")]
        [DisplayText("A/R Payment Receipt")]
        ArPaymentReceipt = 12,

        [StringValue("SL Deposit")]
        [DisplayText("A/R Deposit Receipt")]
        ArDepositReceipt = 13,

        [StringValue("AR Alloc")]
        [DisplayText("A/R Open Credit Allocation")]
        ArOpenCreditAllocation = 14,

        [StringValue("AR Invocan")]
        [DisplayText("A/R Invoice Cancellation")]
        ArInvoiceCancellation = 15,

        [StringValue("AR Paycan")]
        [DisplayText("A/R Payment Cancellation")]
        ArPaymentCancellation = 16,

        [StringValue("AR Cnote")]
        [DisplayText("A/R Credit Note")]
        ArCreditNote = 17,

        [StringValue("AR Dnote")]
        [DisplayText("A/R Debit Note")]
        ArDebitNote = 18,

        [StringValue("AR Sales")]
        [DisplayText("A/R Sales")]
        ArSales = 19,

        [StringValue("Term Disc")]
        [DisplayText("Term Discount")]
        TermDiscount = 20,

        [StringValue("Exch Diff")]
        [DisplayText("Exchange Difference")]
        ExchangeDifference = 21,

        [StringValue("Round Diff")]
        [DisplayText("Rounding Difference")]
        RoundingDifference = 22,

        [StringValue("AP Inv")]
        [DisplayText("A/P Invoice")]
        ApInvoice = 23,

        [StringValue("AP Memo")]
        [DisplayText("A/P Debit Memo")]
        ApDebitMemo = 24,

        [StringValue("AP Adj")]
        [DisplayText("A/P Adjustment")]
        ApAdjustment = 25,

        [StringValue("AP Payment")]
        [DisplayText("A/P Payment")]
        ApPayment = 26,

        [StringValue("PU Deposit")]
        [DisplayText("A/P Deposit")]
        ApDeposit = 27,

        [StringValue("AP Alloc")]
        [DisplayText("A/P Open Debit Allocation")]
        ApOpenDebitAllocation = 28,

        [StringValue("AP Invocan")]
        [DisplayText("A/P Invoice Cancellation")]
        ApInvoiceCancellation = 29,

        [StringValue("AP Paycan")]
        [DisplayText("A/P Payment Cancellation")]
        ApPaymentCancellation = 30,

        [StringValue("AP Purchase")]
        [DisplayText("A/P Purchase")]
        ApPurchase = 31,

        [StringValue("AP Cnote")]
        [DisplayText("A/P Credit Note")]
        ApCreditNote = 32,

        [StringValue("AP Dnote")]
        [DisplayText("A/P Debit Note")]
        ApDebitNote = 33,

        [StringValue("IC Issuance")]
        [DisplayText("Inventory Issuance")]
        InventoryIssuance = 34,

        [StringValue("IC Receipt")]
        [DisplayText("Inventory Receipt")]
        InventoryReceipt = 35,

        [StringValue("IC Transfer")]
        [DisplayText("Inventory Transfer")]
        InventoryTransfer = 36,

        [StringValue("IC Adjustmen")]
        [DisplayText("Inventory Adjustment")]
        InventoryAdjustment = 37,

        [StringValue("Revaluation")]
        [DisplayText("Inventory Revaluation")]
        InventoryRevaluation = 38,

        [StringValue("Cycle Count")]
        [DisplayText("Inventory Cycle Count")]
        InventoryCycleCount = 39,

        [StringValue("Job Order")]
        [DisplayText("Job Order")]
        JobOrder = 40,

        [StringValue("Ticketing")]
        [DisplayText("Job Ticket")]
        JobTicket = 41,

        [StringValue("Kit Issue")]
        [DisplayText("Materials Kit Issue")]
        MaterialsKitIssue = 42,

        [StringValue("Spares Issue")]
        [DisplayText("Material Spares Issue")]
        MaterialSparesIssue = 43,

        [StringValue("FG Returned")]
        [DisplayText("Finished Goods Returned")]
        FinishedGoodsReturned = 44,

        [StringValue("RM Return")]
        [DisplayText("Materials Return")]
        MaterialsReturn = 45,

        [StringValue("Production")]
        [DisplayText("Production")]
        Production = 46,

        [StringValue("Subcontract")]
        [DisplayText("Subcontracting")]
        Subcontracting = 47,

        [StringValue("Completion")]
        [DisplayText("Work Completion")]
        WorkCompletion = 48,

        [StringValue("RM Transfer")]
        [DisplayText("Materials Transfer")]
        MaterialsTransfer = 49,

        [StringValue("Consumption")]
        [DisplayText("Materials Consumption")]
        MaterialsConsumption = 50,

        [StringValue("Scrappage")]
        [DisplayText("Materials Scrappage")]
        MaterialsScrappage = 51,

        [StringValue("Assembly")]
        [DisplayText("Assembly Entry")]
        AssemblyEntry = 52,

        [StringValue("Job Closing")]
        [DisplayText("Job Closing")]
        JobClosing = 53,

        [StringValue("MRP Release")]
        [DisplayText("MRP Releasing")]
        MRPReleasing = 54,
    }
}
