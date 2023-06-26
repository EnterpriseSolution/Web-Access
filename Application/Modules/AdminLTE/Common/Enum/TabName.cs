#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TabName.cs
// Date: 2018/04/03 20:51

#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Matrix.Modules.Common.Enum
{
    public abstract class TabName
    {
        public const string JobCosting = "Job Costing";

        public const string General = "General";
        public const string PlanningData = "Planning Data";
        public const string GlobalControls = "Global Controls";

        public const string VoucherAdjustment = "Voucher Adjustment";

        public const string GeneralInformation = "General Information";
        public const string ProcessingInformation = "Processing Information";
        public const string DistributionData = "Distribution Data";
        public const string CompanyAddress = "Company Address";
        public const string Production = "Production";
        public const string InvoiceSummary = "Invoice Summary";

        public const string Pricing = "Pricing";

        public const string Engineering = "Engineering";

        public const string Details = "Details";
        public const string ItemDetails = "Item Details";
        public const string QuoteDetails = "Quote Details";
        public const string CommonDefaults = "Common Defaults";

        public const string Ledger = "Ledger";
        public const string ProductionControl = "Production Control";
        public const string ShipmentDetails = "Shipment Details";
        public const string ShipmentCharges = "Shipment Charges";
        public const string RequestDetails = "Request Details";
        public const string InspectionDetails = "Inspection Details";
        public const string ReOrderInstructions = "Re-Order Instructions";

        public const string Schedule = "Schedule";

        public const string Analysis = "Analysis";
        public const string UserDefinedField = "User Defined";

        public const string Finance = "Finance";
        public const string Restrict = "Restrict";
        public const string Costing = "Costing";
        public const string CostingSummary = "Costing Summary";
        public const string CostSummary = "Cost Summary";

        public const string Account = "Account";
        public const string Calculation = "Calculation";
        public const string Computation = "Computation";

        public const string Inventory = "Inventory";
        public const string InvoiceDetails = "Invoice Details";

        public const string OrderDetails = "Order Details";
        public const string SpecialInstruments = "Special Instruments";
        public const string OrderSummary = "Order Summary";
        public const string SpecialCharges = "Special Charges";

        public const string SalesSummary = "Sales Summary";
        public const string Sales = "Sales";
        public const string Purchasing = "Purchasing";

        public const string PurchaseSummary = "Purchase Summary";
        public const string GoodsReceived = "Goods Received";
        public const string PurchaseCharges = "Purchase Charges";

    }

    public abstract class CategoryName
    {
        public const string UsefulDefaults = "Useful Defaults";
        public const string UnitofMeasure = "Unit of Measure";

        public const string PreferredVendors = "Preferred Vendors";
        public const string VendorAddress = "Vendor Address";
        public const string VendorReference = "Vendor Reference";
        public const string GoodsReceived = "Goods Received";
        public const string SalesOrderFeatures = "Sales Order Features";

        public const string Pricing = "Pricing";
        public const string Computation = "Computation";
        public const string CurrentAccountDetail = "Current Account Details";
        public const string Specification = "Specification";
        public const string PurchaseOrderFeatures = "Purchase Order Features";
        public const string ProductionMaterialControl = "Production/Material Control";

        public const string Dates = "Dates";
        public const string Publish = "Publish";

        public const string Definition = "Definition";


        public const string Costing = "Costing";
        public const string BasicInformation = "Basic Information";
        public const string AlternateInformation = "Alternate Information";

        public const string Address = "Address";
        public const string Order = "Order";
        public const string Ordering = "Ordering";
        public const string Budget = "Budget";
        public const string TransactionVoucher = "Transaction Voucher";


        public const string ManLoadHr = "Man Hours";

        public const string MachineHr = "Machine Hours";
        
        public const string BuyerControl = "Buyer Control";

        public const string Control = "Control";
        public const string CostSummary = "Cost Summary";
        public const string CostBalance = "Cost Balance";

        public const string CostAdjustmentSummary = "Cost Adjustment Summary";

        public const string Contact = "Contact";
        public const string Alternative = "Alternative Information ";
        public const string Intercompany = "Inter Company";

        public const string Shipping = "Shipping";
        public const string CurrencyAndTerms = "Currency and Terms";

        public const string Currency = "Currency";
        public const string InvoiceTotals = "Invoice Totals";
        public const string DepositTracking = "Deposit Tracking";
        public const string DepositRequirement = "Deposit Requirement";
        public const string DepositDetails = "Deposit Details";
        public const string Totals = "Totals";
        
        public const string Destination = "Destination";
        public const string Payment = "Payment";
        public const string AutomaticPODetails = "Automatic PO Details";
        public const string LeadTimeDefaults = "Lead Time Defaults";
        public const string Misc = "Misc";
        public const string PayTerms = "Pay Terms";

        public const string Options = "Options";
        public const string Details = "Details";
        public const string Ledger = "Ledger";
        public const string ProductionControl = "Production Control";
        public const string PreSetTextTypes = "Pre-Set Text Types";

        public const string Analysis = "Analysis";

        public const string Account = "Account Information";
        public const string OrderDeposit = "Order Deposit";

        public const string AccountPayable = "Account Payable";
        public const string AccountReceivable = "Account Receivable";

        public const string Restrict = "Restrict";
        public const string Require = "Require";

        public const string Phase1 = "Phase1";
        public const string Phase2 = "Phase2";
        public const string Phase3 = "Phase3";
        public const string Phase4 = "Phase4";
        public const string Phase5 = "Phase5";

        public const string Prohibit = "Prohibit";
        public const string OperationNotAllow = "Operation Not Allow";

        public const string Inventory = "Inventory";
        public const string Quantity = "Quantity";
        public const string InterModuleControls = "Inter-Module Controls";

        public const string NotAllowJobCategory = "Not Allow Job Category";
        public const string PictureDescriptions = "Picture Descriptions";
        public const string DefaultMovementTypes = "Default Movement Types";

        public const string ControlChecklist = "Control Checklist";

        public const string RequiredJobCategory = "Required Job Category";

        public const string InventoryLocations = "Inventory Locations";
        public const string GeneralClassifications = "General Classifications";
        public const string ClientTransactions = "Client Transactions";
        public const string DepartmentCodes = "Department Codes";
        public const string Movement = "Movement";

        public const string Transfer = "Transfer";
        public const string Transaction = "Transaction";
        public const string Local = "Local";
        public const string Entry = "Entry";

    }
}