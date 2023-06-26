#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivablePaymentRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Finance"), TableName("[dbo].[ARPAYH]")]
    [DisplayName("Payment Receipt Entry"), InstanceName("Accounts Receivable Payment"), TwoLevelCached]   
    public sealed class AccountsReceivablePaymentRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Receipt No"), Column("RECEIPT_NO"), Size(16), PrimaryKey, QuickSearch]
        public String ReceiptNo
        {
            get { return Fields.ReceiptNo[this]; }
            set { Fields.ReceiptNo[this] = value; }
        }

        [DisplayName("Deposit"), Column("DEPOSIT"), Size(1), NotNull]
        public String Deposit
        {
            get { return Fields.Deposit[this]; }
            set { Fields.Deposit[this] = value; }
        }

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8), NotNull]
        public String CustomerNo
        {
            get { return Fields.CustomerNo[this]; }
            set { Fields.CustomerNo[this] = value; }
        }

        [DisplayName("Customer Name"), Column("CUSTOMER_NAME"), Size(50)]
        public String CustomerName
        {
            get { return Fields.CustomerName[this]; }
            set { Fields.CustomerName[this] = value; }
        }

        [DisplayName("Order No"), Column("ORDER_NO"), Size(16)]
        public String OrderNo
        {
            get { return Fields.OrderNo[this]; }
            set { Fields.OrderNo[this] = value; }
        }

        [DisplayName("Receipt Date"), Column("RECEIPT_DATE"), NotNull]
        public DateTime? ReceiptDate
        {
            get { return Fields.ReceiptDate[this]; }
            set { Fields.ReceiptDate[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7)]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Fiscal Year"), Column("FISCAL_YEAR"), Size(4)]
        public Decimal? FiscalYear
        {
            get { return Fields.FiscalYear[this]; }
            set { Fields.FiscalYear[this] = value; }
        }

        [DisplayName("Period No"), Column("PERIOD_NO"), Size(2)]
        public Decimal? PeriodNo
        {
            get { return Fields.PeriodNo[this]; }
            set { Fields.PeriodNo[this] = value; }
        }

        [DisplayName("Fund Code"), Column("FUND_CODE"), Size(6)]
        public String FundCode
        {
            get { return Fields.FundCode[this]; }
            set { Fields.FundCode[this] = value; }
        }

        [DisplayName("Reference"), Column("REFERENCE"), Size(12)]
        public String Reference
        {
            get { return Fields.Reference[this]; }
            set { Fields.Reference[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4)]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Exch Rate"), Column("EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? ExchRate
        {
            get { return Fields.ExchRate[this]; }
            set { Fields.ExchRate[this] = value; }
        }

        [DisplayName("Same Currency"), Column("SAME_CURRENCY"), Size(1)]
        public String SameCurrency
        {
            get { return Fields.SameCurrency[this]; }
            set { Fields.SameCurrency[this] = value; }
        }

        [DisplayName("Paid Amt"), Column("PAID_AMT"), Size(16), Scale(2)]
        public Decimal? PaidAmt
        {
            get { return Fields.PaidAmt[this]; }
            set { Fields.PaidAmt[this] = value; }
        }

        [DisplayName("Paid Amt Local"), Column("PAID_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? PaidAmtLocal
        {
            get { return Fields.PaidAmtLocal[this]; }
            set { Fields.PaidAmtLocal[this] = value; }
        }

        [DisplayName("Bal Amt"), Column("BAL_AMT"), Size(16), Scale(2)]
        public Decimal? BalAmt
        {
            get { return Fields.BalAmt[this]; }
            set { Fields.BalAmt[this] = value; }
        }

        [DisplayName("Disc Amt"), Column("DISC_AMT"), Size(16), Scale(2)]
        public Decimal? DiscAmt
        {
            get { return Fields.DiscAmt[this]; }
            set { Fields.DiscAmt[this] = value; }
        }

        [DisplayName("Due Amt"), Column("DUE_AMT"), Size(16), Scale(2)]
        public Decimal? DueAmt
        {
            get { return Fields.DueAmt[this]; }
            set { Fields.DueAmt[this] = value; }
        }

        [DisplayName("Due Amt Local"), Column("DUE_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? DueAmtLocal
        {
            get { return Fields.DueAmtLocal[this]; }
            set { Fields.DueAmtLocal[this] = value; }
        }

        [DisplayName("Applied Amt"), Column("APPLIED_AMT"), Size(16), Scale(2)]
        public Decimal? AppliedAmt
        {
            get { return Fields.AppliedAmt[this]; }
            set { Fields.AppliedAmt[this] = value; }
        }

        [DisplayName("Applied Amt Loc"), Column("APPLIED_AMT_LOC"), Size(16), Scale(2)]
        public Decimal? AppliedAmtLoc
        {
            get { return Fields.AppliedAmtLoc[this]; }
            set { Fields.AppliedAmtLoc[this] = value; }
        }

        [DisplayName("Settled Amt"), Column("SETTLED_AMT"), Size(16), Scale(2)]
        public Decimal? SettledAmt
        {
            get { return Fields.SettledAmt[this]; }
            set { Fields.SettledAmt[this] = value; }
        }

        [DisplayName("Forex Gain Amt"), Column("FOREX_GAIN_AMT"), Size(16), Scale(2)]
        public Decimal? ForexGainAmt
        {
            get { return Fields.ForexGainAmt[this]; }
            set { Fields.ForexGainAmt[this] = value; }
        }

        [DisplayName("End Amt"), Column("END_AMT"), Size(16), Scale(2)]
        public Decimal? EndAmt
        {
            get { return Fields.EndAmt[this]; }
            set { Fields.EndAmt[this] = value; }
        }

        [DisplayName("End Amt Local"), Column("END_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? EndAmtLocal
        {
            get { return Fields.EndAmtLocal[this]; }
            set { Fields.EndAmtLocal[this] = value; }
        }

        [DisplayName("Unused Amt"), Column("UNUSED_AMT"), Size(16), Scale(2)]
        public Decimal? UnusedAmt
        {
            get { return Fields.UnusedAmt[this]; }
            set { Fields.UnusedAmt[this] = value; }
        }

        [DisplayName("Unused Amt Loc"), Column("UNUSED_AMT_LOC"), Size(16), Scale(2)]
        public Decimal? UnusedAmtLoc
        {
            get { return Fields.UnusedAmtLoc[this]; }
            set { Fields.UnusedAmtLoc[this] = value; }
        }

        [DisplayName("Applied Loc Cpd"), Column("APPLIED_LOC_CPD"), Size(16), Scale(2)]
        public Decimal? AppliedLocCpd
        {
            get { return Fields.AppliedLocCpd[this]; }
            set { Fields.AppliedLocCpd[this] = value; }
        }

        [DisplayName("Round Diff"), Column("ROUND_DIFF"), Size(16), Scale(2)]
        public Decimal? RoundDiff
        {
            get { return Fields.RoundDiff[this]; }
            set { Fields.RoundDiff[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE"), NotNull]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10), NotNull]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Posted Date"), Column("POSTED_DATE")]
        public DateTime? PostedDate
        {
            get { return Fields.PostedDate[this]; }
            set { Fields.PostedDate[this] = value; }
        }

        [DisplayName("Posted By"), Column("POSTED_BY"), Size(10)]
        public String PostedBy
        {
            get { return Fields.PostedBy[this]; }
            set { Fields.PostedBy[this] = value; }
        }

        [DisplayName("Acct Customer"), Column("ACCT_CUSTOMER"), Size(30)]
        public String AcctCustomer
        {
            get { return Fields.AcctCustomer[this]; }
            set { Fields.AcctCustomer[this] = value; }
        }

        [DisplayName("Acct Cash"), Column("ACCT_CASH"), Size(30)]
        public String AcctCash
        {
            get { return Fields.AcctCash[this]; }
            set { Fields.AcctCash[this] = value; }
        }

        [DisplayName("Acct Forex Diff"), Column("ACCT_FOREX_DIFF"), Size(30)]
        public String AcctForexDiff
        {
            get { return Fields.AcctForexDiff[this]; }
            set { Fields.AcctForexDiff[this] = value; }
        }

        [DisplayName("Acct Term Disc"), Column("ACCT_TERM_DISC"), Size(30)]
        public String AcctTermDisc
        {
            get { return Fields.AcctTermDisc[this]; }
            set { Fields.AcctTermDisc[this] = value; }
        }

        [DisplayName("Acct Round Diff"), Column("ACCT_ROUND_DIFF"), Size(30)]
        public String AcctRoundDiff
        {
            get { return Fields.AcctRoundDiff[this]; }
            set { Fields.AcctRoundDiff[this] = value; }
        }

        [DisplayName("Batch Select"), Column("BATCH_SELECT"), Size(1)]
        public String BatchSelect
        {
            get { return Fields.BatchSelect[this]; }
            set { Fields.BatchSelect[this] = value; }
        }

        [DisplayName("Gl Link"), Column("GL_LINK"), Size(1)]
        public String GlLink
        {
            get { return Fields.GlLink[this]; }
            set { Fields.GlLink[this] = value; }
        }

        [DisplayName("Gl Link Type"), Column("GL_LINK_TYPE"), Size(6)]
        public String GlLinkType
        {
            get { return Fields.GlLinkType[this]; }
            set { Fields.GlLinkType[this] = value; }
        }

        [DisplayName("Gl Link No"), Column("GL_LINK_NO"), Size(16)]
        public String GlLinkNo
        {
            get { return Fields.GlLinkNo[this]; }
            set { Fields.GlLinkNo[this] = value; }
        }

        [DisplayName("Fixed Ccy"), Column("FIXED_CCY"), Size(1)]
        public String FixedCcy
        {
            get { return Fields.FixedCcy[this]; }
            set { Fields.FixedCcy[this] = value; }
        }

        [DisplayName("Default Ccy"), Column("DEFAULT_CCY"), Size(4)]
        public String DefaultCcy
        {
            get { return Fields.DefaultCcy[this]; }
            set { Fields.DefaultCcy[this] = value; }
        }

        [DisplayName("Owner Branch"), Column("OWNER_BRANCH"), Size(4)]
        public String OwnerBranch
        {
            get { return Fields.OwnerBranch[this]; }
            set { Fields.OwnerBranch[this] = value; }
        }

        [DisplayName("Source Branch"), Column("SOURCE_BRANCH"), Size(4)]
        public String SourceBranch
        {
            get { return Fields.SourceBranch[this]; }
            set { Fields.SourceBranch[this] = value; }
        }

        [DisplayName("Can Edit"), Column("CAN_EDIT"), Size(1)]
        public String CanEdit
        {
            get { return Fields.CanEdit[this]; }
            set { Fields.CanEdit[this] = value; }
        }

        [DisplayName("Disc Amt Invo"), Column("DISC_AMT_INVO"), Size(16), Scale(2)]
        public Decimal? DiscAmtInvo
        {
            get { return Fields.DiscAmtInvo[this]; }
            set { Fields.DiscAmtInvo[this] = value; }
        }

        [DisplayName("Total Debit"), Column("TOTAL_DEBIT"), Size(16), Scale(2)]
        public Decimal? TotalDebit
        {
            get { return Fields.TotalDebit[this]; }
            set { Fields.TotalDebit[this] = value; }
        }

        [DisplayName("Total Credit"), Column("TOTAL_CREDIT"), Size(16), Scale(2)]
        public Decimal? TotalCredit
        {
            get { return Fields.TotalCredit[this]; }
            set { Fields.TotalCredit[this] = value; }
        }

        [DisplayName("Last Adj Count"), Column("LAST_ADJ_COUNT"), Size(6)]
        public Decimal? LastAdjCount
        {
            get { return Fields.LastAdjCount[this]; }
            set { Fields.LastAdjCount[this] = value; }
        }

        [DisplayName("Ccy Inv"), Column("CCY_INV"), Size(4)]
        public String CcyInv
        {
            get { return Fields.CcyInv[this]; }
            set { Fields.CcyInv[this] = value; }
        }

        [DisplayName("Exch Rate Inv"), Column("EXCH_RATE_INV"), Size(12), Scale(6)]
        public Decimal? ExchRateInv
        {
            get { return Fields.ExchRateInv[this]; }
            set { Fields.ExchRateInv[this] = value; }
        }

        [DisplayName("Applied Amt Inv"), Column("APPLIED_AMT_INV"), Size(16), Scale(2)]
        public Decimal? AppliedAmtInv
        {
            get { return Fields.AppliedAmtInv[this]; }
            set { Fields.AppliedAmtInv[this] = value; }
        }

        [DisplayName("Bank Amt"), Column("BANK_AMT"), Size(16), Scale(2)]
        public Decimal? BankAmt
        {
            get { return Fields.BankAmt[this]; }
            set { Fields.BankAmt[this] = value; }
        }

        [DisplayName("Anlys1"), Column("ANLYS1"), Size(30)]
        public String Anlys1
        {
            get { return Fields.Anlys1[this]; }
            set { Fields.Anlys1[this] = value; }
        }

        [DisplayName("Anlys2"), Column("ANLYS2"), Size(30)]
        public String Anlys2
        {
            get { return Fields.Anlys2[this]; }
            set { Fields.Anlys2[this] = value; }
        }

        [DisplayName("Anlys7"), Column("ANLYS7"), Size(30)]
        public String Anlys7
        {
            get { return Fields.Anlys7[this]; }
            set { Fields.Anlys7[this] = value; }
        }

        [DisplayName("Anlys8"), Column("ANLYS8"), Size(30)]
        public String Anlys8
        {
            get { return Fields.Anlys8[this]; }
            set { Fields.Anlys8[this] = value; }
        }

        [DisplayName("To Open"), Column("TO_OPEN"), Size(1)]
        public String ToOpen
        {
            get { return Fields.ToOpen[this]; }
            set { Fields.ToOpen[this] = value; }
        }

        [DisplayName("To Round"), Column("TO_ROUND"), Size(1)]
        public String ToRound
        {
            get { return Fields.ToRound[this]; }
            set { Fields.ToRound[this] = value; }
        }

        [DisplayName("Gbcust Invo Amt Diff"), Column("GBCUST_INVO_AMT_DIFF"), Size(16), Scale(2)]
        public Decimal? GbcustInvoAmtDiff
        {
            get { return Fields.GbcustInvoAmtDiff[this]; }
            set { Fields.GbcustInvoAmtDiff[this] = value; }
        }

        [DisplayName("Gbcust Open Amt Diff"), Column("GBCUST_OPEN_AMT_DIFF"), Size(16), Scale(2)]
        public Decimal? GbcustOpenAmtDiff
        {
            get { return Fields.GbcustOpenAmtDiff[this]; }
            set { Fields.GbcustOpenAmtDiff[this] = value; }
        }

        [DisplayName("Arledg Total Debit"), Column("ARLEDG_TOTAL_DEBIT"), Size(16), Scale(2)]
        public Decimal? ArledgTotalDebit
        {
            get { return Fields.ArledgTotalDebit[this]; }
            set { Fields.ArledgTotalDebit[this] = value; }
        }

        [DisplayName("Arledg Total Credit"), Column("ARLEDG_TOTAL_CREDIT"), Size(16), Scale(2)]
        public Decimal? ArledgTotalCredit
        {
            get { return Fields.ArledgTotalCredit[this]; }
            set { Fields.ArledgTotalCredit[this] = value; }
        }

        [DisplayName("Allow Cancel"), Column("ALLOW_CANCEL"), Size(1)]
        public String AllowCancel
        {
            get { return Fields.AllowCancel[this]; }
            set { Fields.AllowCancel[this] = value; }
        }

        [DisplayName("Payer"), Column("PAYER"), Size(50)]
        public String Payer
        {
            get { return Fields.Payer[this]; }
            set { Fields.Payer[this] = value; }
        }

        [DisplayName("Charge Amt"), Column("CHARGE_AMT"), Size(16), Scale(2)]
        public Decimal? ChargeAmt
        {
            get { return Fields.ChargeAmt[this]; }
            set { Fields.ChargeAmt[this] = value; }
        }

        [DisplayName("Charge Amt Local"), Column("CHARGE_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? ChargeAmtLocal
        {
            get { return Fields.ChargeAmtLocal[this]; }
            set { Fields.ChargeAmtLocal[this] = value; }
        }

        [DisplayName("Anlys9"), Column("ANLYS9"), Size(30)]
        public String Anlys9
        {
            get { return Fields.Anlys9[this]; }
            set { Fields.Anlys9[this] = value; }
        }

        [DisplayName("Anlys10"), Column("ANLYS10"), Size(30)]
        public String Anlys10
        {
            get { return Fields.Anlys10[this]; }
            set { Fields.Anlys10[this] = value; }
        }

        [DisplayName("Anlys11"), Column("ANLYS11"), Size(30)]
        public String Anlys11
        {
            get { return Fields.Anlys11[this]; }
            set { Fields.Anlys11[this] = value; }
        }

        [DisplayName("Anlys12"), Column("ANLYS12"), Size(30)]
        public String Anlys12
        {
            get { return Fields.Anlys12[this]; }
            set { Fields.Anlys12[this] = value; }
        }

        [DisplayName("Anlys13"), Column("ANLYS13"), Size(30)]
        public String Anlys13
        {
            get { return Fields.Anlys13[this]; }
            set { Fields.Anlys13[this] = value; }
        }

        [DisplayName("Anlys14"), Column("ANLYS14"), Size(30)]
        public String Anlys14
        {
            get { return Fields.Anlys14[this]; }
            set { Fields.Anlys14[this] = value; }
        }

        [DisplayName("Acct Deposit"), Column("ACCT_DEPOSIT"), Size(30)]
        public String AcctDeposit
        {
            get { return Fields.AcctDeposit[this]; }
            set { Fields.AcctDeposit[this] = value; }
        }

        [DisplayName("Bal Amt Local"), Column("BAL_AMT_LOCAL"), Size(16), Scale(2)]
        public Decimal? BalAmtLocal
        {
            get { return Fields.BalAmtLocal[this]; }
            set { Fields.BalAmtLocal[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "ReceiptNo")]
        [DisplayName("Detail List"), NotMapped]
        public System.Collections.Generic.List<AccountsReceivablePaymentDetailRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }
        
        [MasterDetailRelation(foreignKey: "ReceiptNo")]
        [DisplayName("Detail List"), NotMapped]
        public System.Collections.Generic.List<AccountsReceivablePaymentDepositRow> DepositList
        {
            get { return Fields.DepositList[this]; }
            set { Fields.DepositList[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "ReceiptNo")]
        [DisplayName("Detail List"), NotMapped]
        public System.Collections.Generic.List<AccountsReceivablePaymentCurrencyRow> CurrencyList
        {
            get { return Fields.CurrencyList[this]; }
            set { Fields.CurrencyList[this] = value; }
        }
        

        IIdField IIdRow.IdField
        {
            get { return Fields.ReceiptNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ReceiptNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsReceivablePaymentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public RowListField<AccountsReceivablePaymentDetailRow> DetailList;

            public RowListField<AccountsReceivablePaymentDepositRow> DepositList;

            public RowListField<AccountsReceivablePaymentCurrencyRow> CurrencyList;

            public DecimalField Recnum;
            public StringField ReceiptNo;
            public StringField Deposit;
            public StringField Posted;
            public StringField CustomerNo;
            public StringField CustomerName;
            public StringField OrderNo;
            public DateTimeField ReceiptDate;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public StringField FundCode;
            public StringField Reference;
            public StringField Ccy;
            public DecimalField ExchRate;
            public StringField SameCurrency;
            public DecimalField PaidAmt;
            public DecimalField PaidAmtLocal;
            public DecimalField BalAmt;
            public DecimalField DiscAmt;
            public DecimalField DueAmt;
            public DecimalField DueAmtLocal;
            public DecimalField AppliedAmt;
            public DecimalField AppliedAmtLoc;
            public DecimalField SettledAmt;
            public DecimalField ForexGainAmt;
            public DecimalField EndAmt;
            public DecimalField EndAmtLocal;
            public DecimalField UnusedAmt;
            public DecimalField UnusedAmtLoc;
            public DecimalField AppliedLocCpd;
            public DecimalField RoundDiff;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public StringField AcctCustomer;
            public StringField AcctCash;
            public StringField AcctForexDiff;
            public StringField AcctTermDisc;
            public StringField AcctRoundDiff;
            public StringField BatchSelect;
            public StringField GlLink;
            public StringField GlLinkType;
            public StringField GlLinkNo;
            public StringField FixedCcy;
            public StringField DefaultCcy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField CanEdit;
            public DecimalField DiscAmtInvo;
            public DecimalField TotalDebit;
            public DecimalField TotalCredit;
            public DecimalField LastAdjCount;
            public StringField CcyInv;
            public DecimalField ExchRateInv;
            public DecimalField AppliedAmtInv;
            public DecimalField BankAmt;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys7;
            public StringField Anlys8;
            public StringField ToOpen;
            public StringField ToRound;
            public DecimalField GbcustInvoAmtDiff;
            public DecimalField GbcustOpenAmtDiff;
            public DecimalField ArledgTotalDebit;
            public DecimalField ArledgTotalCredit;
            public StringField AllowCancel;
            public StringField Payer;
            public DecimalField ChargeAmt;
            public DecimalField ChargeAmtLocal;
            public StringField Anlys9;
            public StringField Anlys10;
            public StringField Anlys11;
            public StringField Anlys12;
            public StringField Anlys13;
            public StringField Anlys14;
            public StringField AcctDeposit;
            public DecimalField BalAmtLocal;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsReceivablePayment";
            }
        }
    }
}
