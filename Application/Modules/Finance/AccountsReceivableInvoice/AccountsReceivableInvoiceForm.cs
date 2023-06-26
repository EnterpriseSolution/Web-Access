#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableInvoiceForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Finance.Entities;
using Matrix.Modules.Common.Enum;
using Matrix.Sales.Entities;
using Serenity.Data.Mapping;

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.AccountsReceivableInvoice")]
    [BasedOnRow(typeof(Entities.AccountsReceivableInvoiceRow))]
    public class AccountsReceivableInvoiceForm
    {
        [Tab(TabName.GeneralInformation)]
        public String InvoiceNo { get; set; }
        public DateTime InvoiceDate { get; set; }
        public String CustomerNo { get; set; }
        public String CustomerName { get; set; }

        [Category(CategoryName.Destination)]
        public String ShipTo { get; set; }
        public String Attention { get; set; }
        public String Address { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String TelNo { get; set; }
        public String FaxNo { get; set; }

        [Category(CategoryName.Payment)]
        public String PayTerms { get; set; }
        public Decimal DiscDays { get; set; }
        [DisplayName("Discount %")]
        public Decimal DiscPcent { get; set; }
        [DisplayName("Discount Date")]
        //public Decimal DueDays { get; set; }
        public DateTime DiscountDate { get; set; }
        [DisplayName("Due Date")]
        public DateTime DueDate { get; set; }
        [DisplayName("Expected Date")]
        public DateTime ExpectedDate { get; set; }

        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }

        [Category(CategoryName.InvoiceTotals)]

        [DisplayName("Trade Discount %")]
        public Decimal TdiscPcent { get; set; }
        [DisplayName("Net Trade Amt")]
        public Decimal NetTradeAmt { get; set; }
        [DisplayName("Total Charges")]
        public Decimal ChgsAmt { get; set; }
        [DisplayName("Net Order Amt")]
        public Decimal NetOrdrAmt { get; set; }

        [DisplayName("Net Amt")]
        public Decimal NetAmt { get; set; }
        [DisplayName("Deposit Applied")]
        public Decimal DpsApplied { get; set; }
        [DisplayName("Balance Amt")]
        public Decimal BalAmt { get; set; }

        //public Decimal TdiscAmt { get; set; }

        //public Decimal ShipAmt { get; set; }
        //public Decimal LshipAmt { get; set; }
        //public Decimal VariaAmt { get; set; }
        //public Decimal LvariaAmt { get; set; }
        //public Decimal ItemVariaAmt { get; set; }
        //public Decimal LitemVariaAmt { get; set; }
        //public Decimal ChgsVariaAmt { get; set; }
        //public Decimal LchgsVariaAmt { get; set; }


        //public Decimal TotLdiscAmt { get; set; }
        //public Decimal LocLdiscAmt { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
        //public Decimal LocAtaxAmt { get; set; }
        //public Decimal TotItemAmt { get; set; }

        //public Decimal LocItemAmt { get; set; }


        //public Decimal LocChgsAmt { get; set; }
        //public Decimal GtaxAmt { get; set; }
        //public Decimal LocalGtaxAmt { get; set; }

        //public Decimal LocalNetAmt { get; set; }
        //public Decimal TdiscAmtCpd { get; set; }

        //public String DirectEntry { get; set; }
        //public String Posted { get; set; }
        //public String Closed { get; set; }
        //public String Returned { get; set; }
        //public String DebitNote { get; set; }


        //public String Period { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        //public String Salesman { get; set; }



        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public Decimal TotPriceAmt { get; set; }
        //public Decimal LocPriceAmt { get; set; }
        //public Decimal TotPtaxAmt { get; set; }
        //public Decimal LocPtaxAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal LocExtPrice { get; set; }

        //public Decimal LocalTdiscAmt { get; set; }

        //public Decimal LastLineNo { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public Decimal LastLogNo { get; set; }
        //public Decimal SettledAmt { get; set; }
        //public Decimal LsettledAmt { get; set; }
        //public Decimal TermDiscAmt { get; set; }
        //public Decimal LtermDiscAmt { get; set; }
        //public Decimal ReturnAmt { get; set; }
        //public Decimal LreturnAmt { get; set; }

        //public Decimal BalAmtLocal { get; set; }
        //public Decimal OverAllocAmt { get; set; }
        //public Decimal LoverAllocAmt { get; set; }
        //public String AcctCustomer { get; set; }
        //public String AcctTdisc { get; set; }
        //public String AcctGtax { get; set; }
        //public String LockType { get; set; }
        //public String LockRefNo { get; set; }
        //public String BatchSelect { get; set; }
        //public String GlLink { get; set; }
        //public String GlLinkType { get; set; }
        //public String GlLinkNo { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String CheckCrlimit { get; set; }
        //public Decimal CheckCrbal { get; set; }


        [Tab(TabName.OrderDetails)]
        [AccountsReceivableInvoiceOrderEditor]
        public System.Collections.Generic.List<AccountsReceivableInvoiceOrderRow> OrderList{get;set;}

        [Tab(TabName.ItemDetails)]
        [AccountsReceivableInvoiceDetailEditorAttribute]
        public System.Collections.Generic.List<AccountsReceivableInvoiceDetailRow> DetailList{get;set;}

        [Tab(TabName.SpecialCharges)]
        [AccountsReceivableCommissionEditorAttribute]
        public System.Collections.Generic.List<AccountsReceivableCommissionRow> CommissionList { get; set; }
        

        [Tab((TabName.SpecialInstruments))]
        [TextAreaEditor(Rows = 4)]
        public String Comments1 { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Comments2 { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Comments3 { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Comments4 { get; set; }

        //public Decimal LastTextNo { get; set; }

        //public String SltaxType { get; set; }
        //public Decimal GsltaxPcent { get; set; }
        //public Decimal TotGsltaxAmt { get; set; }
        //public Decimal TotLsltaxAmt { get; set; }
        //public Decimal LocGsltaxAmt { get; set; }
        //public Decimal LocLsltaxAmt { get; set; }
        //public String AcctSltax { get; set; }
        //public String CustomerPo { get; set; }
        //public String AiLink { get; set; }
        //public String AiLinkType { get; set; }
        //public String AiLinkNo { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }

        //public Decimal LocDpsApplied { get; set; }
        //public String ShipSltaxType { get; set; }
        //public Decimal ShipGsltaxPcent { get; set; }
        //public Decimal ShipCount { get; set; }
        //public String SourceType { get; set; }
        //public Decimal LastChgsNo { get; set; }
        //public String DocType { get; set; }
        //public String DocId { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
        //public Boolean BreakDebitNote { get; set; }
        //public Boolean Freezed { get; set; }
        //public String RelatedDebitNote { get; set; }
        //public Boolean Cloned { get; set; }
        //public String ClonedCompanyCode { get; set; }
        //public Boolean UseSampleAcct { get; set; }
        //public DateTime ReferenceDate { get; set; }
    }
}