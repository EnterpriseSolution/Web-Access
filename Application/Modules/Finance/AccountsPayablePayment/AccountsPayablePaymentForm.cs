#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayablePaymentForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Finance.Entities;
using Matrix.Modules.Common.Enum;

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.AccountsPayablePayment")]
    [BasedOnRow(typeof(Entities.AccountsPayablePaymentRow))]
    public class AccountsPayablePaymentForm
    {
        [Tab(TabName.GeneralInformation)]
        public String RefNo { get; set; }
        //public String Deposit { get; set; }
        //public String Posted { get; set; }
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
        //public String OrderNo { get; set; }
        //public DateTime PaidDate { get; set; }
        //public String Period { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        public String FundCode { get; set; }
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal PaidAmt { get; set; }


        //public String Payee { get; set; }
        //public String ChequeNo { get; set; }
       
        //public String SameCurrency { get; set; }
       
        //public Decimal PaidAmtLocal { get; set; }
        //public Decimal BalAmt { get; set; }
        //public Decimal DiscAmt { get; set; }
        //public Decimal DueAmt { get; set; }
        //public Decimal DueAmtLocal { get; set; }
        //public Decimal AppliedAmt { get; set; }
        //public Decimal AppliedAmtLoc { get; set; }
        //public Decimal SettledAmt { get; set; }
        //public Decimal ForexGainAmt { get; set; }
        //public Decimal EndAmt { get; set; }
        //public Decimal EndAmtLocal { get; set; }
        //public Decimal UnusedAmt { get; set; }
        //public Decimal UnusedAmtLoc { get; set; }
        //public Decimal AppliedLocCpd { get; set; }
        //public Decimal RoundDiff { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public String AcctVendor { get; set; }
        //public String AcctCash { get; set; }
        //public String AcctForexDiff { get; set; }
        //public String AcctTermDisc { get; set; }
        //public String AcctRoundDiff { get; set; }
        //public String BatchSelect { get; set; }
        //public String GlLink { get; set; }
        //public String GlLinkType { get; set; }
        //public String GlLinkNo { get; set; }
        //public String FixedCcy { get; set; }
        //public String DefaultCcy { get; set; }
        //public Decimal PaidLocalCpd { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String CanEdit { get; set; }
        //public Decimal DiscAmtInvo { get; set; }
        //public Decimal TotalDebit { get; set; }
        //public Decimal TotalCredit { get; set; }
        //public Decimal LastAdjCount { get; set; }
        //public String CcyInv { get; set; }
        //public Decimal ExchRateInv { get; set; }
        //public Decimal AppliedAmtInv { get; set; }
        //public Decimal BankAmt { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String Remarks { get; set; }
        //public String ToOpen { get; set; }
        //public String ToRound { get; set; }
        //public Decimal GbvendInvoAmtDiff { get; set; }
        //public Decimal GbvendOpenAmtDiff { get; set; }
        //public Decimal ApledgTotalDebit { get; set; }
        //public Decimal ApledgTotalCredit { get; set; }
        //public String AllowCancel { get; set; }
        //public Decimal ChargeAmt { get; set; }
        //public Decimal ChargeAmtLocal { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
        //public String AcctDeposit { get; set; }

        [Tab(TabName.InvoiceDetails)]
        [AccountsPayablePaymentDetailEditorAttribute]
        public System.Collections.Generic.List<AccountsPayablePaymentDetailRow> DetailList
        { get; set; }
    }
}