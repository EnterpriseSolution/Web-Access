#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GrnForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;
using Matrix.Purchasing.Entities;

namespace Matrix.Purchasing.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Purchasing.Grn")]
    [BasedOnRow(typeof(Entities.GrnRow))]
    public class GrnForm
    {
        [Tab(TabName.GeneralInformation)]
        public String GrnNo { get; set; }
        public DateTime ReceivedDate { get; set; }
        public String ShipTo { get; set; }
        public Decimal InspectPriority { get; set; }
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
        public DateTime CutoffDate { get; set; }

        [Category(CategoryName.VendorReference)]
        public String DoNo { get; set; }
        public String InvoiceNo { get; set; }

        [Category(CategoryName.Control)]
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }

        [Category(CategoryName.Payment)]
        public String PayTerms { get; set; }
        public Decimal DiscPcent { get; set; }
        public Decimal DiscDays { get; set; }
        public Decimal DueDays { get; set; }

        [Category(CategoryName.CostSummary)]
        [DisplayName("Total Item Amt")]
        public Decimal TotItemAmt { get; set; }

        [DisplayName("Item Purchase Tax Amt")]
        public Decimal TotPtaxAmt { get; set; }
        [DisplayName("Trde Disc Amt")]
        public Decimal TotTdiscAmt { get; set; }
        [DisplayName("Net Trade Amt")]
        public Decimal NetTradeAmt { get; set; }
        [DisplayName("Total Charges")]
        public Decimal TotChgsAmt { get; set; }
        [DisplayName("Net Pay Amt")]
        public Decimal NetPayAmt { get; set; }
        [DisplayName("Deposit Cover")]
        public Decimal DpsCover { get; set; }
        [DisplayName("Deposit Applied")]
        public Decimal DpsApplied { get; set; }
        [DisplayName("Net Balance")]
        public Decimal NetBalAmt { get; set; }


        //public Decimal TotPriceAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotLdiscAmt { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
       
        //public Decimal NetOrdrAmt { get; set; }
        //public Decimal TotGtaxAmt { get; set; }
       

        //public Decimal LocPriceAmt { get; set; }
        //public Decimal LocPtaxAmt { get; set; }
        //public Decimal LocExtPrice { get; set; }
        //public Decimal LocLdiscAmt { get; set; }
        //public Decimal LocAtaxAmt { get; set; }
        //public Decimal LocItemAmt { get; set; }
        //public Decimal LocTdiscAmt { get; set; }
        //public Decimal LocChgsAmt { get; set; }
        //public Decimal LocGtaxAmt { get; set; }
        //public Decimal LocPayAmt { get; set; }
        //public Decimal LocDpsApplied { get; set; }


        [Tab(TabName.GoodsReceived)]
        [GrnOrderDetailEditor]
        public List<GrnOrderRow> OrderDetailList { get; set; }


        //[Tab("Order Details")]
        //[GrnOrderEditor]
        //public List<GrnOrderDetailRow> ItemDetailList { get; set; }

        [Tab(TabName.PurchaseCharges)]

        public String EntryMethod { get; set; }
        public String WithInvoice { get; set; }
        public String Posted { get; set; }
        public String Inspected { get; set; }
        public String Returned { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
     
        public DateTime DiscountDate { get; set; }
        public DateTime DueDate { get; set; }
     
        public String ComputeTax { get; set; }
      
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public Decimal LastOrderNo { get; set; }
        //public Decimal LastEntryNo { get; set; }
        //public Decimal LastChgsNo { get; set; }
        //public String LockType { get; set; }
        //public String LockRefNo { get; set; }
        //public Decimal LastLogNo { get; set; }
        //public String AcctVendor { get; set; }
        //public String AcctTdisc { get; set; }
        //public String AcctGtax { get; set; }
        //public String VendTaxCode { get; set; }
        //public String CustTaxCode { get; set; }
        //public Decimal RetPriceAmt { get; set; }
        //public Decimal RetPtaxAmt { get; set; }
        //public Decimal RetExtPrice { get; set; }
        //public Decimal RetLdiscAmt { get; set; }
        //public Decimal RetAtaxAmt { get; set; }
        //public Decimal RetItemAmt { get; set; }
        //public Decimal RetTdiscAmt { get; set; }
        //public Decimal RetGtaxAmt { get; set; }
        //public Decimal RetChgsAmt { get; set; }
        //public Decimal RetPayAmt { get; set; }
        //public Decimal LretPriceAmt { get; set; }
        //public Decimal LretPtaxAmt { get; set; }
        //public Decimal LretExtPrice { get; set; }
        //public Decimal LretLdiscAmt { get; set; }
        //public Decimal LretAtaxAmt { get; set; }
        //public Decimal LretItemAmt { get; set; }
        //public Decimal LretTdiscAmt { get; set; }
        //public Decimal LretGtaxAmt { get; set; }
        //public Decimal LretChgsAmt { get; set; }
        //public Decimal LretPayAmt { get; set; }
        //public String SettleAt { get; set; }
        //public String CheckCrlimit { get; set; }
        //public Decimal CheckCrbal { get; set; }
        //public String Manual { get; set; }
        //public String PutaxType { get; set; }
        //public Decimal GputaxPcent { get; set; }
        //public Decimal TotGputaxAmt { get; set; }
        //public String PoPutaxType { get; set; }
        //public Decimal PoGputaxPcent { get; set; }
        //public Decimal LocGputaxAmt { get; set; }
        //public Decimal OrderCount { get; set; }
        //public Decimal TotLputaxAmt { get; set; }
        //public Decimal LocLputaxAmt { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Flag { get; set; }
        //public String HoldBy { get; set; }
     
        //public Decimal LastTextNo { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
        //public String Anlys15 { get; set; }
        //public String Anlys16 { get; set; }
        //public String Anlys17 { get; set; }
        //public String Anlys18 { get; set; }
        //public String RefCompanyCode { get; set; }
        //public String RefShipmentRefNo { get; set; }

        [Tab(TabName.SpecialInstruments)]
        [TextAreaEditor(Rows = 4)]
        public String Comments1 { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Comments2 { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Comments3 { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Comments4 { get; set; }
    }
}