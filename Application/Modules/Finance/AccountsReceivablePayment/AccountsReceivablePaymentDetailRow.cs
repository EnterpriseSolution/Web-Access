#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivablePaymentDetailRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[ARPAYD]")]
    [DisplayName("Accounts Receivable Payment Detail"), InstanceName("Accounts Receivable Payment Detail"), TwoLevelCached]   
    public sealed class AccountsReceivablePaymentDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Receipt No"), Column("RECEIPT_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[ARPAYH]", "RECEIPT_NO"), LeftJoin("jReceiptNo"), QuickSearch, TextualField("ReceiptNoDeposit")]
        public String ReceiptNo
        {
            get { return Fields.ReceiptNo[this]; }
            set { Fields.ReceiptNo[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[ARINVH]", "INVOICE_NO"), LeftJoin("jInvoiceNo"), TextualField("InvoiceNoDirectEntry")]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
        }

        [DisplayName("Invoice Date"), Column("INVOICE_DATE")]
        public DateTime? InvoiceDate
        {
            get { return Fields.InvoiceDate[this]; }
            set { Fields.InvoiceDate[this] = value; }
        }

        [DisplayName("Discount Date"), Column("DISCOUNT_DATE")]
        public DateTime? DiscountDate
        {
            get { return Fields.DiscountDate[this]; }
            set { Fields.DiscountDate[this] = value; }
        }

        [DisplayName("Due Date"), Column("DUE_DATE"), NotNull]
        public DateTime? DueDate
        {
            get { return Fields.DueDate[this]; }
            set { Fields.DueDate[this] = value; }
        }

        [DisplayName("Disc Percent"), Column("DISC_PERCENT"), Size(6), Scale(2)]
        public Decimal? DiscPercent
        {
            get { return Fields.DiscPercent[this]; }
            set { Fields.DiscPercent[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4)]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Invo Exch Rate"), Column("INVO_EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? InvoExchRate
        {
            get { return Fields.InvoExchRate[this]; }
            set { Fields.InvoExchRate[this] = value; }
        }

        [DisplayName("Pay Exch Rate"), Column("PAY_EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? PayExchRate
        {
            get { return Fields.PayExchRate[this]; }
            set { Fields.PayExchRate[this] = value; }
        }

        [DisplayName("Bal Amt"), Column("BAL_AMT"), Size(16), Scale(2)]
        public Decimal? BalAmt
        {
            get { return Fields.BalAmt[this]; }
            set { Fields.BalAmt[this] = value; }
        }

        [DisplayName("Bal Amt Invo"), Column("BAL_AMT_INVO"), Size(16), Scale(2)]
        public Decimal? BalAmtInvo
        {
            get { return Fields.BalAmtInvo[this]; }
            set { Fields.BalAmtInvo[this] = value; }
        }

        [DisplayName("Disc Amt"), Column("DISC_AMT"), Size(16), Scale(2)]
        public Decimal? DiscAmt
        {
            get { return Fields.DiscAmt[this]; }
            set { Fields.DiscAmt[this] = value; }
        }

        [DisplayName("Disc Amt Invo"), Column("DISC_AMT_INVO"), Size(16), Scale(2)]
        public Decimal? DiscAmtInvo
        {
            get { return Fields.DiscAmtInvo[this]; }
            set { Fields.DiscAmtInvo[this] = value; }
        }

        [DisplayName("Due Amt"), Column("DUE_AMT"), Size(16), Scale(2)]
        public Decimal? DueAmt
        {
            get { return Fields.DueAmt[this]; }
            set { Fields.DueAmt[this] = value; }
        }

        [DisplayName("Due Amt Invo"), Column("DUE_AMT_INVO"), Size(16), Scale(2)]
        public Decimal? DueAmtInvo
        {
            get { return Fields.DueAmtInvo[this]; }
            set { Fields.DueAmtInvo[this] = value; }
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

        [DisplayName("Posted"), Column("POSTED"), Size(1)]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Log No"), Column("LOG_NO"), Size(6), NotNull]
        public Decimal? LogNo
        {
            get { return Fields.LogNo[this]; }
            set { Fields.LogNo[this] = value; }
        }

        [DisplayName("Last Log No"), Column("LAST_LOG_NO"), Size(8)]
        public Decimal? LastLogNo
        {
            get { return Fields.LastLogNo[this]; }
            set { Fields.LastLogNo[this] = value; }
        }

        [DisplayName("Receipt Date"), Column("RECEIPT_DATE")]
        public DateTime? ReceiptDate
        {
            get { return Fields.ReceiptDate[this]; }
            set { Fields.ReceiptDate[this] = value; }
        }

        [DisplayName("Settle"), Column("SETTLE"), Size(1)]
        public String Settle
        {
            get { return Fields.Settle[this]; }
            set { Fields.Settle[this] = value; }
        }

        [DisplayName("Applied Amt Inv"), Column("APPLIED_AMT_INV"), Size(16), Scale(2)]
        public Decimal? AppliedAmtInv
        {
            get { return Fields.AppliedAmtInv[this]; }
            set { Fields.AppliedAmtInv[this] = value; }
        }

        [DisplayName("Anlys3"), Column("ANLYS3"), Size(30)]
        public String Anlys3
        {
            get { return Fields.Anlys3[this]; }
            set { Fields.Anlys3[this] = value; }
        }

        [DisplayName("Anlys4"), Column("ANLYS4"), Size(30)]
        public String Anlys4
        {
            get { return Fields.Anlys4[this]; }
            set { Fields.Anlys4[this] = value; }
        }

        [DisplayName("Anlys5"), Column("ANLYS5"), Size(30)]
        public String Anlys5
        {
            get { return Fields.Anlys5[this]; }
            set { Fields.Anlys5[this] = value; }
        }

        [DisplayName("Anlys6"), Column("ANLYS6"), Size(30)]
        public String Anlys6
        {
            get { return Fields.Anlys6[this]; }
            set { Fields.Anlys6[this] = value; }
        }

        [DisplayName("Inv Round Diff"), Column("INV_ROUND_DIFF"), Size(16), Scale(2)]
        public Decimal? InvRoundDiff
        {
            get { return Fields.InvRoundDiff[this]; }
            set { Fields.InvRoundDiff[this] = value; }
        }

        [DisplayName("Anlys15"), Column("ANLYS15"), Size(30)]
        public String Anlys15
        {
            get { return Fields.Anlys15[this]; }
            set { Fields.Anlys15[this] = value; }
        }

        [DisplayName("Anlys16"), Column("ANLYS16"), Size(30)]
        public String Anlys16
        {
            get { return Fields.Anlys16[this]; }
            set { Fields.Anlys16[this] = value; }
        }

        [DisplayName("Anlys17"), Column("ANLYS17"), Size(30)]
        public String Anlys17
        {
            get { return Fields.Anlys17[this]; }
            set { Fields.Anlys17[this] = value; }
        }

        [DisplayName("Anlys18"), Column("ANLYS18"), Size(30)]
        public String Anlys18
        {
            get { return Fields.Anlys18[this]; }
            set { Fields.Anlys18[this] = value; }
        }

        [DisplayName("Anlys19"), Column("ANLYS19"), Size(30)]
        public String Anlys19
        {
            get { return Fields.Anlys19[this]; }
            set { Fields.Anlys19[this] = value; }
        }

        [DisplayName("Anlys20"), Column("ANLYS20"), Size(30)]
        public String Anlys20
        {
            get { return Fields.Anlys20[this]; }
            set { Fields.Anlys20[this] = value; }
        }

        [DisplayName("Receipt No Recnum"), Expression("jReceiptNo.[RECNUM]")]
        public Decimal? ReceiptNoRecnum
        {
            get { return Fields.ReceiptNoRecnum[this]; }
            set { Fields.ReceiptNoRecnum[this] = value; }
        }

        [DisplayName("Receipt No Deposit"), Expression("jReceiptNo.[DEPOSIT]")]
        public String ReceiptNoDeposit
        {
            get { return Fields.ReceiptNoDeposit[this]; }
            set { Fields.ReceiptNoDeposit[this] = value; }
        }

        [DisplayName("Receipt No Posted"), Expression("jReceiptNo.[POSTED]")]
        public String ReceiptNoPosted
        {
            get { return Fields.ReceiptNoPosted[this]; }
            set { Fields.ReceiptNoPosted[this] = value; }
        }

        [DisplayName("Receipt No Customer No"), Expression("jReceiptNo.[CUSTOMER_NO]")]
        public String ReceiptNoCustomerNo
        {
            get { return Fields.ReceiptNoCustomerNo[this]; }
            set { Fields.ReceiptNoCustomerNo[this] = value; }
        }

        [DisplayName("Receipt No Customer Name"), Expression("jReceiptNo.[CUSTOMER_NAME]")]
        public String ReceiptNoCustomerName
        {
            get { return Fields.ReceiptNoCustomerName[this]; }
            set { Fields.ReceiptNoCustomerName[this] = value; }
        }

        [DisplayName("Receipt No Order No"), Expression("jReceiptNo.[ORDER_NO]")]
        public String ReceiptNoOrderNo
        {
            get { return Fields.ReceiptNoOrderNo[this]; }
            set { Fields.ReceiptNoOrderNo[this] = value; }
        }

        [DisplayName("Receipt No Receipt Date"), Expression("jReceiptNo.[RECEIPT_DATE]")]
        public DateTime? ReceiptNoReceiptDate
        {
            get { return Fields.ReceiptNoReceiptDate[this]; }
            set { Fields.ReceiptNoReceiptDate[this] = value; }
        }

        [DisplayName("Receipt No Period"), Expression("jReceiptNo.[PERIOD]")]
        public String ReceiptNoPeriod
        {
            get { return Fields.ReceiptNoPeriod[this]; }
            set { Fields.ReceiptNoPeriod[this] = value; }
        }

        [DisplayName("Receipt No Fiscal Year"), Expression("jReceiptNo.[FISCAL_YEAR]")]
        public Decimal? ReceiptNoFiscalYear
        {
            get { return Fields.ReceiptNoFiscalYear[this]; }
            set { Fields.ReceiptNoFiscalYear[this] = value; }
        }

        [DisplayName("Receipt No Period No"), Expression("jReceiptNo.[PERIOD_NO]")]
        public Decimal? ReceiptNoPeriodNo
        {
            get { return Fields.ReceiptNoPeriodNo[this]; }
            set { Fields.ReceiptNoPeriodNo[this] = value; }
        }

        [DisplayName("Receipt No Fund Code"), Expression("jReceiptNo.[FUND_CODE]")]
        public String ReceiptNoFundCode
        {
            get { return Fields.ReceiptNoFundCode[this]; }
            set { Fields.ReceiptNoFundCode[this] = value; }
        }

        [DisplayName("Receipt No Reference"), Expression("jReceiptNo.[REFERENCE]")]
        public String ReceiptNoReference
        {
            get { return Fields.ReceiptNoReference[this]; }
            set { Fields.ReceiptNoReference[this] = value; }
        }

        [DisplayName("Receipt No Ccy"), Expression("jReceiptNo.[CCY]")]
        public String ReceiptNoCcy
        {
            get { return Fields.ReceiptNoCcy[this]; }
            set { Fields.ReceiptNoCcy[this] = value; }
        }

        [DisplayName("Receipt No Exch Rate"), Expression("jReceiptNo.[EXCH_RATE]")]
        public Decimal? ReceiptNoExchRate
        {
            get { return Fields.ReceiptNoExchRate[this]; }
            set { Fields.ReceiptNoExchRate[this] = value; }
        }

        [DisplayName("Receipt No Same Currency"), Expression("jReceiptNo.[SAME_CURRENCY]")]
        public String ReceiptNoSameCurrency
        {
            get { return Fields.ReceiptNoSameCurrency[this]; }
            set { Fields.ReceiptNoSameCurrency[this] = value; }
        }

        [DisplayName("Receipt No Paid Amt"), Expression("jReceiptNo.[PAID_AMT]")]
        public Decimal? ReceiptNoPaidAmt
        {
            get { return Fields.ReceiptNoPaidAmt[this]; }
            set { Fields.ReceiptNoPaidAmt[this] = value; }
        }

        [DisplayName("Receipt No Paid Amt Local"), Expression("jReceiptNo.[PAID_AMT_LOCAL]")]
        public Decimal? ReceiptNoPaidAmtLocal
        {
            get { return Fields.ReceiptNoPaidAmtLocal[this]; }
            set { Fields.ReceiptNoPaidAmtLocal[this] = value; }
        }

        [DisplayName("Receipt No Bal Amt"), Expression("jReceiptNo.[BAL_AMT]")]
        public Decimal? ReceiptNoBalAmt
        {
            get { return Fields.ReceiptNoBalAmt[this]; }
            set { Fields.ReceiptNoBalAmt[this] = value; }
        }

        [DisplayName("Receipt No Disc Amt"), Expression("jReceiptNo.[DISC_AMT]")]
        public Decimal? ReceiptNoDiscAmt
        {
            get { return Fields.ReceiptNoDiscAmt[this]; }
            set { Fields.ReceiptNoDiscAmt[this] = value; }
        }

        [DisplayName("Receipt No Due Amt"), Expression("jReceiptNo.[DUE_AMT]")]
        public Decimal? ReceiptNoDueAmt
        {
            get { return Fields.ReceiptNoDueAmt[this]; }
            set { Fields.ReceiptNoDueAmt[this] = value; }
        }

        [DisplayName("Receipt No Due Amt Local"), Expression("jReceiptNo.[DUE_AMT_LOCAL]")]
        public Decimal? ReceiptNoDueAmtLocal
        {
            get { return Fields.ReceiptNoDueAmtLocal[this]; }
            set { Fields.ReceiptNoDueAmtLocal[this] = value; }
        }

        [DisplayName("Receipt No Applied Amt"), Expression("jReceiptNo.[APPLIED_AMT]")]
        public Decimal? ReceiptNoAppliedAmt
        {
            get { return Fields.ReceiptNoAppliedAmt[this]; }
            set { Fields.ReceiptNoAppliedAmt[this] = value; }
        }

        [DisplayName("Receipt No Applied Amt Loc"), Expression("jReceiptNo.[APPLIED_AMT_LOC]")]
        public Decimal? ReceiptNoAppliedAmtLoc
        {
            get { return Fields.ReceiptNoAppliedAmtLoc[this]; }
            set { Fields.ReceiptNoAppliedAmtLoc[this] = value; }
        }

        [DisplayName("Receipt No Settled Amt"), Expression("jReceiptNo.[SETTLED_AMT]")]
        public Decimal? ReceiptNoSettledAmt
        {
            get { return Fields.ReceiptNoSettledAmt[this]; }
            set { Fields.ReceiptNoSettledAmt[this] = value; }
        }

        [DisplayName("Receipt No Forex Gain Amt"), Expression("jReceiptNo.[FOREX_GAIN_AMT]")]
        public Decimal? ReceiptNoForexGainAmt
        {
            get { return Fields.ReceiptNoForexGainAmt[this]; }
            set { Fields.ReceiptNoForexGainAmt[this] = value; }
        }

        [DisplayName("Receipt No End Amt"), Expression("jReceiptNo.[END_AMT]")]
        public Decimal? ReceiptNoEndAmt
        {
            get { return Fields.ReceiptNoEndAmt[this]; }
            set { Fields.ReceiptNoEndAmt[this] = value; }
        }

        [DisplayName("Receipt No End Amt Local"), Expression("jReceiptNo.[END_AMT_LOCAL]")]
        public Decimal? ReceiptNoEndAmtLocal
        {
            get { return Fields.ReceiptNoEndAmtLocal[this]; }
            set { Fields.ReceiptNoEndAmtLocal[this] = value; }
        }

        [DisplayName("Receipt No Unused Amt"), Expression("jReceiptNo.[UNUSED_AMT]")]
        public Decimal? ReceiptNoUnusedAmt
        {
            get { return Fields.ReceiptNoUnusedAmt[this]; }
            set { Fields.ReceiptNoUnusedAmt[this] = value; }
        }

        [DisplayName("Receipt No Unused Amt Loc"), Expression("jReceiptNo.[UNUSED_AMT_LOC]")]
        public Decimal? ReceiptNoUnusedAmtLoc
        {
            get { return Fields.ReceiptNoUnusedAmtLoc[this]; }
            set { Fields.ReceiptNoUnusedAmtLoc[this] = value; }
        }

        [DisplayName("Receipt No Applied Loc Cpd"), Expression("jReceiptNo.[APPLIED_LOC_CPD]")]
        public Decimal? ReceiptNoAppliedLocCpd
        {
            get { return Fields.ReceiptNoAppliedLocCpd[this]; }
            set { Fields.ReceiptNoAppliedLocCpd[this] = value; }
        }

        [DisplayName("Receipt No Round Diff"), Expression("jReceiptNo.[ROUND_DIFF]")]
        public Decimal? ReceiptNoRoundDiff
        {
            get { return Fields.ReceiptNoRoundDiff[this]; }
            set { Fields.ReceiptNoRoundDiff[this] = value; }
        }

        [DisplayName("Receipt No Created Date"), Expression("jReceiptNo.[CREATED_DATE]")]
        public DateTime? ReceiptNoCreatedDate
        {
            get { return Fields.ReceiptNoCreatedDate[this]; }
            set { Fields.ReceiptNoCreatedDate[this] = value; }
        }

        [DisplayName("Receipt No Created By"), Expression("jReceiptNo.[CREATED_BY]")]
        public String ReceiptNoCreatedBy
        {
            get { return Fields.ReceiptNoCreatedBy[this]; }
            set { Fields.ReceiptNoCreatedBy[this] = value; }
        }

        [DisplayName("Receipt No Revised Date"), Expression("jReceiptNo.[REVISED_DATE]")]
        public DateTime? ReceiptNoRevisedDate
        {
            get { return Fields.ReceiptNoRevisedDate[this]; }
            set { Fields.ReceiptNoRevisedDate[this] = value; }
        }

        [DisplayName("Receipt No Revised By"), Expression("jReceiptNo.[REVISED_BY]")]
        public String ReceiptNoRevisedBy
        {
            get { return Fields.ReceiptNoRevisedBy[this]; }
            set { Fields.ReceiptNoRevisedBy[this] = value; }
        }

        [DisplayName("Receipt No Posted Date"), Expression("jReceiptNo.[POSTED_DATE]")]
        public DateTime? ReceiptNoPostedDate
        {
            get { return Fields.ReceiptNoPostedDate[this]; }
            set { Fields.ReceiptNoPostedDate[this] = value; }
        }

        [DisplayName("Receipt No Posted By"), Expression("jReceiptNo.[POSTED_BY]")]
        public String ReceiptNoPostedBy
        {
            get { return Fields.ReceiptNoPostedBy[this]; }
            set { Fields.ReceiptNoPostedBy[this] = value; }
        }

        [DisplayName("Receipt No Acct Customer"), Expression("jReceiptNo.[ACCT_CUSTOMER]")]
        public String ReceiptNoAcctCustomer
        {
            get { return Fields.ReceiptNoAcctCustomer[this]; }
            set { Fields.ReceiptNoAcctCustomer[this] = value; }
        }

        [DisplayName("Receipt No Acct Cash"), Expression("jReceiptNo.[ACCT_CASH]")]
        public String ReceiptNoAcctCash
        {
            get { return Fields.ReceiptNoAcctCash[this]; }
            set { Fields.ReceiptNoAcctCash[this] = value; }
        }

        [DisplayName("Receipt No Acct Forex Diff"), Expression("jReceiptNo.[ACCT_FOREX_DIFF]")]
        public String ReceiptNoAcctForexDiff
        {
            get { return Fields.ReceiptNoAcctForexDiff[this]; }
            set { Fields.ReceiptNoAcctForexDiff[this] = value; }
        }

        [DisplayName("Receipt No Acct Term Disc"), Expression("jReceiptNo.[ACCT_TERM_DISC]")]
        public String ReceiptNoAcctTermDisc
        {
            get { return Fields.ReceiptNoAcctTermDisc[this]; }
            set { Fields.ReceiptNoAcctTermDisc[this] = value; }
        }

        [DisplayName("Receipt No Acct Round Diff"), Expression("jReceiptNo.[ACCT_ROUND_DIFF]")]
        public String ReceiptNoAcctRoundDiff
        {
            get { return Fields.ReceiptNoAcctRoundDiff[this]; }
            set { Fields.ReceiptNoAcctRoundDiff[this] = value; }
        }

        [DisplayName("Receipt No Batch Select"), Expression("jReceiptNo.[BATCH_SELECT]")]
        public String ReceiptNoBatchSelect
        {
            get { return Fields.ReceiptNoBatchSelect[this]; }
            set { Fields.ReceiptNoBatchSelect[this] = value; }
        }

        [DisplayName("Receipt No Gl Link"), Expression("jReceiptNo.[GL_LINK]")]
        public String ReceiptNoGlLink
        {
            get { return Fields.ReceiptNoGlLink[this]; }
            set { Fields.ReceiptNoGlLink[this] = value; }
        }

        [DisplayName("Receipt No Gl Link Type"), Expression("jReceiptNo.[GL_LINK_TYPE]")]
        public String ReceiptNoGlLinkType
        {
            get { return Fields.ReceiptNoGlLinkType[this]; }
            set { Fields.ReceiptNoGlLinkType[this] = value; }
        }

        [DisplayName("Receipt No Gl Link No"), Expression("jReceiptNo.[GL_LINK_NO]")]
        public String ReceiptNoGlLinkNo
        {
            get { return Fields.ReceiptNoGlLinkNo[this]; }
            set { Fields.ReceiptNoGlLinkNo[this] = value; }
        }

        [DisplayName("Receipt No Fixed Ccy"), Expression("jReceiptNo.[FIXED_CCY]")]
        public String ReceiptNoFixedCcy
        {
            get { return Fields.ReceiptNoFixedCcy[this]; }
            set { Fields.ReceiptNoFixedCcy[this] = value; }
        }

        [DisplayName("Receipt No Default Ccy"), Expression("jReceiptNo.[DEFAULT_CCY]")]
        public String ReceiptNoDefaultCcy
        {
            get { return Fields.ReceiptNoDefaultCcy[this]; }
            set { Fields.ReceiptNoDefaultCcy[this] = value; }
        }

        [DisplayName("Receipt No Owner Branch"), Expression("jReceiptNo.[OWNER_BRANCH]")]
        public String ReceiptNoOwnerBranch
        {
            get { return Fields.ReceiptNoOwnerBranch[this]; }
            set { Fields.ReceiptNoOwnerBranch[this] = value; }
        }

        [DisplayName("Receipt No Source Branch"), Expression("jReceiptNo.[SOURCE_BRANCH]")]
        public String ReceiptNoSourceBranch
        {
            get { return Fields.ReceiptNoSourceBranch[this]; }
            set { Fields.ReceiptNoSourceBranch[this] = value; }
        }

        [DisplayName("Receipt No Can Edit"), Expression("jReceiptNo.[CAN_EDIT]")]
        public String ReceiptNoCanEdit
        {
            get { return Fields.ReceiptNoCanEdit[this]; }
            set { Fields.ReceiptNoCanEdit[this] = value; }
        }

        [DisplayName("Receipt No Disc Amt Invo"), Expression("jReceiptNo.[DISC_AMT_INVO]")]
        public Decimal? ReceiptNoDiscAmtInvo
        {
            get { return Fields.ReceiptNoDiscAmtInvo[this]; }
            set { Fields.ReceiptNoDiscAmtInvo[this] = value; }
        }

        [DisplayName("Receipt No Total Debit"), Expression("jReceiptNo.[TOTAL_DEBIT]")]
        public Decimal? ReceiptNoTotalDebit
        {
            get { return Fields.ReceiptNoTotalDebit[this]; }
            set { Fields.ReceiptNoTotalDebit[this] = value; }
        }

        [DisplayName("Receipt No Total Credit"), Expression("jReceiptNo.[TOTAL_CREDIT]")]
        public Decimal? ReceiptNoTotalCredit
        {
            get { return Fields.ReceiptNoTotalCredit[this]; }
            set { Fields.ReceiptNoTotalCredit[this] = value; }
        }

        [DisplayName("Receipt No Last Adj Count"), Expression("jReceiptNo.[LAST_ADJ_COUNT]")]
        public Decimal? ReceiptNoLastAdjCount
        {
            get { return Fields.ReceiptNoLastAdjCount[this]; }
            set { Fields.ReceiptNoLastAdjCount[this] = value; }
        }

        [DisplayName("Receipt No Ccy Inv"), Expression("jReceiptNo.[CCY_INV]")]
        public String ReceiptNoCcyInv
        {
            get { return Fields.ReceiptNoCcyInv[this]; }
            set { Fields.ReceiptNoCcyInv[this] = value; }
        }

        [DisplayName("Receipt No Exch Rate Inv"), Expression("jReceiptNo.[EXCH_RATE_INV]")]
        public Decimal? ReceiptNoExchRateInv
        {
            get { return Fields.ReceiptNoExchRateInv[this]; }
            set { Fields.ReceiptNoExchRateInv[this] = value; }
        }

        [DisplayName("Receipt No Applied Amt Inv"), Expression("jReceiptNo.[APPLIED_AMT_INV]")]
        public Decimal? ReceiptNoAppliedAmtInv
        {
            get { return Fields.ReceiptNoAppliedAmtInv[this]; }
            set { Fields.ReceiptNoAppliedAmtInv[this] = value; }
        }

        [DisplayName("Receipt No Bank Amt"), Expression("jReceiptNo.[BANK_AMT]")]
        public Decimal? ReceiptNoBankAmt
        {
            get { return Fields.ReceiptNoBankAmt[this]; }
            set { Fields.ReceiptNoBankAmt[this] = value; }
        }

        [DisplayName("Receipt No Anlys1"), Expression("jReceiptNo.[ANLYS1]")]
        public String ReceiptNoAnlys1
        {
            get { return Fields.ReceiptNoAnlys1[this]; }
            set { Fields.ReceiptNoAnlys1[this] = value; }
        }

        [DisplayName("Receipt No Anlys2"), Expression("jReceiptNo.[ANLYS2]")]
        public String ReceiptNoAnlys2
        {
            get { return Fields.ReceiptNoAnlys2[this]; }
            set { Fields.ReceiptNoAnlys2[this] = value; }
        }

        [DisplayName("Receipt No Anlys7"), Expression("jReceiptNo.[ANLYS7]")]
        public String ReceiptNoAnlys7
        {
            get { return Fields.ReceiptNoAnlys7[this]; }
            set { Fields.ReceiptNoAnlys7[this] = value; }
        }

        [DisplayName("Receipt No Anlys8"), Expression("jReceiptNo.[ANLYS8]")]
        public String ReceiptNoAnlys8
        {
            get { return Fields.ReceiptNoAnlys8[this]; }
            set { Fields.ReceiptNoAnlys8[this] = value; }
        }

        [DisplayName("Receipt No To Open"), Expression("jReceiptNo.[TO_OPEN]")]
        public String ReceiptNoToOpen
        {
            get { return Fields.ReceiptNoToOpen[this]; }
            set { Fields.ReceiptNoToOpen[this] = value; }
        }

        [DisplayName("Receipt No To Round"), Expression("jReceiptNo.[TO_ROUND]")]
        public String ReceiptNoToRound
        {
            get { return Fields.ReceiptNoToRound[this]; }
            set { Fields.ReceiptNoToRound[this] = value; }
        }

        [DisplayName("Receipt No Gbcust Invo Amt Diff"), Expression("jReceiptNo.[GBCUST_INVO_AMT_DIFF]")]
        public Decimal? ReceiptNoGbcustInvoAmtDiff
        {
            get { return Fields.ReceiptNoGbcustInvoAmtDiff[this]; }
            set { Fields.ReceiptNoGbcustInvoAmtDiff[this] = value; }
        }

        [DisplayName("Receipt No Gbcust Open Amt Diff"), Expression("jReceiptNo.[GBCUST_OPEN_AMT_DIFF]")]
        public Decimal? ReceiptNoGbcustOpenAmtDiff
        {
            get { return Fields.ReceiptNoGbcustOpenAmtDiff[this]; }
            set { Fields.ReceiptNoGbcustOpenAmtDiff[this] = value; }
        }

        [DisplayName("Receipt No Arledg Total Debit"), Expression("jReceiptNo.[ARLEDG_TOTAL_DEBIT]")]
        public Decimal? ReceiptNoArledgTotalDebit
        {
            get { return Fields.ReceiptNoArledgTotalDebit[this]; }
            set { Fields.ReceiptNoArledgTotalDebit[this] = value; }
        }

        [DisplayName("Receipt No Arledg Total Credit"), Expression("jReceiptNo.[ARLEDG_TOTAL_CREDIT]")]
        public Decimal? ReceiptNoArledgTotalCredit
        {
            get { return Fields.ReceiptNoArledgTotalCredit[this]; }
            set { Fields.ReceiptNoArledgTotalCredit[this] = value; }
        }

        [DisplayName("Receipt No Allow Cancel"), Expression("jReceiptNo.[ALLOW_CANCEL]")]
        public String ReceiptNoAllowCancel
        {
            get { return Fields.ReceiptNoAllowCancel[this]; }
            set { Fields.ReceiptNoAllowCancel[this] = value; }
        }

        [DisplayName("Receipt No Payer"), Expression("jReceiptNo.[PAYER]")]
        public String ReceiptNoPayer
        {
            get { return Fields.ReceiptNoPayer[this]; }
            set { Fields.ReceiptNoPayer[this] = value; }
        }

        [DisplayName("Receipt No Charge Amt"), Expression("jReceiptNo.[CHARGE_AMT]")]
        public Decimal? ReceiptNoChargeAmt
        {
            get { return Fields.ReceiptNoChargeAmt[this]; }
            set { Fields.ReceiptNoChargeAmt[this] = value; }
        }

        [DisplayName("Receipt No Charge Amt Local"), Expression("jReceiptNo.[CHARGE_AMT_LOCAL]")]
        public Decimal? ReceiptNoChargeAmtLocal
        {
            get { return Fields.ReceiptNoChargeAmtLocal[this]; }
            set { Fields.ReceiptNoChargeAmtLocal[this] = value; }
        }

        [DisplayName("Receipt No Anlys9"), Expression("jReceiptNo.[ANLYS9]")]
        public String ReceiptNoAnlys9
        {
            get { return Fields.ReceiptNoAnlys9[this]; }
            set { Fields.ReceiptNoAnlys9[this] = value; }
        }

        [DisplayName("Receipt No Anlys10"), Expression("jReceiptNo.[ANLYS10]")]
        public String ReceiptNoAnlys10
        {
            get { return Fields.ReceiptNoAnlys10[this]; }
            set { Fields.ReceiptNoAnlys10[this] = value; }
        }

        [DisplayName("Receipt No Anlys11"), Expression("jReceiptNo.[ANLYS11]")]
        public String ReceiptNoAnlys11
        {
            get { return Fields.ReceiptNoAnlys11[this]; }
            set { Fields.ReceiptNoAnlys11[this] = value; }
        }

        [DisplayName("Receipt No Anlys12"), Expression("jReceiptNo.[ANLYS12]")]
        public String ReceiptNoAnlys12
        {
            get { return Fields.ReceiptNoAnlys12[this]; }
            set { Fields.ReceiptNoAnlys12[this] = value; }
        }

        [DisplayName("Receipt No Anlys13"), Expression("jReceiptNo.[ANLYS13]")]
        public String ReceiptNoAnlys13
        {
            get { return Fields.ReceiptNoAnlys13[this]; }
            set { Fields.ReceiptNoAnlys13[this] = value; }
        }

        [DisplayName("Receipt No Anlys14"), Expression("jReceiptNo.[ANLYS14]")]
        public String ReceiptNoAnlys14
        {
            get { return Fields.ReceiptNoAnlys14[this]; }
            set { Fields.ReceiptNoAnlys14[this] = value; }
        }

        [DisplayName("Receipt No Acct Deposit"), Expression("jReceiptNo.[ACCT_DEPOSIT]")]
        public String ReceiptNoAcctDeposit
        {
            get { return Fields.ReceiptNoAcctDeposit[this]; }
            set { Fields.ReceiptNoAcctDeposit[this] = value; }
        }

        [DisplayName("Receipt No Bal Amt Local"), Expression("jReceiptNo.[BAL_AMT_LOCAL]")]
        public Decimal? ReceiptNoBalAmtLocal
        {
            get { return Fields.ReceiptNoBalAmtLocal[this]; }
            set { Fields.ReceiptNoBalAmtLocal[this] = value; }
        }

        [DisplayName("Invoice No Recnum"), Expression("jInvoiceNo.[RECNUM]")]
        public Decimal? InvoiceNoRecnum
        {
            get { return Fields.InvoiceNoRecnum[this]; }
            set { Fields.InvoiceNoRecnum[this] = value; }
        }

        [DisplayName("Invoice No Direct Entry"), Expression("jInvoiceNo.[DIRECT_ENTRY]")]
        public String InvoiceNoDirectEntry
        {
            get { return Fields.InvoiceNoDirectEntry[this]; }
            set { Fields.InvoiceNoDirectEntry[this] = value; }
        }

        [DisplayName("Invoice No Posted"), Expression("jInvoiceNo.[POSTED]")]
        public String InvoiceNoPosted
        {
            get { return Fields.InvoiceNoPosted[this]; }
            set { Fields.InvoiceNoPosted[this] = value; }
        }

        [DisplayName("Invoice No Closed"), Expression("jInvoiceNo.[CLOSED]")]
        public String InvoiceNoClosed
        {
            get { return Fields.InvoiceNoClosed[this]; }
            set { Fields.InvoiceNoClosed[this] = value; }
        }

        [DisplayName("Invoice No Returned"), Expression("jInvoiceNo.[RETURNED]")]
        public String InvoiceNoReturned
        {
            get { return Fields.InvoiceNoReturned[this]; }
            set { Fields.InvoiceNoReturned[this] = value; }
        }

        [DisplayName("Invoice No Debit Note"), Expression("jInvoiceNo.[DEBIT_NOTE]")]
        public String InvoiceNoDebitNote
        {
            get { return Fields.InvoiceNoDebitNote[this]; }
            set { Fields.InvoiceNoDebitNote[this] = value; }
        }

        [DisplayName("Invoice No Customer No"), Expression("jInvoiceNo.[CUSTOMER_NO]")]
        public String InvoiceNoCustomerNo
        {
            get { return Fields.InvoiceNoCustomerNo[this]; }
            set { Fields.InvoiceNoCustomerNo[this] = value; }
        }

        [DisplayName("Invoice No Customer Name"), Expression("jInvoiceNo.[CUSTOMER_NAME]")]
        public String InvoiceNoCustomerName
        {
            get { return Fields.InvoiceNoCustomerName[this]; }
            set { Fields.InvoiceNoCustomerName[this] = value; }
        }

        [DisplayName("Invoice No Address"), Expression("jInvoiceNo.[ADDRESS]")]
        public String InvoiceNoAddress
        {
            get { return Fields.InvoiceNoAddress[this]; }
            set { Fields.InvoiceNoAddress[this] = value; }
        }

        [DisplayName("Invoice No Address2"), Expression("jInvoiceNo.[ADDRESS2]")]
        public String InvoiceNoAddress2
        {
            get { return Fields.InvoiceNoAddress2[this]; }
            set { Fields.InvoiceNoAddress2[this] = value; }
        }

        [DisplayName("Invoice No Address3"), Expression("jInvoiceNo.[ADDRESS3]")]
        public String InvoiceNoAddress3
        {
            get { return Fields.InvoiceNoAddress3[this]; }
            set { Fields.InvoiceNoAddress3[this] = value; }
        }

        [DisplayName("Invoice No Address4"), Expression("jInvoiceNo.[ADDRESS4]")]
        public String InvoiceNoAddress4
        {
            get { return Fields.InvoiceNoAddress4[this]; }
            set { Fields.InvoiceNoAddress4[this] = value; }
        }

        [DisplayName("Invoice No Attention"), Expression("jInvoiceNo.[ATTENTION]")]
        public String InvoiceNoAttention
        {
            get { return Fields.InvoiceNoAttention[this]; }
            set { Fields.InvoiceNoAttention[this] = value; }
        }

        [DisplayName("Invoice No Invoice Date"), Expression("jInvoiceNo.[INVOICE_DATE]")]
        public DateTime? InvoiceNoInvoiceDate
        {
            get { return Fields.InvoiceNoInvoiceDate[this]; }
            set { Fields.InvoiceNoInvoiceDate[this] = value; }
        }

        [DisplayName("Invoice No Period"), Expression("jInvoiceNo.[PERIOD]")]
        public String InvoiceNoPeriod
        {
            get { return Fields.InvoiceNoPeriod[this]; }
            set { Fields.InvoiceNoPeriod[this] = value; }
        }

        [DisplayName("Invoice No Fiscal Year"), Expression("jInvoiceNo.[FISCAL_YEAR]")]
        public Decimal? InvoiceNoFiscalYear
        {
            get { return Fields.InvoiceNoFiscalYear[this]; }
            set { Fields.InvoiceNoFiscalYear[this] = value; }
        }

        [DisplayName("Invoice No Period No"), Expression("jInvoiceNo.[PERIOD_NO]")]
        public Decimal? InvoiceNoPeriodNo
        {
            get { return Fields.InvoiceNoPeriodNo[this]; }
            set { Fields.InvoiceNoPeriodNo[this] = value; }
        }

        [DisplayName("Invoice No Salesman"), Expression("jInvoiceNo.[SALESMAN]")]
        public String InvoiceNoSalesman
        {
            get { return Fields.InvoiceNoSalesman[this]; }
            set { Fields.InvoiceNoSalesman[this] = value; }
        }

        [DisplayName("Invoice No Ccy"), Expression("jInvoiceNo.[CCY]")]
        public String InvoiceNoCcy
        {
            get { return Fields.InvoiceNoCcy[this]; }
            set { Fields.InvoiceNoCcy[this] = value; }
        }

        [DisplayName("Invoice No Exch Rate"), Expression("jInvoiceNo.[EXCH_RATE]")]
        public Decimal? InvoiceNoExchRate
        {
            get { return Fields.InvoiceNoExchRate[this]; }
            set { Fields.InvoiceNoExchRate[this] = value; }
        }

        [DisplayName("Invoice No Pay Terms"), Expression("jInvoiceNo.[PAY_TERMS]")]
        public String InvoiceNoPayTerms
        {
            get { return Fields.InvoiceNoPayTerms[this]; }
            set { Fields.InvoiceNoPayTerms[this] = value; }
        }

        [DisplayName("Invoice No Disc Days"), Expression("jInvoiceNo.[DISC_DAYS]")]
        public Decimal? InvoiceNoDiscDays
        {
            get { return Fields.InvoiceNoDiscDays[this]; }
            set { Fields.InvoiceNoDiscDays[this] = value; }
        }

        [DisplayName("Invoice No Disc Pcent"), Expression("jInvoiceNo.[DISC_PCENT]")]
        public Decimal? InvoiceNoDiscPcent
        {
            get { return Fields.InvoiceNoDiscPcent[this]; }
            set { Fields.InvoiceNoDiscPcent[this] = value; }
        }

        [DisplayName("Invoice No Due Days"), Expression("jInvoiceNo.[DUE_DAYS]")]
        public Decimal? InvoiceNoDueDays
        {
            get { return Fields.InvoiceNoDueDays[this]; }
            set { Fields.InvoiceNoDueDays[this] = value; }
        }

        [DisplayName("Invoice No Discount Date"), Expression("jInvoiceNo.[DISCOUNT_DATE]")]
        public DateTime? InvoiceNoDiscountDate
        {
            get { return Fields.InvoiceNoDiscountDate[this]; }
            set { Fields.InvoiceNoDiscountDate[this] = value; }
        }

        [DisplayName("Invoice No Due Date"), Expression("jInvoiceNo.[DUE_DATE]")]
        public DateTime? InvoiceNoDueDate
        {
            get { return Fields.InvoiceNoDueDate[this]; }
            set { Fields.InvoiceNoDueDate[this] = value; }
        }

        [DisplayName("Invoice No Expected Date"), Expression("jInvoiceNo.[EXPECTED_DATE]")]
        public DateTime? InvoiceNoExpectedDate
        {
            get { return Fields.InvoiceNoExpectedDate[this]; }
            set { Fields.InvoiceNoExpectedDate[this] = value; }
        }

        [DisplayName("Invoice No Anlys1"), Expression("jInvoiceNo.[ANLYS1]")]
        public String InvoiceNoAnlys1
        {
            get { return Fields.InvoiceNoAnlys1[this]; }
            set { Fields.InvoiceNoAnlys1[this] = value; }
        }

        [DisplayName("Invoice No Anlys2"), Expression("jInvoiceNo.[ANLYS2]")]
        public String InvoiceNoAnlys2
        {
            get { return Fields.InvoiceNoAnlys2[this]; }
            set { Fields.InvoiceNoAnlys2[this] = value; }
        }

        [DisplayName("Invoice No Tot Price Amt"), Expression("jInvoiceNo.[TOT_PRICE_AMT]")]
        public Decimal? InvoiceNoTotPriceAmt
        {
            get { return Fields.InvoiceNoTotPriceAmt[this]; }
            set { Fields.InvoiceNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Price Amt"), Expression("jInvoiceNo.[LOC_PRICE_AMT]")]
        public Decimal? InvoiceNoLocPriceAmt
        {
            get { return Fields.InvoiceNoLocPriceAmt[this]; }
            set { Fields.InvoiceNoLocPriceAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Ptax Amt"), Expression("jInvoiceNo.[TOT_PTAX_AMT]")]
        public Decimal? InvoiceNoTotPtaxAmt
        {
            get { return Fields.InvoiceNoTotPtaxAmt[this]; }
            set { Fields.InvoiceNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Ptax Amt"), Expression("jInvoiceNo.[LOC_PTAX_AMT]")]
        public Decimal? InvoiceNoLocPtaxAmt
        {
            get { return Fields.InvoiceNoLocPtaxAmt[this]; }
            set { Fields.InvoiceNoLocPtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Ext Price"), Expression("jInvoiceNo.[TOT_EXT_PRICE]")]
        public Decimal? InvoiceNoTotExtPrice
        {
            get { return Fields.InvoiceNoTotExtPrice[this]; }
            set { Fields.InvoiceNoTotExtPrice[this] = value; }
        }

        [DisplayName("Invoice No Loc Ext Price"), Expression("jInvoiceNo.[LOC_EXT_PRICE]")]
        public Decimal? InvoiceNoLocExtPrice
        {
            get { return Fields.InvoiceNoLocExtPrice[this]; }
            set { Fields.InvoiceNoLocExtPrice[this] = value; }
        }

        [DisplayName("Invoice No Tot Ldisc Amt"), Expression("jInvoiceNo.[TOT_LDISC_AMT]")]
        public Decimal? InvoiceNoTotLdiscAmt
        {
            get { return Fields.InvoiceNoTotLdiscAmt[this]; }
            set { Fields.InvoiceNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Ldisc Amt"), Expression("jInvoiceNo.[LOC_LDISC_AMT]")]
        public Decimal? InvoiceNoLocLdiscAmt
        {
            get { return Fields.InvoiceNoLocLdiscAmt[this]; }
            set { Fields.InvoiceNoLocLdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Atax Amt"), Expression("jInvoiceNo.[TOT_ATAX_AMT]")]
        public Decimal? InvoiceNoTotAtaxAmt
        {
            get { return Fields.InvoiceNoTotAtaxAmt[this]; }
            set { Fields.InvoiceNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Atax Amt"), Expression("jInvoiceNo.[LOC_ATAX_AMT]")]
        public Decimal? InvoiceNoLocAtaxAmt
        {
            get { return Fields.InvoiceNoLocAtaxAmt[this]; }
            set { Fields.InvoiceNoLocAtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Item Amt"), Expression("jInvoiceNo.[TOT_ITEM_AMT]")]
        public Decimal? InvoiceNoTotItemAmt
        {
            get { return Fields.InvoiceNoTotItemAmt[this]; }
            set { Fields.InvoiceNoTotItemAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Item Amt"), Expression("jInvoiceNo.[LOC_ITEM_AMT]")]
        public Decimal? InvoiceNoLocItemAmt
        {
            get { return Fields.InvoiceNoLocItemAmt[this]; }
            set { Fields.InvoiceNoLocItemAmt[this] = value; }
        }

        [DisplayName("Invoice No Tdisc Pcent"), Expression("jInvoiceNo.[TDISC_PCENT]")]
        public Decimal? InvoiceNoTdiscPcent
        {
            get { return Fields.InvoiceNoTdiscPcent[this]; }
            set { Fields.InvoiceNoTdiscPcent[this] = value; }
        }

        [DisplayName("Invoice No Tdisc Amt"), Expression("jInvoiceNo.[TDISC_AMT]")]
        public Decimal? InvoiceNoTdiscAmt
        {
            get { return Fields.InvoiceNoTdiscAmt[this]; }
            set { Fields.InvoiceNoTdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Local Tdisc Amt"), Expression("jInvoiceNo.[LOCAL_TDISC_AMT]")]
        public Decimal? InvoiceNoLocalTdiscAmt
        {
            get { return Fields.InvoiceNoLocalTdiscAmt[this]; }
            set { Fields.InvoiceNoLocalTdiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Chgs Amt"), Expression("jInvoiceNo.[CHGS_AMT]")]
        public Decimal? InvoiceNoChgsAmt
        {
            get { return Fields.InvoiceNoChgsAmt[this]; }
            set { Fields.InvoiceNoChgsAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Chgs Amt"), Expression("jInvoiceNo.[LOC_CHGS_AMT]")]
        public Decimal? InvoiceNoLocChgsAmt
        {
            get { return Fields.InvoiceNoLocChgsAmt[this]; }
            set { Fields.InvoiceNoLocChgsAmt[this] = value; }
        }

        [DisplayName("Invoice No Gtax Amt"), Expression("jInvoiceNo.[GTAX_AMT]")]
        public Decimal? InvoiceNoGtaxAmt
        {
            get { return Fields.InvoiceNoGtaxAmt[this]; }
            set { Fields.InvoiceNoGtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Local Gtax Amt"), Expression("jInvoiceNo.[LOCAL_GTAX_AMT]")]
        public Decimal? InvoiceNoLocalGtaxAmt
        {
            get { return Fields.InvoiceNoLocalGtaxAmt[this]; }
            set { Fields.InvoiceNoLocalGtaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Net Amt"), Expression("jInvoiceNo.[NET_AMT]")]
        public Decimal? InvoiceNoNetAmt
        {
            get { return Fields.InvoiceNoNetAmt[this]; }
            set { Fields.InvoiceNoNetAmt[this] = value; }
        }

        [DisplayName("Invoice No Local Net Amt"), Expression("jInvoiceNo.[LOCAL_NET_AMT]")]
        public Decimal? InvoiceNoLocalNetAmt
        {
            get { return Fields.InvoiceNoLocalNetAmt[this]; }
            set { Fields.InvoiceNoLocalNetAmt[this] = value; }
        }

        [DisplayName("Invoice No Tdisc Amt Cpd"), Expression("jInvoiceNo.[TDISC_AMT_CPD]")]
        public Decimal? InvoiceNoTdiscAmtCpd
        {
            get { return Fields.InvoiceNoTdiscAmtCpd[this]; }
            set { Fields.InvoiceNoTdiscAmtCpd[this] = value; }
        }

        [DisplayName("Invoice No Last Line No"), Expression("jInvoiceNo.[LAST_LINE_NO]")]
        public Decimal? InvoiceNoLastLineNo
        {
            get { return Fields.InvoiceNoLastLineNo[this]; }
            set { Fields.InvoiceNoLastLineNo[this] = value; }
        }

        [DisplayName("Invoice No Created Date"), Expression("jInvoiceNo.[CREATED_DATE]")]
        public DateTime? InvoiceNoCreatedDate
        {
            get { return Fields.InvoiceNoCreatedDate[this]; }
            set { Fields.InvoiceNoCreatedDate[this] = value; }
        }

        [DisplayName("Invoice No Created By"), Expression("jInvoiceNo.[CREATED_BY]")]
        public String InvoiceNoCreatedBy
        {
            get { return Fields.InvoiceNoCreatedBy[this]; }
            set { Fields.InvoiceNoCreatedBy[this] = value; }
        }

        [DisplayName("Invoice No Revised Date"), Expression("jInvoiceNo.[REVISED_DATE]")]
        public DateTime? InvoiceNoRevisedDate
        {
            get { return Fields.InvoiceNoRevisedDate[this]; }
            set { Fields.InvoiceNoRevisedDate[this] = value; }
        }

        [DisplayName("Invoice No Revised By"), Expression("jInvoiceNo.[REVISED_BY]")]
        public String InvoiceNoRevisedBy
        {
            get { return Fields.InvoiceNoRevisedBy[this]; }
            set { Fields.InvoiceNoRevisedBy[this] = value; }
        }

        [DisplayName("Invoice No Posted Date"), Expression("jInvoiceNo.[POSTED_DATE]")]
        public DateTime? InvoiceNoPostedDate
        {
            get { return Fields.InvoiceNoPostedDate[this]; }
            set { Fields.InvoiceNoPostedDate[this] = value; }
        }

        [DisplayName("Invoice No Posted By"), Expression("jInvoiceNo.[POSTED_BY]")]
        public String InvoiceNoPostedBy
        {
            get { return Fields.InvoiceNoPostedBy[this]; }
            set { Fields.InvoiceNoPostedBy[this] = value; }
        }

        [DisplayName("Invoice No Last Log No"), Expression("jInvoiceNo.[LAST_LOG_NO]")]
        public Decimal? InvoiceNoLastLogNo
        {
            get { return Fields.InvoiceNoLastLogNo[this]; }
            set { Fields.InvoiceNoLastLogNo[this] = value; }
        }

        [DisplayName("Invoice No Settled Amt"), Expression("jInvoiceNo.[SETTLED_AMT]")]
        public Decimal? InvoiceNoSettledAmt
        {
            get { return Fields.InvoiceNoSettledAmt[this]; }
            set { Fields.InvoiceNoSettledAmt[this] = value; }
        }

        [DisplayName("Invoice No Lsettled Amt"), Expression("jInvoiceNo.[LSETTLED_AMT]")]
        public Decimal? InvoiceNoLsettledAmt
        {
            get { return Fields.InvoiceNoLsettledAmt[this]; }
            set { Fields.InvoiceNoLsettledAmt[this] = value; }
        }

        [DisplayName("Invoice No Term Disc Amt"), Expression("jInvoiceNo.[TERM_DISC_AMT]")]
        public Decimal? InvoiceNoTermDiscAmt
        {
            get { return Fields.InvoiceNoTermDiscAmt[this]; }
            set { Fields.InvoiceNoTermDiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Lterm Disc Amt"), Expression("jInvoiceNo.[LTERM_DISC_AMT]")]
        public Decimal? InvoiceNoLtermDiscAmt
        {
            get { return Fields.InvoiceNoLtermDiscAmt[this]; }
            set { Fields.InvoiceNoLtermDiscAmt[this] = value; }
        }

        [DisplayName("Invoice No Return Amt"), Expression("jInvoiceNo.[RETURN_AMT]")]
        public Decimal? InvoiceNoReturnAmt
        {
            get { return Fields.InvoiceNoReturnAmt[this]; }
            set { Fields.InvoiceNoReturnAmt[this] = value; }
        }

        [DisplayName("Invoice No Lreturn Amt"), Expression("jInvoiceNo.[LRETURN_AMT]")]
        public Decimal? InvoiceNoLreturnAmt
        {
            get { return Fields.InvoiceNoLreturnAmt[this]; }
            set { Fields.InvoiceNoLreturnAmt[this] = value; }
        }

        [DisplayName("Invoice No Bal Amt"), Expression("jInvoiceNo.[BAL_AMT]")]
        public Decimal? InvoiceNoBalAmt
        {
            get { return Fields.InvoiceNoBalAmt[this]; }
            set { Fields.InvoiceNoBalAmt[this] = value; }
        }

        [DisplayName("Invoice No Bal Amt Local"), Expression("jInvoiceNo.[BAL_AMT_LOCAL]")]
        public Decimal? InvoiceNoBalAmtLocal
        {
            get { return Fields.InvoiceNoBalAmtLocal[this]; }
            set { Fields.InvoiceNoBalAmtLocal[this] = value; }
        }

        [DisplayName("Invoice No Over Alloc Amt"), Expression("jInvoiceNo.[OVER_ALLOC_AMT]")]
        public Decimal? InvoiceNoOverAllocAmt
        {
            get { return Fields.InvoiceNoOverAllocAmt[this]; }
            set { Fields.InvoiceNoOverAllocAmt[this] = value; }
        }

        [DisplayName("Invoice No Lover Alloc Amt"), Expression("jInvoiceNo.[LOVER_ALLOC_AMT]")]
        public Decimal? InvoiceNoLoverAllocAmt
        {
            get { return Fields.InvoiceNoLoverAllocAmt[this]; }
            set { Fields.InvoiceNoLoverAllocAmt[this] = value; }
        }

        [DisplayName("Invoice No Acct Customer"), Expression("jInvoiceNo.[ACCT_CUSTOMER]")]
        public String InvoiceNoAcctCustomer
        {
            get { return Fields.InvoiceNoAcctCustomer[this]; }
            set { Fields.InvoiceNoAcctCustomer[this] = value; }
        }

        [DisplayName("Invoice No Acct Tdisc"), Expression("jInvoiceNo.[ACCT_TDISC]")]
        public String InvoiceNoAcctTdisc
        {
            get { return Fields.InvoiceNoAcctTdisc[this]; }
            set { Fields.InvoiceNoAcctTdisc[this] = value; }
        }

        [DisplayName("Invoice No Acct Gtax"), Expression("jInvoiceNo.[ACCT_GTAX]")]
        public String InvoiceNoAcctGtax
        {
            get { return Fields.InvoiceNoAcctGtax[this]; }
            set { Fields.InvoiceNoAcctGtax[this] = value; }
        }

        [DisplayName("Invoice No Lock Type"), Expression("jInvoiceNo.[LOCK_TYPE]")]
        public String InvoiceNoLockType
        {
            get { return Fields.InvoiceNoLockType[this]; }
            set { Fields.InvoiceNoLockType[this] = value; }
        }

        [DisplayName("Invoice No Lock Ref No"), Expression("jInvoiceNo.[LOCK_REF_NO]")]
        public String InvoiceNoLockRefNo
        {
            get { return Fields.InvoiceNoLockRefNo[this]; }
            set { Fields.InvoiceNoLockRefNo[this] = value; }
        }

        [DisplayName("Invoice No Batch Select"), Expression("jInvoiceNo.[BATCH_SELECT]")]
        public String InvoiceNoBatchSelect
        {
            get { return Fields.InvoiceNoBatchSelect[this]; }
            set { Fields.InvoiceNoBatchSelect[this] = value; }
        }

        [DisplayName("Invoice No Gl Link"), Expression("jInvoiceNo.[GL_LINK]")]
        public String InvoiceNoGlLink
        {
            get { return Fields.InvoiceNoGlLink[this]; }
            set { Fields.InvoiceNoGlLink[this] = value; }
        }

        [DisplayName("Invoice No Gl Link Type"), Expression("jInvoiceNo.[GL_LINK_TYPE]")]
        public String InvoiceNoGlLinkType
        {
            get { return Fields.InvoiceNoGlLinkType[this]; }
            set { Fields.InvoiceNoGlLinkType[this] = value; }
        }

        [DisplayName("Invoice No Gl Link No"), Expression("jInvoiceNo.[GL_LINK_NO]")]
        public String InvoiceNoGlLinkNo
        {
            get { return Fields.InvoiceNoGlLinkNo[this]; }
            set { Fields.InvoiceNoGlLinkNo[this] = value; }
        }

        [DisplayName("Invoice No Owner Branch"), Expression("jInvoiceNo.[OWNER_BRANCH]")]
        public String InvoiceNoOwnerBranch
        {
            get { return Fields.InvoiceNoOwnerBranch[this]; }
            set { Fields.InvoiceNoOwnerBranch[this] = value; }
        }

        [DisplayName("Invoice No Source Branch"), Expression("jInvoiceNo.[SOURCE_BRANCH]")]
        public String InvoiceNoSourceBranch
        {
            get { return Fields.InvoiceNoSourceBranch[this]; }
            set { Fields.InvoiceNoSourceBranch[this] = value; }
        }

        [DisplayName("Invoice No Check Crlimit"), Expression("jInvoiceNo.[CHECK_CRLIMIT]")]
        public String InvoiceNoCheckCrlimit
        {
            get { return Fields.InvoiceNoCheckCrlimit[this]; }
            set { Fields.InvoiceNoCheckCrlimit[this] = value; }
        }

        [DisplayName("Invoice No Check Crbal"), Expression("jInvoiceNo.[CHECK_CRBAL]")]
        public Decimal? InvoiceNoCheckCrbal
        {
            get { return Fields.InvoiceNoCheckCrbal[this]; }
            set { Fields.InvoiceNoCheckCrbal[this] = value; }
        }

        [DisplayName("Invoice No Comments1"), Expression("jInvoiceNo.[COMMENTS1]")]
        public String InvoiceNoComments1
        {
            get { return Fields.InvoiceNoComments1[this]; }
            set { Fields.InvoiceNoComments1[this] = value; }
        }

        [DisplayName("Invoice No Comments2"), Expression("jInvoiceNo.[COMMENTS2]")]
        public String InvoiceNoComments2
        {
            get { return Fields.InvoiceNoComments2[this]; }
            set { Fields.InvoiceNoComments2[this] = value; }
        }

        [DisplayName("Invoice No Comments3"), Expression("jInvoiceNo.[COMMENTS3]")]
        public String InvoiceNoComments3
        {
            get { return Fields.InvoiceNoComments3[this]; }
            set { Fields.InvoiceNoComments3[this] = value; }
        }

        [DisplayName("Invoice No Comments4"), Expression("jInvoiceNo.[COMMENTS4]")]
        public String InvoiceNoComments4
        {
            get { return Fields.InvoiceNoComments4[this]; }
            set { Fields.InvoiceNoComments4[this] = value; }
        }

        [DisplayName("Invoice No Last Text No"), Expression("jInvoiceNo.[LAST_TEXT_NO]")]
        public Decimal? InvoiceNoLastTextNo
        {
            get { return Fields.InvoiceNoLastTextNo[this]; }
            set { Fields.InvoiceNoLastTextNo[this] = value; }
        }

        [DisplayName("Invoice No Ship To"), Expression("jInvoiceNo.[SHIP_TO]")]
        public String InvoiceNoShipTo
        {
            get { return Fields.InvoiceNoShipTo[this]; }
            set { Fields.InvoiceNoShipTo[this] = value; }
        }

        [DisplayName("Invoice No Tel No"), Expression("jInvoiceNo.[TEL_NO]")]
        public String InvoiceNoTelNo
        {
            get { return Fields.InvoiceNoTelNo[this]; }
            set { Fields.InvoiceNoTelNo[this] = value; }
        }

        [DisplayName("Invoice No Fax No"), Expression("jInvoiceNo.[FAX_NO]")]
        public String InvoiceNoFaxNo
        {
            get { return Fields.InvoiceNoFaxNo[this]; }
            set { Fields.InvoiceNoFaxNo[this] = value; }
        }

        [DisplayName("Invoice No Sltax Type"), Expression("jInvoiceNo.[SLTAX_TYPE]")]
        public String InvoiceNoSltaxType
        {
            get { return Fields.InvoiceNoSltaxType[this]; }
            set { Fields.InvoiceNoSltaxType[this] = value; }
        }

        [DisplayName("Invoice No Gsltax Pcent"), Expression("jInvoiceNo.[GSLTAX_PCENT]")]
        public Decimal? InvoiceNoGsltaxPcent
        {
            get { return Fields.InvoiceNoGsltaxPcent[this]; }
            set { Fields.InvoiceNoGsltaxPcent[this] = value; }
        }

        [DisplayName("Invoice No Tot Gsltax Amt"), Expression("jInvoiceNo.[TOT_GSLTAX_AMT]")]
        public Decimal? InvoiceNoTotGsltaxAmt
        {
            get { return Fields.InvoiceNoTotGsltaxAmt[this]; }
            set { Fields.InvoiceNoTotGsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Tot Lsltax Amt"), Expression("jInvoiceNo.[TOT_LSLTAX_AMT]")]
        public Decimal? InvoiceNoTotLsltaxAmt
        {
            get { return Fields.InvoiceNoTotLsltaxAmt[this]; }
            set { Fields.InvoiceNoTotLsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Gsltax Amt"), Expression("jInvoiceNo.[LOC_GSLTAX_AMT]")]
        public Decimal? InvoiceNoLocGsltaxAmt
        {
            get { return Fields.InvoiceNoLocGsltaxAmt[this]; }
            set { Fields.InvoiceNoLocGsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Loc Lsltax Amt"), Expression("jInvoiceNo.[LOC_LSLTAX_AMT]")]
        public Decimal? InvoiceNoLocLsltaxAmt
        {
            get { return Fields.InvoiceNoLocLsltaxAmt[this]; }
            set { Fields.InvoiceNoLocLsltaxAmt[this] = value; }
        }

        [DisplayName("Invoice No Acct Sltax"), Expression("jInvoiceNo.[ACCT_SLTAX]")]
        public String InvoiceNoAcctSltax
        {
            get { return Fields.InvoiceNoAcctSltax[this]; }
            set { Fields.InvoiceNoAcctSltax[this] = value; }
        }

        [DisplayName("Invoice No Customer Po"), Expression("jInvoiceNo.[CUSTOMER_PO]")]
        public String InvoiceNoCustomerPo
        {
            get { return Fields.InvoiceNoCustomerPo[this]; }
            set { Fields.InvoiceNoCustomerPo[this] = value; }
        }

        [DisplayName("Invoice No Ai Link"), Expression("jInvoiceNo.[AI_LINK]")]
        public String InvoiceNoAiLink
        {
            get { return Fields.InvoiceNoAiLink[this]; }
            set { Fields.InvoiceNoAiLink[this] = value; }
        }

        [DisplayName("Invoice No Ai Link Type"), Expression("jInvoiceNo.[AI_LINK_TYPE]")]
        public String InvoiceNoAiLinkType
        {
            get { return Fields.InvoiceNoAiLinkType[this]; }
            set { Fields.InvoiceNoAiLinkType[this] = value; }
        }

        [DisplayName("Invoice No Ai Link No"), Expression("jInvoiceNo.[AI_LINK_NO]")]
        public String InvoiceNoAiLinkNo
        {
            get { return Fields.InvoiceNoAiLinkNo[this]; }
            set { Fields.InvoiceNoAiLinkNo[this] = value; }
        }

        [DisplayName("Invoice No Anlys7"), Expression("jInvoiceNo.[ANLYS7]")]
        public String InvoiceNoAnlys7
        {
            get { return Fields.InvoiceNoAnlys7[this]; }
            set { Fields.InvoiceNoAnlys7[this] = value; }
        }

        [DisplayName("Invoice No Anlys8"), Expression("jInvoiceNo.[ANLYS8]")]
        public String InvoiceNoAnlys8
        {
            get { return Fields.InvoiceNoAnlys8[this]; }
            set { Fields.InvoiceNoAnlys8[this] = value; }
        }

        [DisplayName("Invoice No Net Trade Amt"), Expression("jInvoiceNo.[NET_TRADE_AMT]")]
        public Decimal? InvoiceNoNetTradeAmt
        {
            get { return Fields.InvoiceNoNetTradeAmt[this]; }
            set { Fields.InvoiceNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Invoice No Net Ordr Amt"), Expression("jInvoiceNo.[NET_ORDR_AMT]")]
        public Decimal? InvoiceNoNetOrdrAmt
        {
            get { return Fields.InvoiceNoNetOrdrAmt[this]; }
            set { Fields.InvoiceNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Invoice No Ship Amt"), Expression("jInvoiceNo.[SHIP_AMT]")]
        public Decimal? InvoiceNoShipAmt
        {
            get { return Fields.InvoiceNoShipAmt[this]; }
            set { Fields.InvoiceNoShipAmt[this] = value; }
        }

        [DisplayName("Invoice No Lship Amt"), Expression("jInvoiceNo.[LSHIP_AMT]")]
        public Decimal? InvoiceNoLshipAmt
        {
            get { return Fields.InvoiceNoLshipAmt[this]; }
            set { Fields.InvoiceNoLshipAmt[this] = value; }
        }

        [DisplayName("Invoice No Varia Amt"), Expression("jInvoiceNo.[VARIA_AMT]")]
        public Decimal? InvoiceNoVariaAmt
        {
            get { return Fields.InvoiceNoVariaAmt[this]; }
            set { Fields.InvoiceNoVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Lvaria Amt"), Expression("jInvoiceNo.[LVARIA_AMT]")]
        public Decimal? InvoiceNoLvariaAmt
        {
            get { return Fields.InvoiceNoLvariaAmt[this]; }
            set { Fields.InvoiceNoLvariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Item Varia Amt"), Expression("jInvoiceNo.[ITEM_VARIA_AMT]")]
        public Decimal? InvoiceNoItemVariaAmt
        {
            get { return Fields.InvoiceNoItemVariaAmt[this]; }
            set { Fields.InvoiceNoItemVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Litem Varia Amt"), Expression("jInvoiceNo.[LITEM_VARIA_AMT]")]
        public Decimal? InvoiceNoLitemVariaAmt
        {
            get { return Fields.InvoiceNoLitemVariaAmt[this]; }
            set { Fields.InvoiceNoLitemVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Chgs Varia Amt"), Expression("jInvoiceNo.[CHGS_VARIA_AMT]")]
        public Decimal? InvoiceNoChgsVariaAmt
        {
            get { return Fields.InvoiceNoChgsVariaAmt[this]; }
            set { Fields.InvoiceNoChgsVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Lchgs Varia Amt"), Expression("jInvoiceNo.[LCHGS_VARIA_AMT]")]
        public Decimal? InvoiceNoLchgsVariaAmt
        {
            get { return Fields.InvoiceNoLchgsVariaAmt[this]; }
            set { Fields.InvoiceNoLchgsVariaAmt[this] = value; }
        }

        [DisplayName("Invoice No Dps Applied"), Expression("jInvoiceNo.[DPS_APPLIED]")]
        public Decimal? InvoiceNoDpsApplied
        {
            get { return Fields.InvoiceNoDpsApplied[this]; }
            set { Fields.InvoiceNoDpsApplied[this] = value; }
        }

        [DisplayName("Invoice No Loc Dps Applied"), Expression("jInvoiceNo.[LOC_DPS_APPLIED]")]
        public Decimal? InvoiceNoLocDpsApplied
        {
            get { return Fields.InvoiceNoLocDpsApplied[this]; }
            set { Fields.InvoiceNoLocDpsApplied[this] = value; }
        }

        [DisplayName("Invoice No Ship Sltax Type"), Expression("jInvoiceNo.[SHIP_SLTAX_TYPE]")]
        public String InvoiceNoShipSltaxType
        {
            get { return Fields.InvoiceNoShipSltaxType[this]; }
            set { Fields.InvoiceNoShipSltaxType[this] = value; }
        }

        [DisplayName("Invoice No Ship Gsltax Pcent"), Expression("jInvoiceNo.[SHIP_GSLTAX_PCENT]")]
        public Decimal? InvoiceNoShipGsltaxPcent
        {
            get { return Fields.InvoiceNoShipGsltaxPcent[this]; }
            set { Fields.InvoiceNoShipGsltaxPcent[this] = value; }
        }

        [DisplayName("Invoice No Ship Count"), Expression("jInvoiceNo.[SHIP_COUNT]")]
        public Decimal? InvoiceNoShipCount
        {
            get { return Fields.InvoiceNoShipCount[this]; }
            set { Fields.InvoiceNoShipCount[this] = value; }
        }

        [DisplayName("Invoice No Source Type"), Expression("jInvoiceNo.[SOURCE_TYPE]")]
        public String InvoiceNoSourceType
        {
            get { return Fields.InvoiceNoSourceType[this]; }
            set { Fields.InvoiceNoSourceType[this] = value; }
        }

        [DisplayName("Invoice No Last Chgs No"), Expression("jInvoiceNo.[LAST_CHGS_NO]")]
        public Decimal? InvoiceNoLastChgsNo
        {
            get { return Fields.InvoiceNoLastChgsNo[this]; }
            set { Fields.InvoiceNoLastChgsNo[this] = value; }
        }

        [DisplayName("Invoice No Doc Type"), Expression("jInvoiceNo.[DOC_TYPE]")]
        public String InvoiceNoDocType
        {
            get { return Fields.InvoiceNoDocType[this]; }
            set { Fields.InvoiceNoDocType[this] = value; }
        }

        [DisplayName("Invoice No Doc Id"), Expression("jInvoiceNo.[DOC_ID]")]
        public String InvoiceNoDocId
        {
            get { return Fields.InvoiceNoDocId[this]; }
            set { Fields.InvoiceNoDocId[this] = value; }
        }

        [DisplayName("Invoice No Anlys9"), Expression("jInvoiceNo.[ANLYS9]")]
        public String InvoiceNoAnlys9
        {
            get { return Fields.InvoiceNoAnlys9[this]; }
            set { Fields.InvoiceNoAnlys9[this] = value; }
        }

        [DisplayName("Invoice No Anlys10"), Expression("jInvoiceNo.[ANLYS10]")]
        public String InvoiceNoAnlys10
        {
            get { return Fields.InvoiceNoAnlys10[this]; }
            set { Fields.InvoiceNoAnlys10[this] = value; }
        }

        [DisplayName("Invoice No Anlys11"), Expression("jInvoiceNo.[ANLYS11]")]
        public String InvoiceNoAnlys11
        {
            get { return Fields.InvoiceNoAnlys11[this]; }
            set { Fields.InvoiceNoAnlys11[this] = value; }
        }

        [DisplayName("Invoice No Anlys12"), Expression("jInvoiceNo.[ANLYS12]")]
        public String InvoiceNoAnlys12
        {
            get { return Fields.InvoiceNoAnlys12[this]; }
            set { Fields.InvoiceNoAnlys12[this] = value; }
        }

        [DisplayName("Invoice No Anlys13"), Expression("jInvoiceNo.[ANLYS13]")]
        public String InvoiceNoAnlys13
        {
            get { return Fields.InvoiceNoAnlys13[this]; }
            set { Fields.InvoiceNoAnlys13[this] = value; }
        }

        [DisplayName("Invoice No Anlys14"), Expression("jInvoiceNo.[ANLYS14]")]
        public String InvoiceNoAnlys14
        {
            get { return Fields.InvoiceNoAnlys14[this]; }
            set { Fields.InvoiceNoAnlys14[this] = value; }
        }

        [DisplayName("Invoice No Break Debit Note"), Expression("jInvoiceNo.[BREAK_DEBIT_NOTE]")]
        public Boolean? InvoiceNoBreakDebitNote
        {
            get { return Fields.InvoiceNoBreakDebitNote[this]; }
            set { Fields.InvoiceNoBreakDebitNote[this] = value; }
        }

        [DisplayName("Invoice No Freezed"), Expression("jInvoiceNo.[FREEZED]")]
        public Boolean? InvoiceNoFreezed
        {
            get { return Fields.InvoiceNoFreezed[this]; }
            set { Fields.InvoiceNoFreezed[this] = value; }
        }

        [DisplayName("Invoice No Related Debit Note"), Expression("jInvoiceNo.[RELATED_DEBIT_NOTE]")]
        public String InvoiceNoRelatedDebitNote
        {
            get { return Fields.InvoiceNoRelatedDebitNote[this]; }
            set { Fields.InvoiceNoRelatedDebitNote[this] = value; }
        }

        [DisplayName("Invoice No Cloned"), Expression("jInvoiceNo.[CLONED]")]
        public Boolean? InvoiceNoCloned
        {
            get { return Fields.InvoiceNoCloned[this]; }
            set { Fields.InvoiceNoCloned[this] = value; }
        }

        [DisplayName("Invoice No Cloned Company Code"), Expression("jInvoiceNo.[CLONED_COMPANY_CODE]")]
        public String InvoiceNoClonedCompanyCode
        {
            get { return Fields.InvoiceNoClonedCompanyCode[this]; }
            set { Fields.InvoiceNoClonedCompanyCode[this] = value; }
        }

        [DisplayName("Invoice No Use Sample Acct"), Expression("jInvoiceNo.[USE_SAMPLE_ACCT]")]
        public Boolean? InvoiceNoUseSampleAcct
        {
            get { return Fields.InvoiceNoUseSampleAcct[this]; }
            set { Fields.InvoiceNoUseSampleAcct[this] = value; }
        }

        [DisplayName("Invoice No Reference Date"), Expression("jInvoiceNo.[REFERENCE_DATE]")]
        public DateTime? InvoiceNoReferenceDate
        {
            get { return Fields.InvoiceNoReferenceDate[this]; }
            set { Fields.InvoiceNoReferenceDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ReceiptNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsReceivablePaymentDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ReceiptNo;
            public StringField InvoiceNo;
            public DateTimeField InvoiceDate;
            public DateTimeField DiscountDate;
            public DateTimeField DueDate;
            public DecimalField DiscPercent;
            public StringField Ccy;
            public DecimalField InvoExchRate;
            public DecimalField PayExchRate;
            public DecimalField BalAmt;
            public DecimalField BalAmtInvo;
            public DecimalField DiscAmt;
            public DecimalField DiscAmtInvo;
            public DecimalField DueAmt;
            public DecimalField DueAmtInvo;
            public DecimalField DueAmtLocal;
            public DecimalField AppliedAmt;
            public DecimalField AppliedAmtLoc;
            public DecimalField SettledAmt;
            public DecimalField ForexGainAmt;
            public DecimalField EndAmt;
            public DecimalField EndAmtLocal;
            public StringField Posted;
            public DecimalField LogNo;
            public DecimalField LastLogNo;
            public DateTimeField ReceiptDate;
            public StringField Settle;
            public DecimalField AppliedAmtInv;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public DecimalField InvRoundDiff;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;

            public DecimalField ReceiptNoRecnum;
            public StringField ReceiptNoDeposit;
            public StringField ReceiptNoPosted;
            public StringField ReceiptNoCustomerNo;
            public StringField ReceiptNoCustomerName;
            public StringField ReceiptNoOrderNo;
            public DateTimeField ReceiptNoReceiptDate;
            public StringField ReceiptNoPeriod;
            public DecimalField ReceiptNoFiscalYear;
            public DecimalField ReceiptNoPeriodNo;
            public StringField ReceiptNoFundCode;
            public StringField ReceiptNoReference;
            public StringField ReceiptNoCcy;
            public DecimalField ReceiptNoExchRate;
            public StringField ReceiptNoSameCurrency;
            public DecimalField ReceiptNoPaidAmt;
            public DecimalField ReceiptNoPaidAmtLocal;
            public DecimalField ReceiptNoBalAmt;
            public DecimalField ReceiptNoDiscAmt;
            public DecimalField ReceiptNoDueAmt;
            public DecimalField ReceiptNoDueAmtLocal;
            public DecimalField ReceiptNoAppliedAmt;
            public DecimalField ReceiptNoAppliedAmtLoc;
            public DecimalField ReceiptNoSettledAmt;
            public DecimalField ReceiptNoForexGainAmt;
            public DecimalField ReceiptNoEndAmt;
            public DecimalField ReceiptNoEndAmtLocal;
            public DecimalField ReceiptNoUnusedAmt;
            public DecimalField ReceiptNoUnusedAmtLoc;
            public DecimalField ReceiptNoAppliedLocCpd;
            public DecimalField ReceiptNoRoundDiff;
            public DateTimeField ReceiptNoCreatedDate;
            public StringField ReceiptNoCreatedBy;
            public DateTimeField ReceiptNoRevisedDate;
            public StringField ReceiptNoRevisedBy;
            public DateTimeField ReceiptNoPostedDate;
            public StringField ReceiptNoPostedBy;
            public StringField ReceiptNoAcctCustomer;
            public StringField ReceiptNoAcctCash;
            public StringField ReceiptNoAcctForexDiff;
            public StringField ReceiptNoAcctTermDisc;
            public StringField ReceiptNoAcctRoundDiff;
            public StringField ReceiptNoBatchSelect;
            public StringField ReceiptNoGlLink;
            public StringField ReceiptNoGlLinkType;
            public StringField ReceiptNoGlLinkNo;
            public StringField ReceiptNoFixedCcy;
            public StringField ReceiptNoDefaultCcy;
            public StringField ReceiptNoOwnerBranch;
            public StringField ReceiptNoSourceBranch;
            public StringField ReceiptNoCanEdit;
            public DecimalField ReceiptNoDiscAmtInvo;
            public DecimalField ReceiptNoTotalDebit;
            public DecimalField ReceiptNoTotalCredit;
            public DecimalField ReceiptNoLastAdjCount;
            public StringField ReceiptNoCcyInv;
            public DecimalField ReceiptNoExchRateInv;
            public DecimalField ReceiptNoAppliedAmtInv;
            public DecimalField ReceiptNoBankAmt;
            public StringField ReceiptNoAnlys1;
            public StringField ReceiptNoAnlys2;
            public StringField ReceiptNoAnlys7;
            public StringField ReceiptNoAnlys8;
            public StringField ReceiptNoToOpen;
            public StringField ReceiptNoToRound;
            public DecimalField ReceiptNoGbcustInvoAmtDiff;
            public DecimalField ReceiptNoGbcustOpenAmtDiff;
            public DecimalField ReceiptNoArledgTotalDebit;
            public DecimalField ReceiptNoArledgTotalCredit;
            public StringField ReceiptNoAllowCancel;
            public StringField ReceiptNoPayer;
            public DecimalField ReceiptNoChargeAmt;
            public DecimalField ReceiptNoChargeAmtLocal;
            public StringField ReceiptNoAnlys9;
            public StringField ReceiptNoAnlys10;
            public StringField ReceiptNoAnlys11;
            public StringField ReceiptNoAnlys12;
            public StringField ReceiptNoAnlys13;
            public StringField ReceiptNoAnlys14;
            public StringField ReceiptNoAcctDeposit;
            public DecimalField ReceiptNoBalAmtLocal;

            public DecimalField InvoiceNoRecnum;
            public StringField InvoiceNoDirectEntry;
            public StringField InvoiceNoPosted;
            public StringField InvoiceNoClosed;
            public StringField InvoiceNoReturned;
            public StringField InvoiceNoDebitNote;
            public StringField InvoiceNoCustomerNo;
            public StringField InvoiceNoCustomerName;
            public StringField InvoiceNoAddress;
            public StringField InvoiceNoAddress2;
            public StringField InvoiceNoAddress3;
            public StringField InvoiceNoAddress4;
            public StringField InvoiceNoAttention;
            public DateTimeField InvoiceNoInvoiceDate;
            public StringField InvoiceNoPeriod;
            public DecimalField InvoiceNoFiscalYear;
            public DecimalField InvoiceNoPeriodNo;
            public StringField InvoiceNoSalesman;
            public StringField InvoiceNoCcy;
            public DecimalField InvoiceNoExchRate;
            public StringField InvoiceNoPayTerms;
            public DecimalField InvoiceNoDiscDays;
            public DecimalField InvoiceNoDiscPcent;
            public DecimalField InvoiceNoDueDays;
            public DateTimeField InvoiceNoDiscountDate;
            public DateTimeField InvoiceNoDueDate;
            public DateTimeField InvoiceNoExpectedDate;
            public StringField InvoiceNoAnlys1;
            public StringField InvoiceNoAnlys2;
            public DecimalField InvoiceNoTotPriceAmt;
            public DecimalField InvoiceNoLocPriceAmt;
            public DecimalField InvoiceNoTotPtaxAmt;
            public DecimalField InvoiceNoLocPtaxAmt;
            public DecimalField InvoiceNoTotExtPrice;
            public DecimalField InvoiceNoLocExtPrice;
            public DecimalField InvoiceNoTotLdiscAmt;
            public DecimalField InvoiceNoLocLdiscAmt;
            public DecimalField InvoiceNoTotAtaxAmt;
            public DecimalField InvoiceNoLocAtaxAmt;
            public DecimalField InvoiceNoTotItemAmt;
            public DecimalField InvoiceNoLocItemAmt;
            public DecimalField InvoiceNoTdiscPcent;
            public DecimalField InvoiceNoTdiscAmt;
            public DecimalField InvoiceNoLocalTdiscAmt;
            public DecimalField InvoiceNoChgsAmt;
            public DecimalField InvoiceNoLocChgsAmt;
            public DecimalField InvoiceNoGtaxAmt;
            public DecimalField InvoiceNoLocalGtaxAmt;
            public DecimalField InvoiceNoNetAmt;
            public DecimalField InvoiceNoLocalNetAmt;
            public DecimalField InvoiceNoTdiscAmtCpd;
            public DecimalField InvoiceNoLastLineNo;
            public DateTimeField InvoiceNoCreatedDate;
            public StringField InvoiceNoCreatedBy;
            public DateTimeField InvoiceNoRevisedDate;
            public StringField InvoiceNoRevisedBy;
            public DateTimeField InvoiceNoPostedDate;
            public StringField InvoiceNoPostedBy;
            public DecimalField InvoiceNoLastLogNo;
            public DecimalField InvoiceNoSettledAmt;
            public DecimalField InvoiceNoLsettledAmt;
            public DecimalField InvoiceNoTermDiscAmt;
            public DecimalField InvoiceNoLtermDiscAmt;
            public DecimalField InvoiceNoReturnAmt;
            public DecimalField InvoiceNoLreturnAmt;
            public DecimalField InvoiceNoBalAmt;
            public DecimalField InvoiceNoBalAmtLocal;
            public DecimalField InvoiceNoOverAllocAmt;
            public DecimalField InvoiceNoLoverAllocAmt;
            public StringField InvoiceNoAcctCustomer;
            public StringField InvoiceNoAcctTdisc;
            public StringField InvoiceNoAcctGtax;
            public StringField InvoiceNoLockType;
            public StringField InvoiceNoLockRefNo;
            public StringField InvoiceNoBatchSelect;
            public StringField InvoiceNoGlLink;
            public StringField InvoiceNoGlLinkType;
            public StringField InvoiceNoGlLinkNo;
            public StringField InvoiceNoOwnerBranch;
            public StringField InvoiceNoSourceBranch;
            public StringField InvoiceNoCheckCrlimit;
            public DecimalField InvoiceNoCheckCrbal;
            public StringField InvoiceNoComments1;
            public StringField InvoiceNoComments2;
            public StringField InvoiceNoComments3;
            public StringField InvoiceNoComments4;
            public DecimalField InvoiceNoLastTextNo;
            public StringField InvoiceNoShipTo;
            public StringField InvoiceNoTelNo;
            public StringField InvoiceNoFaxNo;
            public StringField InvoiceNoSltaxType;
            public DecimalField InvoiceNoGsltaxPcent;
            public DecimalField InvoiceNoTotGsltaxAmt;
            public DecimalField InvoiceNoTotLsltaxAmt;
            public DecimalField InvoiceNoLocGsltaxAmt;
            public DecimalField InvoiceNoLocLsltaxAmt;
            public StringField InvoiceNoAcctSltax;
            public StringField InvoiceNoCustomerPo;
            public StringField InvoiceNoAiLink;
            public StringField InvoiceNoAiLinkType;
            public StringField InvoiceNoAiLinkNo;
            public StringField InvoiceNoAnlys7;
            public StringField InvoiceNoAnlys8;
            public DecimalField InvoiceNoNetTradeAmt;
            public DecimalField InvoiceNoNetOrdrAmt;
            public DecimalField InvoiceNoShipAmt;
            public DecimalField InvoiceNoLshipAmt;
            public DecimalField InvoiceNoVariaAmt;
            public DecimalField InvoiceNoLvariaAmt;
            public DecimalField InvoiceNoItemVariaAmt;
            public DecimalField InvoiceNoLitemVariaAmt;
            public DecimalField InvoiceNoChgsVariaAmt;
            public DecimalField InvoiceNoLchgsVariaAmt;
            public DecimalField InvoiceNoDpsApplied;
            public DecimalField InvoiceNoLocDpsApplied;
            public StringField InvoiceNoShipSltaxType;
            public DecimalField InvoiceNoShipGsltaxPcent;
            public DecimalField InvoiceNoShipCount;
            public StringField InvoiceNoSourceType;
            public DecimalField InvoiceNoLastChgsNo;
            public StringField InvoiceNoDocType;
            public StringField InvoiceNoDocId;
            public StringField InvoiceNoAnlys9;
            public StringField InvoiceNoAnlys10;
            public StringField InvoiceNoAnlys11;
            public StringField InvoiceNoAnlys12;
            public StringField InvoiceNoAnlys13;
            public StringField InvoiceNoAnlys14;
            public BooleanField InvoiceNoBreakDebitNote;
            public BooleanField InvoiceNoFreezed;
            public StringField InvoiceNoRelatedDebitNote;
            public BooleanField InvoiceNoCloned;
            public StringField InvoiceNoClonedCompanyCode;
            public BooleanField InvoiceNoUseSampleAcct;
            public DateTimeField InvoiceNoReferenceDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsReceivablePaymentDetail";
            }
        }
    }
}
