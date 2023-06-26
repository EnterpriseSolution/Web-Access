#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableInvoiceForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Finance.Entities;
using Matrix.Modules.Common.Enum;
using Matrix.Sales.Entities;

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.AccountsPayableInvoice")]
    [BasedOnRow(typeof(Entities.AccountsPayableInvoiceRow))]
    public class AccountsPayableInvoiceForm
    {
        [Tab(TabName.InvoiceSummary)]
        public String ControlNo { get; set; }
        //public String Miscellaneous { get; set; }
       // public String Posted { get; set; }
       // public String Closed { get; set; }
       // public String Returned { get; set; }
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
        public String InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime ReceivedDate { get; set; }
        public String Period { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }

        [Category(CategoryName.Currency)]
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }

        [Category(CategoryName.PayTerms)]
        public String PayTerms { get; set; }
        [DisplayName("Discount %")]
        public Decimal DiscPercent { get; set; }

        public Decimal DiscDays { get; set; }
        public Decimal NetDays { get; set; }
        public DateTime DiscountDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PlannedDate { get; set; }

        [Category(CategoryName.Totals)]
        [DisplayName("Net Item Amt")]
        public Decimal TotItemAmt { get; set; }
        [DisplayName("Trade Discounts")]
        public Decimal TotTdiscAmt { get; set; }
        [DisplayName("Total Charges")]
        public Decimal TotChgsAmt { get; set; }
        [DisplayName("Net Amt")]
        public Decimal NetTradeAmt { get; set; }

        [DisplayName("Deposits Applied")]
        public Decimal DpsApplied { get; set; }
        [DisplayName("Balance Amt")]
        public Decimal NetBalAmt { get; set; }

        [Tab(TabName.OrderDetails)]
        [AccountsPayableInvoiceOrderEditorAttribute]
        public List<AccountsPayableInvoiceOrderRow> DetailList { get; set; }
        
        [Tab(TabName.ItemDetails)]
        [AccountsPayableInvoiceDetailEditor]
        public List<AccountsPayableInvoiceDetailRow> ItemDetailList { get; set; }
        
        [Tab(TabName.SpecialInstruments)]
        [TextAreaEditor(Rows = 4)]
        public String Particulars { get; set; }


        //public String PaymentBranch { get; set; }
       
        //public Decimal TotPriceAmt { get; set; }
        //public Decimal TotPtaxAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotLdiscAmt { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
        
    
      
        //public Decimal NetOrdrAmt { get; set; }
        //public Decimal TotGtaxAmt { get; set; }
        //public Decimal NetInvoAmt { get; set; }
      
        //public Decimal LocPriceAmt { get; set; }
        //public Decimal LocPtaxAmt { get; set; }
        //public Decimal LocExtPrice { get; set; }
        //public Decimal LocLdiscAmt { get; set; }
        //public Decimal LocAtaxAmt { get; set; }
        //public Decimal LocItemAmt { get; set; }
        //public Decimal LocTdiscAmt { get; set; }
        //public Decimal LocChgsAmt { get; set; }
        //public Decimal LocGtaxAmt { get; set; }
        //public Decimal LocInvoAmt { get; set; }
        //public Decimal LocDpsApplied { get; set; }
        //public Decimal GrnNetAmt { get; set; }
        //public Decimal LgrnNetAmt { get; set; }
        //public Decimal VariaAmt { get; set; }
        //public Decimal LvariaAmt { get; set; }
        //public Decimal ItemVariaAmt { get; set; }
        //public Decimal LitemVariaAmt { get; set; }
        //public Decimal ChgsVariaAmt { get; set; }
        //public Decimal LchgsVariaAmt { get; set; }
        //public Decimal LastLineNo { get; set; }
        ////public DateTime CreatedDate { get; set; }
        ////public String CreatedBy { get; set; }
        ////public DateTime RevisedDate { get; set; }
        ////public String RevisedBy { get; set; }
        ////public DateTime PostedDate { get; set; }
        ////public String PostedBy { get; set; }
        //public String Hold { get; set; }
        //public DateTime HoldUntil { get; set; }
        //public DateTime HoldDate { get; set; }
        //public String HoldBy { get; set; }
        //public String AcctVendor { get; set; }
        //public String AcctTdisc { get; set; }
        //public String AcctGtax { get; set; }
        //public String AcctVariance { get; set; }
        //public Decimal SettledAmt { get; set; }
        //public Decimal LsettledAmt { get; set; }
        //public Decimal TermDiscAmt { get; set; }
        //public Decimal LtermDiscAmt { get; set; }
        //public Decimal ReturnAmt { get; set; }
        //public Decimal LreturnAmt { get; set; }
        //public Decimal BalAmt { get; set; }
        //public Decimal BalAmtLocal { get; set; }
        //public Decimal OverAllocAmt { get; set; }
        //public Decimal LoverAllocAmt { get; set; }
        //public String BatchSelect { get; set; }
        //public String GlLink { get; set; }
        //public String GlLinkType { get; set; }
        //public String GlLinkNo { get; set; }
        //public Decimal LastLogNo { get; set; }
        //public String LockType { get; set; }
        //public String LockRefNo { get; set; }
        //public String HoldReason { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String CheckCrlimit { get; set; }
        //public Decimal CheckCrbal { get; set; }
        //public String AcctPutax { get; set; }
        //public String PutaxType { get; set; }
        //public Decimal GputaxPcent { get; set; }
        //public Decimal TotGputaxAmt { get; set; }
        //public Decimal TotLputaxAmt { get; set; }
        //public Decimal LocGputaxAmt { get; set; }
        //public Decimal LocLputaxAmt { get; set; }
        //public String GrnPutaxType { get; set; }
        //public Decimal GrnGputaxPcent { get; set; }
        //public Decimal GrnCount { get; set; }
        //public String AiLink { get; set; }
        //public String AiLinkType { get; set; }
        //public String AiLinkNo { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
        //public String Anlys15 { get; set; }
        //public String Anlys16 { get; set; }
        //public String Anlys17 { get; set; }
        //public String Anlys18 { get; set; }
        //public String PoNo { get; set; }
        //public String OriginCountry { get; set; }
    }
}