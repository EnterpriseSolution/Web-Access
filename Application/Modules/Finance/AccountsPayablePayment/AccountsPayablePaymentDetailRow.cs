#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayablePaymentDetailRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[APPAYD]")]
    [DisplayName("Accounts Payable Payment Detail"), InstanceName("Accounts Payable Payment Detail"), TwoLevelCached]   
    public sealed class AccountsPayablePaymentDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[APPAYH]", "REF_NO"), LeftJoin("jRefNo"), QuickSearch, TextualField("RefNoDeposit")]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No"), Column("INVO_CTRL_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[APINVH]", "CONTROL_NO"), LeftJoin("jInvoCtrlNo"), TextualField("InvoCtrlNoMiscellaneous")]
        public String InvoCtrlNo
        {
            get { return Fields.InvoCtrlNo[this]; }
            set { Fields.InvoCtrlNo[this] = value; }
        }

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16)]
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

        [DisplayName("Settle"), Column("SETTLE"), Size(1)]
        public String Settle
        {
            get { return Fields.Settle[this]; }
            set { Fields.Settle[this] = value; }
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

        [DisplayName("Log No"), Column("LOG_NO"), Size(8), NotNull]
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

        [DisplayName("Paid Date"), Column("PAID_DATE")]
        public DateTime? PaidDate
        {
            get { return Fields.PaidDate[this]; }
            set { Fields.PaidDate[this] = value; }
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

        [DisplayName("Ref No Recnum"), Expression("jRefNo.[RECNUM]")]
        public Decimal? RefNoRecnum
        {
            get { return Fields.RefNoRecnum[this]; }
            set { Fields.RefNoRecnum[this] = value; }
        }

        [DisplayName("Ref No Deposit"), Expression("jRefNo.[DEPOSIT]")]
        public String RefNoDeposit
        {
            get { return Fields.RefNoDeposit[this]; }
            set { Fields.RefNoDeposit[this] = value; }
        }

        [DisplayName("Ref No Posted"), Expression("jRefNo.[POSTED]")]
        public String RefNoPosted
        {
            get { return Fields.RefNoPosted[this]; }
            set { Fields.RefNoPosted[this] = value; }
        }

        [DisplayName("Ref No Vendor No"), Expression("jRefNo.[VENDOR_NO]")]
        public String RefNoVendorNo
        {
            get { return Fields.RefNoVendorNo[this]; }
            set { Fields.RefNoVendorNo[this] = value; }
        }

        [DisplayName("Ref No Vendor Name"), Expression("jRefNo.[VENDOR_NAME]")]
        public String RefNoVendorName
        {
            get { return Fields.RefNoVendorName[this]; }
            set { Fields.RefNoVendorName[this] = value; }
        }

        [DisplayName("Ref No Order No"), Expression("jRefNo.[ORDER_NO]")]
        public String RefNoOrderNo
        {
            get { return Fields.RefNoOrderNo[this]; }
            set { Fields.RefNoOrderNo[this] = value; }
        }

        [DisplayName("Ref No Paid Date"), Expression("jRefNo.[PAID_DATE]")]
        public DateTime? RefNoPaidDate
        {
            get { return Fields.RefNoPaidDate[this]; }
            set { Fields.RefNoPaidDate[this] = value; }
        }

        [DisplayName("Ref No Period"), Expression("jRefNo.[PERIOD]")]
        public String RefNoPeriod
        {
            get { return Fields.RefNoPeriod[this]; }
            set { Fields.RefNoPeriod[this] = value; }
        }

        [DisplayName("Ref No Fiscal Year"), Expression("jRefNo.[FISCAL_YEAR]")]
        public Decimal? RefNoFiscalYear
        {
            get { return Fields.RefNoFiscalYear[this]; }
            set { Fields.RefNoFiscalYear[this] = value; }
        }

        [DisplayName("Ref No Period No"), Expression("jRefNo.[PERIOD_NO]")]
        public Decimal? RefNoPeriodNo
        {
            get { return Fields.RefNoPeriodNo[this]; }
            set { Fields.RefNoPeriodNo[this] = value; }
        }

        [DisplayName("Ref No Fund Code"), Expression("jRefNo.[FUND_CODE]")]
        public String RefNoFundCode
        {
            get { return Fields.RefNoFundCode[this]; }
            set { Fields.RefNoFundCode[this] = value; }
        }

        [DisplayName("Ref No Payee"), Expression("jRefNo.[PAYEE]")]
        public String RefNoPayee
        {
            get { return Fields.RefNoPayee[this]; }
            set { Fields.RefNoPayee[this] = value; }
        }

        [DisplayName("Ref No Cheque No"), Expression("jRefNo.[CHEQUE_NO]")]
        public String RefNoChequeNo
        {
            get { return Fields.RefNoChequeNo[this]; }
            set { Fields.RefNoChequeNo[this] = value; }
        }

        [DisplayName("Ref No Ccy"), Expression("jRefNo.[CCY]")]
        public String RefNoCcy
        {
            get { return Fields.RefNoCcy[this]; }
            set { Fields.RefNoCcy[this] = value; }
        }

        [DisplayName("Ref No Exch Rate"), Expression("jRefNo.[EXCH_RATE]")]
        public Decimal? RefNoExchRate
        {
            get { return Fields.RefNoExchRate[this]; }
            set { Fields.RefNoExchRate[this] = value; }
        }

        [DisplayName("Ref No Same Currency"), Expression("jRefNo.[SAME_CURRENCY]")]
        public String RefNoSameCurrency
        {
            get { return Fields.RefNoSameCurrency[this]; }
            set { Fields.RefNoSameCurrency[this] = value; }
        }

        [DisplayName("Ref No Paid Amt"), Expression("jRefNo.[PAID_AMT]")]
        public Decimal? RefNoPaidAmt
        {
            get { return Fields.RefNoPaidAmt[this]; }
            set { Fields.RefNoPaidAmt[this] = value; }
        }

        [DisplayName("Ref No Paid Amt Local"), Expression("jRefNo.[PAID_AMT_LOCAL]")]
        public Decimal? RefNoPaidAmtLocal
        {
            get { return Fields.RefNoPaidAmtLocal[this]; }
            set { Fields.RefNoPaidAmtLocal[this] = value; }
        }

        [DisplayName("Ref No Bal Amt"), Expression("jRefNo.[BAL_AMT]")]
        public Decimal? RefNoBalAmt
        {
            get { return Fields.RefNoBalAmt[this]; }
            set { Fields.RefNoBalAmt[this] = value; }
        }

        [DisplayName("Ref No Disc Amt"), Expression("jRefNo.[DISC_AMT]")]
        public Decimal? RefNoDiscAmt
        {
            get { return Fields.RefNoDiscAmt[this]; }
            set { Fields.RefNoDiscAmt[this] = value; }
        }

        [DisplayName("Ref No Due Amt"), Expression("jRefNo.[DUE_AMT]")]
        public Decimal? RefNoDueAmt
        {
            get { return Fields.RefNoDueAmt[this]; }
            set { Fields.RefNoDueAmt[this] = value; }
        }

        [DisplayName("Ref No Due Amt Local"), Expression("jRefNo.[DUE_AMT_LOCAL]")]
        public Decimal? RefNoDueAmtLocal
        {
            get { return Fields.RefNoDueAmtLocal[this]; }
            set { Fields.RefNoDueAmtLocal[this] = value; }
        }

        [DisplayName("Ref No Applied Amt"), Expression("jRefNo.[APPLIED_AMT]")]
        public Decimal? RefNoAppliedAmt
        {
            get { return Fields.RefNoAppliedAmt[this]; }
            set { Fields.RefNoAppliedAmt[this] = value; }
        }

        [DisplayName("Ref No Applied Amt Loc"), Expression("jRefNo.[APPLIED_AMT_LOC]")]
        public Decimal? RefNoAppliedAmtLoc
        {
            get { return Fields.RefNoAppliedAmtLoc[this]; }
            set { Fields.RefNoAppliedAmtLoc[this] = value; }
        }

        [DisplayName("Ref No Settled Amt"), Expression("jRefNo.[SETTLED_AMT]")]
        public Decimal? RefNoSettledAmt
        {
            get { return Fields.RefNoSettledAmt[this]; }
            set { Fields.RefNoSettledAmt[this] = value; }
        }

        [DisplayName("Ref No Forex Gain Amt"), Expression("jRefNo.[FOREX_GAIN_AMT]")]
        public Decimal? RefNoForexGainAmt
        {
            get { return Fields.RefNoForexGainAmt[this]; }
            set { Fields.RefNoForexGainAmt[this] = value; }
        }

        [DisplayName("Ref No End Amt"), Expression("jRefNo.[END_AMT]")]
        public Decimal? RefNoEndAmt
        {
            get { return Fields.RefNoEndAmt[this]; }
            set { Fields.RefNoEndAmt[this] = value; }
        }

        [DisplayName("Ref No End Amt Local"), Expression("jRefNo.[END_AMT_LOCAL]")]
        public Decimal? RefNoEndAmtLocal
        {
            get { return Fields.RefNoEndAmtLocal[this]; }
            set { Fields.RefNoEndAmtLocal[this] = value; }
        }

        [DisplayName("Ref No Unused Amt"), Expression("jRefNo.[UNUSED_AMT]")]
        public Decimal? RefNoUnusedAmt
        {
            get { return Fields.RefNoUnusedAmt[this]; }
            set { Fields.RefNoUnusedAmt[this] = value; }
        }

        [DisplayName("Ref No Unused Amt Loc"), Expression("jRefNo.[UNUSED_AMT_LOC]")]
        public Decimal? RefNoUnusedAmtLoc
        {
            get { return Fields.RefNoUnusedAmtLoc[this]; }
            set { Fields.RefNoUnusedAmtLoc[this] = value; }
        }

        [DisplayName("Ref No Applied Loc Cpd"), Expression("jRefNo.[APPLIED_LOC_CPD]")]
        public Decimal? RefNoAppliedLocCpd
        {
            get { return Fields.RefNoAppliedLocCpd[this]; }
            set { Fields.RefNoAppliedLocCpd[this] = value; }
        }

        [DisplayName("Ref No Round Diff"), Expression("jRefNo.[ROUND_DIFF]")]
        public Decimal? RefNoRoundDiff
        {
            get { return Fields.RefNoRoundDiff[this]; }
            set { Fields.RefNoRoundDiff[this] = value; }
        }

        [DisplayName("Ref No Created Date"), Expression("jRefNo.[CREATED_DATE]")]
        public DateTime? RefNoCreatedDate
        {
            get { return Fields.RefNoCreatedDate[this]; }
            set { Fields.RefNoCreatedDate[this] = value; }
        }

        [DisplayName("Ref No Created By"), Expression("jRefNo.[CREATED_BY]")]
        public String RefNoCreatedBy
        {
            get { return Fields.RefNoCreatedBy[this]; }
            set { Fields.RefNoCreatedBy[this] = value; }
        }

        [DisplayName("Ref No Revised Date"), Expression("jRefNo.[REVISED_DATE]")]
        public DateTime? RefNoRevisedDate
        {
            get { return Fields.RefNoRevisedDate[this]; }
            set { Fields.RefNoRevisedDate[this] = value; }
        }

        [DisplayName("Ref No Revised By"), Expression("jRefNo.[REVISED_BY]")]
        public String RefNoRevisedBy
        {
            get { return Fields.RefNoRevisedBy[this]; }
            set { Fields.RefNoRevisedBy[this] = value; }
        }

        [DisplayName("Ref No Posted Date"), Expression("jRefNo.[POSTED_DATE]")]
        public DateTime? RefNoPostedDate
        {
            get { return Fields.RefNoPostedDate[this]; }
            set { Fields.RefNoPostedDate[this] = value; }
        }

        [DisplayName("Ref No Posted By"), Expression("jRefNo.[POSTED_BY]")]
        public String RefNoPostedBy
        {
            get { return Fields.RefNoPostedBy[this]; }
            set { Fields.RefNoPostedBy[this] = value; }
        }

        [DisplayName("Ref No Acct Vendor"), Expression("jRefNo.[ACCT_VENDOR]")]
        public String RefNoAcctVendor
        {
            get { return Fields.RefNoAcctVendor[this]; }
            set { Fields.RefNoAcctVendor[this] = value; }
        }

        [DisplayName("Ref No Acct Cash"), Expression("jRefNo.[ACCT_CASH]")]
        public String RefNoAcctCash
        {
            get { return Fields.RefNoAcctCash[this]; }
            set { Fields.RefNoAcctCash[this] = value; }
        }

        [DisplayName("Ref No Acct Forex Diff"), Expression("jRefNo.[ACCT_FOREX_DIFF]")]
        public String RefNoAcctForexDiff
        {
            get { return Fields.RefNoAcctForexDiff[this]; }
            set { Fields.RefNoAcctForexDiff[this] = value; }
        }

        [DisplayName("Ref No Acct Term Disc"), Expression("jRefNo.[ACCT_TERM_DISC]")]
        public String RefNoAcctTermDisc
        {
            get { return Fields.RefNoAcctTermDisc[this]; }
            set { Fields.RefNoAcctTermDisc[this] = value; }
        }

        [DisplayName("Ref No Acct Round Diff"), Expression("jRefNo.[ACCT_ROUND_DIFF]")]
        public String RefNoAcctRoundDiff
        {
            get { return Fields.RefNoAcctRoundDiff[this]; }
            set { Fields.RefNoAcctRoundDiff[this] = value; }
        }

        [DisplayName("Ref No Batch Select"), Expression("jRefNo.[BATCH_SELECT]")]
        public String RefNoBatchSelect
        {
            get { return Fields.RefNoBatchSelect[this]; }
            set { Fields.RefNoBatchSelect[this] = value; }
        }

        [DisplayName("Ref No Gl Link"), Expression("jRefNo.[GL_LINK]")]
        public String RefNoGlLink
        {
            get { return Fields.RefNoGlLink[this]; }
            set { Fields.RefNoGlLink[this] = value; }
        }

        [DisplayName("Ref No Gl Link Type"), Expression("jRefNo.[GL_LINK_TYPE]")]
        public String RefNoGlLinkType
        {
            get { return Fields.RefNoGlLinkType[this]; }
            set { Fields.RefNoGlLinkType[this] = value; }
        }

        [DisplayName("Ref No Gl Link No"), Expression("jRefNo.[GL_LINK_NO]")]
        public String RefNoGlLinkNo
        {
            get { return Fields.RefNoGlLinkNo[this]; }
            set { Fields.RefNoGlLinkNo[this] = value; }
        }

        [DisplayName("Ref No Fixed Ccy"), Expression("jRefNo.[FIXED_CCY]")]
        public String RefNoFixedCcy
        {
            get { return Fields.RefNoFixedCcy[this]; }
            set { Fields.RefNoFixedCcy[this] = value; }
        }

        [DisplayName("Ref No Default Ccy"), Expression("jRefNo.[DEFAULT_CCY]")]
        public String RefNoDefaultCcy
        {
            get { return Fields.RefNoDefaultCcy[this]; }
            set { Fields.RefNoDefaultCcy[this] = value; }
        }

        [DisplayName("Ref No Paid Local Cpd"), Expression("jRefNo.[PAID_LOCAL_CPD]")]
        public Decimal? RefNoPaidLocalCpd
        {
            get { return Fields.RefNoPaidLocalCpd[this]; }
            set { Fields.RefNoPaidLocalCpd[this] = value; }
        }

        [DisplayName("Ref No Owner Branch"), Expression("jRefNo.[OWNER_BRANCH]")]
        public String RefNoOwnerBranch
        {
            get { return Fields.RefNoOwnerBranch[this]; }
            set { Fields.RefNoOwnerBranch[this] = value; }
        }

        [DisplayName("Ref No Source Branch"), Expression("jRefNo.[SOURCE_BRANCH]")]
        public String RefNoSourceBranch
        {
            get { return Fields.RefNoSourceBranch[this]; }
            set { Fields.RefNoSourceBranch[this] = value; }
        }

        [DisplayName("Ref No Can Edit"), Expression("jRefNo.[CAN_EDIT]")]
        public String RefNoCanEdit
        {
            get { return Fields.RefNoCanEdit[this]; }
            set { Fields.RefNoCanEdit[this] = value; }
        }

        [DisplayName("Ref No Disc Amt Invo"), Expression("jRefNo.[DISC_AMT_INVO]")]
        public Decimal? RefNoDiscAmtInvo
        {
            get { return Fields.RefNoDiscAmtInvo[this]; }
            set { Fields.RefNoDiscAmtInvo[this] = value; }
        }

        [DisplayName("Ref No Total Debit"), Expression("jRefNo.[TOTAL_DEBIT]")]
        public Decimal? RefNoTotalDebit
        {
            get { return Fields.RefNoTotalDebit[this]; }
            set { Fields.RefNoTotalDebit[this] = value; }
        }

        [DisplayName("Ref No Total Credit"), Expression("jRefNo.[TOTAL_CREDIT]")]
        public Decimal? RefNoTotalCredit
        {
            get { return Fields.RefNoTotalCredit[this]; }
            set { Fields.RefNoTotalCredit[this] = value; }
        }

        [DisplayName("Ref No Last Adj Count"), Expression("jRefNo.[LAST_ADJ_COUNT]")]
        public Decimal? RefNoLastAdjCount
        {
            get { return Fields.RefNoLastAdjCount[this]; }
            set { Fields.RefNoLastAdjCount[this] = value; }
        }

        [DisplayName("Ref No Ccy Inv"), Expression("jRefNo.[CCY_INV]")]
        public String RefNoCcyInv
        {
            get { return Fields.RefNoCcyInv[this]; }
            set { Fields.RefNoCcyInv[this] = value; }
        }

        [DisplayName("Ref No Exch Rate Inv"), Expression("jRefNo.[EXCH_RATE_INV]")]
        public Decimal? RefNoExchRateInv
        {
            get { return Fields.RefNoExchRateInv[this]; }
            set { Fields.RefNoExchRateInv[this] = value; }
        }

        [DisplayName("Ref No Applied Amt Inv"), Expression("jRefNo.[APPLIED_AMT_INV]")]
        public Decimal? RefNoAppliedAmtInv
        {
            get { return Fields.RefNoAppliedAmtInv[this]; }
            set { Fields.RefNoAppliedAmtInv[this] = value; }
        }

        [DisplayName("Ref No Bank Amt"), Expression("jRefNo.[BANK_AMT]")]
        public Decimal? RefNoBankAmt
        {
            get { return Fields.RefNoBankAmt[this]; }
            set { Fields.RefNoBankAmt[this] = value; }
        }

        [DisplayName("Ref No Anlys1"), Expression("jRefNo.[ANLYS1]")]
        public String RefNoAnlys1
        {
            get { return Fields.RefNoAnlys1[this]; }
            set { Fields.RefNoAnlys1[this] = value; }
        }

        [DisplayName("Ref No Anlys2"), Expression("jRefNo.[ANLYS2]")]
        public String RefNoAnlys2
        {
            get { return Fields.RefNoAnlys2[this]; }
            set { Fields.RefNoAnlys2[this] = value; }
        }

        [DisplayName("Ref No Anlys7"), Expression("jRefNo.[ANLYS7]")]
        public String RefNoAnlys7
        {
            get { return Fields.RefNoAnlys7[this]; }
            set { Fields.RefNoAnlys7[this] = value; }
        }

        [DisplayName("Ref No Anlys8"), Expression("jRefNo.[ANLYS8]")]
        public String RefNoAnlys8
        {
            get { return Fields.RefNoAnlys8[this]; }
            set { Fields.RefNoAnlys8[this] = value; }
        }

        [DisplayName("Ref No Remarks"), Expression("jRefNo.[REMARKS]")]
        public String RefNoRemarks
        {
            get { return Fields.RefNoRemarks[this]; }
            set { Fields.RefNoRemarks[this] = value; }
        }

        [DisplayName("Ref No To Open"), Expression("jRefNo.[TO_OPEN]")]
        public String RefNoToOpen
        {
            get { return Fields.RefNoToOpen[this]; }
            set { Fields.RefNoToOpen[this] = value; }
        }

        [DisplayName("Ref No To Round"), Expression("jRefNo.[TO_ROUND]")]
        public String RefNoToRound
        {
            get { return Fields.RefNoToRound[this]; }
            set { Fields.RefNoToRound[this] = value; }
        }

        [DisplayName("Ref No Gbvend Invo Amt Diff"), Expression("jRefNo.[GBVEND_INVO_AMT_DIFF]")]
        public Decimal? RefNoGbvendInvoAmtDiff
        {
            get { return Fields.RefNoGbvendInvoAmtDiff[this]; }
            set { Fields.RefNoGbvendInvoAmtDiff[this] = value; }
        }

        [DisplayName("Ref No Gbvend Open Amt Diff"), Expression("jRefNo.[GBVEND_OPEN_AMT_DIFF]")]
        public Decimal? RefNoGbvendOpenAmtDiff
        {
            get { return Fields.RefNoGbvendOpenAmtDiff[this]; }
            set { Fields.RefNoGbvendOpenAmtDiff[this] = value; }
        }

        [DisplayName("Ref No Apledg Total Debit"), Expression("jRefNo.[APLEDG_TOTAL_DEBIT]")]
        public Decimal? RefNoApledgTotalDebit
        {
            get { return Fields.RefNoApledgTotalDebit[this]; }
            set { Fields.RefNoApledgTotalDebit[this] = value; }
        }

        [DisplayName("Ref No Apledg Total Credit"), Expression("jRefNo.[APLEDG_TOTAL_CREDIT]")]
        public Decimal? RefNoApledgTotalCredit
        {
            get { return Fields.RefNoApledgTotalCredit[this]; }
            set { Fields.RefNoApledgTotalCredit[this] = value; }
        }

        [DisplayName("Ref No Allow Cancel"), Expression("jRefNo.[ALLOW_CANCEL]")]
        public String RefNoAllowCancel
        {
            get { return Fields.RefNoAllowCancel[this]; }
            set { Fields.RefNoAllowCancel[this] = value; }
        }

        [DisplayName("Ref No Charge Amt"), Expression("jRefNo.[CHARGE_AMT]")]
        public Decimal? RefNoChargeAmt
        {
            get { return Fields.RefNoChargeAmt[this]; }
            set { Fields.RefNoChargeAmt[this] = value; }
        }

        [DisplayName("Ref No Charge Amt Local"), Expression("jRefNo.[CHARGE_AMT_LOCAL]")]
        public Decimal? RefNoChargeAmtLocal
        {
            get { return Fields.RefNoChargeAmtLocal[this]; }
            set { Fields.RefNoChargeAmtLocal[this] = value; }
        }

        [DisplayName("Ref No Anlys9"), Expression("jRefNo.[ANLYS9]")]
        public String RefNoAnlys9
        {
            get { return Fields.RefNoAnlys9[this]; }
            set { Fields.RefNoAnlys9[this] = value; }
        }

        [DisplayName("Ref No Anlys10"), Expression("jRefNo.[ANLYS10]")]
        public String RefNoAnlys10
        {
            get { return Fields.RefNoAnlys10[this]; }
            set { Fields.RefNoAnlys10[this] = value; }
        }

        [DisplayName("Ref No Anlys11"), Expression("jRefNo.[ANLYS11]")]
        public String RefNoAnlys11
        {
            get { return Fields.RefNoAnlys11[this]; }
            set { Fields.RefNoAnlys11[this] = value; }
        }

        [DisplayName("Ref No Anlys12"), Expression("jRefNo.[ANLYS12]")]
        public String RefNoAnlys12
        {
            get { return Fields.RefNoAnlys12[this]; }
            set { Fields.RefNoAnlys12[this] = value; }
        }

        [DisplayName("Ref No Anlys13"), Expression("jRefNo.[ANLYS13]")]
        public String RefNoAnlys13
        {
            get { return Fields.RefNoAnlys13[this]; }
            set { Fields.RefNoAnlys13[this] = value; }
        }

        [DisplayName("Ref No Anlys14"), Expression("jRefNo.[ANLYS14]")]
        public String RefNoAnlys14
        {
            get { return Fields.RefNoAnlys14[this]; }
            set { Fields.RefNoAnlys14[this] = value; }
        }

        [DisplayName("Ref No Acct Deposit"), Expression("jRefNo.[ACCT_DEPOSIT]")]
        public String RefNoAcctDeposit
        {
            get { return Fields.RefNoAcctDeposit[this]; }
            set { Fields.RefNoAcctDeposit[this] = value; }
        }

        [DisplayName("Invo Ctrl No Recnum"), Expression("jInvoCtrlNo.[RECNUM]")]
        public Decimal? InvoCtrlNoRecnum
        {
            get { return Fields.InvoCtrlNoRecnum[this]; }
            set { Fields.InvoCtrlNoRecnum[this] = value; }
        }

        [DisplayName("Invo Ctrl No Miscellaneous"), Expression("jInvoCtrlNo.[MISCELLANEOUS]")]
        public String InvoCtrlNoMiscellaneous
        {
            get { return Fields.InvoCtrlNoMiscellaneous[this]; }
            set { Fields.InvoCtrlNoMiscellaneous[this] = value; }
        }

        [DisplayName("Invo Ctrl No Posted"), Expression("jInvoCtrlNo.[POSTED]")]
        public String InvoCtrlNoPosted
        {
            get { return Fields.InvoCtrlNoPosted[this]; }
            set { Fields.InvoCtrlNoPosted[this] = value; }
        }

        [DisplayName("Invo Ctrl No Closed"), Expression("jInvoCtrlNo.[CLOSED]")]
        public String InvoCtrlNoClosed
        {
            get { return Fields.InvoCtrlNoClosed[this]; }
            set { Fields.InvoCtrlNoClosed[this] = value; }
        }

        [DisplayName("Invo Ctrl No Returned"), Expression("jInvoCtrlNo.[RETURNED]")]
        public String InvoCtrlNoReturned
        {
            get { return Fields.InvoCtrlNoReturned[this]; }
            set { Fields.InvoCtrlNoReturned[this] = value; }
        }

        [DisplayName("Invo Ctrl No Vendor No"), Expression("jInvoCtrlNo.[VENDOR_NO]")]
        public String InvoCtrlNoVendorNo
        {
            get { return Fields.InvoCtrlNoVendorNo[this]; }
            set { Fields.InvoCtrlNoVendorNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Vendor Name"), Expression("jInvoCtrlNo.[VENDOR_NAME]")]
        public String InvoCtrlNoVendorName
        {
            get { return Fields.InvoCtrlNoVendorName[this]; }
            set { Fields.InvoCtrlNoVendorName[this] = value; }
        }

        [DisplayName("Invo Ctrl No Invoice No"), Expression("jInvoCtrlNo.[INVOICE_NO]")]
        public String InvoCtrlNoInvoiceNo
        {
            get { return Fields.InvoCtrlNoInvoiceNo[this]; }
            set { Fields.InvoCtrlNoInvoiceNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Invoice Date"), Expression("jInvoCtrlNo.[INVOICE_DATE]")]
        public DateTime? InvoCtrlNoInvoiceDate
        {
            get { return Fields.InvoCtrlNoInvoiceDate[this]; }
            set { Fields.InvoCtrlNoInvoiceDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Received Date"), Expression("jInvoCtrlNo.[RECEIVED_DATE]")]
        public DateTime? InvoCtrlNoReceivedDate
        {
            get { return Fields.InvoCtrlNoReceivedDate[this]; }
            set { Fields.InvoCtrlNoReceivedDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Period"), Expression("jInvoCtrlNo.[PERIOD]")]
        public String InvoCtrlNoPeriod
        {
            get { return Fields.InvoCtrlNoPeriod[this]; }
            set { Fields.InvoCtrlNoPeriod[this] = value; }
        }

        [DisplayName("Invo Ctrl No Fiscal Year"), Expression("jInvoCtrlNo.[FISCAL_YEAR]")]
        public Decimal? InvoCtrlNoFiscalYear
        {
            get { return Fields.InvoCtrlNoFiscalYear[this]; }
            set { Fields.InvoCtrlNoFiscalYear[this] = value; }
        }

        [DisplayName("Invo Ctrl No Period No"), Expression("jInvoCtrlNo.[PERIOD_NO]")]
        public Decimal? InvoCtrlNoPeriodNo
        {
            get { return Fields.InvoCtrlNoPeriodNo[this]; }
            set { Fields.InvoCtrlNoPeriodNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Pay Terms"), Expression("jInvoCtrlNo.[PAY_TERMS]")]
        public String InvoCtrlNoPayTerms
        {
            get { return Fields.InvoCtrlNoPayTerms[this]; }
            set { Fields.InvoCtrlNoPayTerms[this] = value; }
        }

        [DisplayName("Invo Ctrl No Disc Percent"), Expression("jInvoCtrlNo.[DISC_PERCENT]")]
        public Decimal? InvoCtrlNoDiscPercent
        {
            get { return Fields.InvoCtrlNoDiscPercent[this]; }
            set { Fields.InvoCtrlNoDiscPercent[this] = value; }
        }

        [DisplayName("Invo Ctrl No Disc Days"), Expression("jInvoCtrlNo.[DISC_DAYS]")]
        public Decimal? InvoCtrlNoDiscDays
        {
            get { return Fields.InvoCtrlNoDiscDays[this]; }
            set { Fields.InvoCtrlNoDiscDays[this] = value; }
        }

        [DisplayName("Invo Ctrl No Net Days"), Expression("jInvoCtrlNo.[NET_DAYS]")]
        public Decimal? InvoCtrlNoNetDays
        {
            get { return Fields.InvoCtrlNoNetDays[this]; }
            set { Fields.InvoCtrlNoNetDays[this] = value; }
        }

        [DisplayName("Invo Ctrl No Discount Date"), Expression("jInvoCtrlNo.[DISCOUNT_DATE]")]
        public DateTime? InvoCtrlNoDiscountDate
        {
            get { return Fields.InvoCtrlNoDiscountDate[this]; }
            set { Fields.InvoCtrlNoDiscountDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Due Date"), Expression("jInvoCtrlNo.[DUE_DATE]")]
        public DateTime? InvoCtrlNoDueDate
        {
            get { return Fields.InvoCtrlNoDueDate[this]; }
            set { Fields.InvoCtrlNoDueDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Planned Date"), Expression("jInvoCtrlNo.[PLANNED_DATE]")]
        public DateTime? InvoCtrlNoPlannedDate
        {
            get { return Fields.InvoCtrlNoPlannedDate[this]; }
            set { Fields.InvoCtrlNoPlannedDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Payment Branch"), Expression("jInvoCtrlNo.[PAYMENT_BRANCH]")]
        public String InvoCtrlNoPaymentBranch
        {
            get { return Fields.InvoCtrlNoPaymentBranch[this]; }
            set { Fields.InvoCtrlNoPaymentBranch[this] = value; }
        }

        [DisplayName("Invo Ctrl No Ccy"), Expression("jInvoCtrlNo.[CCY]")]
        public String InvoCtrlNoCcy
        {
            get { return Fields.InvoCtrlNoCcy[this]; }
            set { Fields.InvoCtrlNoCcy[this] = value; }
        }

        [DisplayName("Invo Ctrl No Exch Rate"), Expression("jInvoCtrlNo.[EXCH_RATE]")]
        public Decimal? InvoCtrlNoExchRate
        {
            get { return Fields.InvoCtrlNoExchRate[this]; }
            set { Fields.InvoCtrlNoExchRate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Price Amt"), Expression("jInvoCtrlNo.[TOT_PRICE_AMT]")]
        public Decimal? InvoCtrlNoTotPriceAmt
        {
            get { return Fields.InvoCtrlNoTotPriceAmt[this]; }
            set { Fields.InvoCtrlNoTotPriceAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Ptax Amt"), Expression("jInvoCtrlNo.[TOT_PTAX_AMT]")]
        public Decimal? InvoCtrlNoTotPtaxAmt
        {
            get { return Fields.InvoCtrlNoTotPtaxAmt[this]; }
            set { Fields.InvoCtrlNoTotPtaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Ext Price"), Expression("jInvoCtrlNo.[TOT_EXT_PRICE]")]
        public Decimal? InvoCtrlNoTotExtPrice
        {
            get { return Fields.InvoCtrlNoTotExtPrice[this]; }
            set { Fields.InvoCtrlNoTotExtPrice[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Ldisc Amt"), Expression("jInvoCtrlNo.[TOT_LDISC_AMT]")]
        public Decimal? InvoCtrlNoTotLdiscAmt
        {
            get { return Fields.InvoCtrlNoTotLdiscAmt[this]; }
            set { Fields.InvoCtrlNoTotLdiscAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Atax Amt"), Expression("jInvoCtrlNo.[TOT_ATAX_AMT]")]
        public Decimal? InvoCtrlNoTotAtaxAmt
        {
            get { return Fields.InvoCtrlNoTotAtaxAmt[this]; }
            set { Fields.InvoCtrlNoTotAtaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Item Amt"), Expression("jInvoCtrlNo.[TOT_ITEM_AMT]")]
        public Decimal? InvoCtrlNoTotItemAmt
        {
            get { return Fields.InvoCtrlNoTotItemAmt[this]; }
            set { Fields.InvoCtrlNoTotItemAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Tdisc Amt"), Expression("jInvoCtrlNo.[TOT_TDISC_AMT]")]
        public Decimal? InvoCtrlNoTotTdiscAmt
        {
            get { return Fields.InvoCtrlNoTotTdiscAmt[this]; }
            set { Fields.InvoCtrlNoTotTdiscAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Net Trade Amt"), Expression("jInvoCtrlNo.[NET_TRADE_AMT]")]
        public Decimal? InvoCtrlNoNetTradeAmt
        {
            get { return Fields.InvoCtrlNoNetTradeAmt[this]; }
            set { Fields.InvoCtrlNoNetTradeAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Chgs Amt"), Expression("jInvoCtrlNo.[TOT_CHGS_AMT]")]
        public Decimal? InvoCtrlNoTotChgsAmt
        {
            get { return Fields.InvoCtrlNoTotChgsAmt[this]; }
            set { Fields.InvoCtrlNoTotChgsAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Net Ordr Amt"), Expression("jInvoCtrlNo.[NET_ORDR_AMT]")]
        public Decimal? InvoCtrlNoNetOrdrAmt
        {
            get { return Fields.InvoCtrlNoNetOrdrAmt[this]; }
            set { Fields.InvoCtrlNoNetOrdrAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Gtax Amt"), Expression("jInvoCtrlNo.[TOT_GTAX_AMT]")]
        public Decimal? InvoCtrlNoTotGtaxAmt
        {
            get { return Fields.InvoCtrlNoTotGtaxAmt[this]; }
            set { Fields.InvoCtrlNoTotGtaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Net Invo Amt"), Expression("jInvoCtrlNo.[NET_INVO_AMT]")]
        public Decimal? InvoCtrlNoNetInvoAmt
        {
            get { return Fields.InvoCtrlNoNetInvoAmt[this]; }
            set { Fields.InvoCtrlNoNetInvoAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Dps Applied"), Expression("jInvoCtrlNo.[DPS_APPLIED]")]
        public Decimal? InvoCtrlNoDpsApplied
        {
            get { return Fields.InvoCtrlNoDpsApplied[this]; }
            set { Fields.InvoCtrlNoDpsApplied[this] = value; }
        }

        [DisplayName("Invo Ctrl No Net Bal Amt"), Expression("jInvoCtrlNo.[NET_BAL_AMT]")]
        public Decimal? InvoCtrlNoNetBalAmt
        {
            get { return Fields.InvoCtrlNoNetBalAmt[this]; }
            set { Fields.InvoCtrlNoNetBalAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Price Amt"), Expression("jInvoCtrlNo.[LOC_PRICE_AMT]")]
        public Decimal? InvoCtrlNoLocPriceAmt
        {
            get { return Fields.InvoCtrlNoLocPriceAmt[this]; }
            set { Fields.InvoCtrlNoLocPriceAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Ptax Amt"), Expression("jInvoCtrlNo.[LOC_PTAX_AMT]")]
        public Decimal? InvoCtrlNoLocPtaxAmt
        {
            get { return Fields.InvoCtrlNoLocPtaxAmt[this]; }
            set { Fields.InvoCtrlNoLocPtaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Ext Price"), Expression("jInvoCtrlNo.[LOC_EXT_PRICE]")]
        public Decimal? InvoCtrlNoLocExtPrice
        {
            get { return Fields.InvoCtrlNoLocExtPrice[this]; }
            set { Fields.InvoCtrlNoLocExtPrice[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Ldisc Amt"), Expression("jInvoCtrlNo.[LOC_LDISC_AMT]")]
        public Decimal? InvoCtrlNoLocLdiscAmt
        {
            get { return Fields.InvoCtrlNoLocLdiscAmt[this]; }
            set { Fields.InvoCtrlNoLocLdiscAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Atax Amt"), Expression("jInvoCtrlNo.[LOC_ATAX_AMT]")]
        public Decimal? InvoCtrlNoLocAtaxAmt
        {
            get { return Fields.InvoCtrlNoLocAtaxAmt[this]; }
            set { Fields.InvoCtrlNoLocAtaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Item Amt"), Expression("jInvoCtrlNo.[LOC_ITEM_AMT]")]
        public Decimal? InvoCtrlNoLocItemAmt
        {
            get { return Fields.InvoCtrlNoLocItemAmt[this]; }
            set { Fields.InvoCtrlNoLocItemAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Tdisc Amt"), Expression("jInvoCtrlNo.[LOC_TDISC_AMT]")]
        public Decimal? InvoCtrlNoLocTdiscAmt
        {
            get { return Fields.InvoCtrlNoLocTdiscAmt[this]; }
            set { Fields.InvoCtrlNoLocTdiscAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Chgs Amt"), Expression("jInvoCtrlNo.[LOC_CHGS_AMT]")]
        public Decimal? InvoCtrlNoLocChgsAmt
        {
            get { return Fields.InvoCtrlNoLocChgsAmt[this]; }
            set { Fields.InvoCtrlNoLocChgsAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Gtax Amt"), Expression("jInvoCtrlNo.[LOC_GTAX_AMT]")]
        public Decimal? InvoCtrlNoLocGtaxAmt
        {
            get { return Fields.InvoCtrlNoLocGtaxAmt[this]; }
            set { Fields.InvoCtrlNoLocGtaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Invo Amt"), Expression("jInvoCtrlNo.[LOC_INVO_AMT]")]
        public Decimal? InvoCtrlNoLocInvoAmt
        {
            get { return Fields.InvoCtrlNoLocInvoAmt[this]; }
            set { Fields.InvoCtrlNoLocInvoAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Dps Applied"), Expression("jInvoCtrlNo.[LOC_DPS_APPLIED]")]
        public Decimal? InvoCtrlNoLocDpsApplied
        {
            get { return Fields.InvoCtrlNoLocDpsApplied[this]; }
            set { Fields.InvoCtrlNoLocDpsApplied[this] = value; }
        }

        [DisplayName("Invo Ctrl No Grn Net Amt"), Expression("jInvoCtrlNo.[GRN_NET_AMT]")]
        public Decimal? InvoCtrlNoGrnNetAmt
        {
            get { return Fields.InvoCtrlNoGrnNetAmt[this]; }
            set { Fields.InvoCtrlNoGrnNetAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lgrn Net Amt"), Expression("jInvoCtrlNo.[LGRN_NET_AMT]")]
        public Decimal? InvoCtrlNoLgrnNetAmt
        {
            get { return Fields.InvoCtrlNoLgrnNetAmt[this]; }
            set { Fields.InvoCtrlNoLgrnNetAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Varia Amt"), Expression("jInvoCtrlNo.[VARIA_AMT]")]
        public Decimal? InvoCtrlNoVariaAmt
        {
            get { return Fields.InvoCtrlNoVariaAmt[this]; }
            set { Fields.InvoCtrlNoVariaAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lvaria Amt"), Expression("jInvoCtrlNo.[LVARIA_AMT]")]
        public Decimal? InvoCtrlNoLvariaAmt
        {
            get { return Fields.InvoCtrlNoLvariaAmt[this]; }
            set { Fields.InvoCtrlNoLvariaAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Item Varia Amt"), Expression("jInvoCtrlNo.[ITEM_VARIA_AMT]")]
        public Decimal? InvoCtrlNoItemVariaAmt
        {
            get { return Fields.InvoCtrlNoItemVariaAmt[this]; }
            set { Fields.InvoCtrlNoItemVariaAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Litem Varia Amt"), Expression("jInvoCtrlNo.[LITEM_VARIA_AMT]")]
        public Decimal? InvoCtrlNoLitemVariaAmt
        {
            get { return Fields.InvoCtrlNoLitemVariaAmt[this]; }
            set { Fields.InvoCtrlNoLitemVariaAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Chgs Varia Amt"), Expression("jInvoCtrlNo.[CHGS_VARIA_AMT]")]
        public Decimal? InvoCtrlNoChgsVariaAmt
        {
            get { return Fields.InvoCtrlNoChgsVariaAmt[this]; }
            set { Fields.InvoCtrlNoChgsVariaAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lchgs Varia Amt"), Expression("jInvoCtrlNo.[LCHGS_VARIA_AMT]")]
        public Decimal? InvoCtrlNoLchgsVariaAmt
        {
            get { return Fields.InvoCtrlNoLchgsVariaAmt[this]; }
            set { Fields.InvoCtrlNoLchgsVariaAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Last Line No"), Expression("jInvoCtrlNo.[LAST_LINE_NO]")]
        public Decimal? InvoCtrlNoLastLineNo
        {
            get { return Fields.InvoCtrlNoLastLineNo[this]; }
            set { Fields.InvoCtrlNoLastLineNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Created Date"), Expression("jInvoCtrlNo.[CREATED_DATE]")]
        public DateTime? InvoCtrlNoCreatedDate
        {
            get { return Fields.InvoCtrlNoCreatedDate[this]; }
            set { Fields.InvoCtrlNoCreatedDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Created By"), Expression("jInvoCtrlNo.[CREATED_BY]")]
        public String InvoCtrlNoCreatedBy
        {
            get { return Fields.InvoCtrlNoCreatedBy[this]; }
            set { Fields.InvoCtrlNoCreatedBy[this] = value; }
        }

        [DisplayName("Invo Ctrl No Revised Date"), Expression("jInvoCtrlNo.[REVISED_DATE]")]
        public DateTime? InvoCtrlNoRevisedDate
        {
            get { return Fields.InvoCtrlNoRevisedDate[this]; }
            set { Fields.InvoCtrlNoRevisedDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Revised By"), Expression("jInvoCtrlNo.[REVISED_BY]")]
        public String InvoCtrlNoRevisedBy
        {
            get { return Fields.InvoCtrlNoRevisedBy[this]; }
            set { Fields.InvoCtrlNoRevisedBy[this] = value; }
        }

        [DisplayName("Invo Ctrl No Posted Date"), Expression("jInvoCtrlNo.[POSTED_DATE]")]
        public DateTime? InvoCtrlNoPostedDate
        {
            get { return Fields.InvoCtrlNoPostedDate[this]; }
            set { Fields.InvoCtrlNoPostedDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Posted By"), Expression("jInvoCtrlNo.[POSTED_BY]")]
        public String InvoCtrlNoPostedBy
        {
            get { return Fields.InvoCtrlNoPostedBy[this]; }
            set { Fields.InvoCtrlNoPostedBy[this] = value; }
        }

        [DisplayName("Invo Ctrl No Hold"), Expression("jInvoCtrlNo.[HOLD]")]
        public String InvoCtrlNoHold
        {
            get { return Fields.InvoCtrlNoHold[this]; }
            set { Fields.InvoCtrlNoHold[this] = value; }
        }

        [DisplayName("Invo Ctrl No Hold Until"), Expression("jInvoCtrlNo.[HOLD_UNTIL]")]
        public DateTime? InvoCtrlNoHoldUntil
        {
            get { return Fields.InvoCtrlNoHoldUntil[this]; }
            set { Fields.InvoCtrlNoHoldUntil[this] = value; }
        }

        [DisplayName("Invo Ctrl No Hold Date"), Expression("jInvoCtrlNo.[HOLD_DATE]")]
        public DateTime? InvoCtrlNoHoldDate
        {
            get { return Fields.InvoCtrlNoHoldDate[this]; }
            set { Fields.InvoCtrlNoHoldDate[this] = value; }
        }

        [DisplayName("Invo Ctrl No Hold By"), Expression("jInvoCtrlNo.[HOLD_BY]")]
        public String InvoCtrlNoHoldBy
        {
            get { return Fields.InvoCtrlNoHoldBy[this]; }
            set { Fields.InvoCtrlNoHoldBy[this] = value; }
        }

        [DisplayName("Invo Ctrl No Acct Vendor"), Expression("jInvoCtrlNo.[ACCT_VENDOR]")]
        public String InvoCtrlNoAcctVendor
        {
            get { return Fields.InvoCtrlNoAcctVendor[this]; }
            set { Fields.InvoCtrlNoAcctVendor[this] = value; }
        }

        [DisplayName("Invo Ctrl No Acct Tdisc"), Expression("jInvoCtrlNo.[ACCT_TDISC]")]
        public String InvoCtrlNoAcctTdisc
        {
            get { return Fields.InvoCtrlNoAcctTdisc[this]; }
            set { Fields.InvoCtrlNoAcctTdisc[this] = value; }
        }

        [DisplayName("Invo Ctrl No Acct Gtax"), Expression("jInvoCtrlNo.[ACCT_GTAX]")]
        public String InvoCtrlNoAcctGtax
        {
            get { return Fields.InvoCtrlNoAcctGtax[this]; }
            set { Fields.InvoCtrlNoAcctGtax[this] = value; }
        }

        [DisplayName("Invo Ctrl No Acct Variance"), Expression("jInvoCtrlNo.[ACCT_VARIANCE]")]
        public String InvoCtrlNoAcctVariance
        {
            get { return Fields.InvoCtrlNoAcctVariance[this]; }
            set { Fields.InvoCtrlNoAcctVariance[this] = value; }
        }

        [DisplayName("Invo Ctrl No Settled Amt"), Expression("jInvoCtrlNo.[SETTLED_AMT]")]
        public Decimal? InvoCtrlNoSettledAmt
        {
            get { return Fields.InvoCtrlNoSettledAmt[this]; }
            set { Fields.InvoCtrlNoSettledAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lsettled Amt"), Expression("jInvoCtrlNo.[LSETTLED_AMT]")]
        public Decimal? InvoCtrlNoLsettledAmt
        {
            get { return Fields.InvoCtrlNoLsettledAmt[this]; }
            set { Fields.InvoCtrlNoLsettledAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Term Disc Amt"), Expression("jInvoCtrlNo.[TERM_DISC_AMT]")]
        public Decimal? InvoCtrlNoTermDiscAmt
        {
            get { return Fields.InvoCtrlNoTermDiscAmt[this]; }
            set { Fields.InvoCtrlNoTermDiscAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lterm Disc Amt"), Expression("jInvoCtrlNo.[LTERM_DISC_AMT]")]
        public Decimal? InvoCtrlNoLtermDiscAmt
        {
            get { return Fields.InvoCtrlNoLtermDiscAmt[this]; }
            set { Fields.InvoCtrlNoLtermDiscAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Return Amt"), Expression("jInvoCtrlNo.[RETURN_AMT]")]
        public Decimal? InvoCtrlNoReturnAmt
        {
            get { return Fields.InvoCtrlNoReturnAmt[this]; }
            set { Fields.InvoCtrlNoReturnAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lreturn Amt"), Expression("jInvoCtrlNo.[LRETURN_AMT]")]
        public Decimal? InvoCtrlNoLreturnAmt
        {
            get { return Fields.InvoCtrlNoLreturnAmt[this]; }
            set { Fields.InvoCtrlNoLreturnAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Bal Amt"), Expression("jInvoCtrlNo.[BAL_AMT]")]
        public Decimal? InvoCtrlNoBalAmt
        {
            get { return Fields.InvoCtrlNoBalAmt[this]; }
            set { Fields.InvoCtrlNoBalAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Bal Amt Local"), Expression("jInvoCtrlNo.[BAL_AMT_LOCAL]")]
        public Decimal? InvoCtrlNoBalAmtLocal
        {
            get { return Fields.InvoCtrlNoBalAmtLocal[this]; }
            set { Fields.InvoCtrlNoBalAmtLocal[this] = value; }
        }

        [DisplayName("Invo Ctrl No Over Alloc Amt"), Expression("jInvoCtrlNo.[OVER_ALLOC_AMT]")]
        public Decimal? InvoCtrlNoOverAllocAmt
        {
            get { return Fields.InvoCtrlNoOverAllocAmt[this]; }
            set { Fields.InvoCtrlNoOverAllocAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lover Alloc Amt"), Expression("jInvoCtrlNo.[LOVER_ALLOC_AMT]")]
        public Decimal? InvoCtrlNoLoverAllocAmt
        {
            get { return Fields.InvoCtrlNoLoverAllocAmt[this]; }
            set { Fields.InvoCtrlNoLoverAllocAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Batch Select"), Expression("jInvoCtrlNo.[BATCH_SELECT]")]
        public String InvoCtrlNoBatchSelect
        {
            get { return Fields.InvoCtrlNoBatchSelect[this]; }
            set { Fields.InvoCtrlNoBatchSelect[this] = value; }
        }

        [DisplayName("Invo Ctrl No Gl Link"), Expression("jInvoCtrlNo.[GL_LINK]")]
        public String InvoCtrlNoGlLink
        {
            get { return Fields.InvoCtrlNoGlLink[this]; }
            set { Fields.InvoCtrlNoGlLink[this] = value; }
        }

        [DisplayName("Invo Ctrl No Gl Link Type"), Expression("jInvoCtrlNo.[GL_LINK_TYPE]")]
        public String InvoCtrlNoGlLinkType
        {
            get { return Fields.InvoCtrlNoGlLinkType[this]; }
            set { Fields.InvoCtrlNoGlLinkType[this] = value; }
        }

        [DisplayName("Invo Ctrl No Gl Link No"), Expression("jInvoCtrlNo.[GL_LINK_NO]")]
        public String InvoCtrlNoGlLinkNo
        {
            get { return Fields.InvoCtrlNoGlLinkNo[this]; }
            set { Fields.InvoCtrlNoGlLinkNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Last Log No"), Expression("jInvoCtrlNo.[LAST_LOG_NO]")]
        public Decimal? InvoCtrlNoLastLogNo
        {
            get { return Fields.InvoCtrlNoLastLogNo[this]; }
            set { Fields.InvoCtrlNoLastLogNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lock Type"), Expression("jInvoCtrlNo.[LOCK_TYPE]")]
        public String InvoCtrlNoLockType
        {
            get { return Fields.InvoCtrlNoLockType[this]; }
            set { Fields.InvoCtrlNoLockType[this] = value; }
        }

        [DisplayName("Invo Ctrl No Lock Ref No"), Expression("jInvoCtrlNo.[LOCK_REF_NO]")]
        public String InvoCtrlNoLockRefNo
        {
            get { return Fields.InvoCtrlNoLockRefNo[this]; }
            set { Fields.InvoCtrlNoLockRefNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Hold Reason"), Expression("jInvoCtrlNo.[HOLD_REASON]")]
        public String InvoCtrlNoHoldReason
        {
            get { return Fields.InvoCtrlNoHoldReason[this]; }
            set { Fields.InvoCtrlNoHoldReason[this] = value; }
        }

        [DisplayName("Invo Ctrl No Owner Branch"), Expression("jInvoCtrlNo.[OWNER_BRANCH]")]
        public String InvoCtrlNoOwnerBranch
        {
            get { return Fields.InvoCtrlNoOwnerBranch[this]; }
            set { Fields.InvoCtrlNoOwnerBranch[this] = value; }
        }

        [DisplayName("Invo Ctrl No Source Branch"), Expression("jInvoCtrlNo.[SOURCE_BRANCH]")]
        public String InvoCtrlNoSourceBranch
        {
            get { return Fields.InvoCtrlNoSourceBranch[this]; }
            set { Fields.InvoCtrlNoSourceBranch[this] = value; }
        }

        [DisplayName("Invo Ctrl No Particulars"), Expression("jInvoCtrlNo.[PARTICULARS]")]
        public String InvoCtrlNoParticulars
        {
            get { return Fields.InvoCtrlNoParticulars[this]; }
            set { Fields.InvoCtrlNoParticulars[this] = value; }
        }

        [DisplayName("Invo Ctrl No Check Crlimit"), Expression("jInvoCtrlNo.[CHECK_CRLIMIT]")]
        public String InvoCtrlNoCheckCrlimit
        {
            get { return Fields.InvoCtrlNoCheckCrlimit[this]; }
            set { Fields.InvoCtrlNoCheckCrlimit[this] = value; }
        }

        [DisplayName("Invo Ctrl No Check Crbal"), Expression("jInvoCtrlNo.[CHECK_CRBAL]")]
        public Decimal? InvoCtrlNoCheckCrbal
        {
            get { return Fields.InvoCtrlNoCheckCrbal[this]; }
            set { Fields.InvoCtrlNoCheckCrbal[this] = value; }
        }

        [DisplayName("Invo Ctrl No Acct Putax"), Expression("jInvoCtrlNo.[ACCT_PUTAX]")]
        public String InvoCtrlNoAcctPutax
        {
            get { return Fields.InvoCtrlNoAcctPutax[this]; }
            set { Fields.InvoCtrlNoAcctPutax[this] = value; }
        }

        [DisplayName("Invo Ctrl No Putax Type"), Expression("jInvoCtrlNo.[PUTAX_TYPE]")]
        public String InvoCtrlNoPutaxType
        {
            get { return Fields.InvoCtrlNoPutaxType[this]; }
            set { Fields.InvoCtrlNoPutaxType[this] = value; }
        }

        [DisplayName("Invo Ctrl No Gputax Pcent"), Expression("jInvoCtrlNo.[GPUTAX_PCENT]")]
        public Decimal? InvoCtrlNoGputaxPcent
        {
            get { return Fields.InvoCtrlNoGputaxPcent[this]; }
            set { Fields.InvoCtrlNoGputaxPcent[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Gputax Amt"), Expression("jInvoCtrlNo.[TOT_GPUTAX_AMT]")]
        public Decimal? InvoCtrlNoTotGputaxAmt
        {
            get { return Fields.InvoCtrlNoTotGputaxAmt[this]; }
            set { Fields.InvoCtrlNoTotGputaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Tot Lputax Amt"), Expression("jInvoCtrlNo.[TOT_LPUTAX_AMT]")]
        public Decimal? InvoCtrlNoTotLputaxAmt
        {
            get { return Fields.InvoCtrlNoTotLputaxAmt[this]; }
            set { Fields.InvoCtrlNoTotLputaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Gputax Amt"), Expression("jInvoCtrlNo.[LOC_GPUTAX_AMT]")]
        public Decimal? InvoCtrlNoLocGputaxAmt
        {
            get { return Fields.InvoCtrlNoLocGputaxAmt[this]; }
            set { Fields.InvoCtrlNoLocGputaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Loc Lputax Amt"), Expression("jInvoCtrlNo.[LOC_LPUTAX_AMT]")]
        public Decimal? InvoCtrlNoLocLputaxAmt
        {
            get { return Fields.InvoCtrlNoLocLputaxAmt[this]; }
            set { Fields.InvoCtrlNoLocLputaxAmt[this] = value; }
        }

        [DisplayName("Invo Ctrl No Grn Putax Type"), Expression("jInvoCtrlNo.[GRN_PUTAX_TYPE]")]
        public String InvoCtrlNoGrnPutaxType
        {
            get { return Fields.InvoCtrlNoGrnPutaxType[this]; }
            set { Fields.InvoCtrlNoGrnPutaxType[this] = value; }
        }

        [DisplayName("Invo Ctrl No Grn Gputax Pcent"), Expression("jInvoCtrlNo.[GRN_GPUTAX_PCENT]")]
        public Decimal? InvoCtrlNoGrnGputaxPcent
        {
            get { return Fields.InvoCtrlNoGrnGputaxPcent[this]; }
            set { Fields.InvoCtrlNoGrnGputaxPcent[this] = value; }
        }

        [DisplayName("Invo Ctrl No Grn Count"), Expression("jInvoCtrlNo.[GRN_COUNT]")]
        public Decimal? InvoCtrlNoGrnCount
        {
            get { return Fields.InvoCtrlNoGrnCount[this]; }
            set { Fields.InvoCtrlNoGrnCount[this] = value; }
        }

        [DisplayName("Invo Ctrl No Ai Link"), Expression("jInvoCtrlNo.[AI_LINK]")]
        public String InvoCtrlNoAiLink
        {
            get { return Fields.InvoCtrlNoAiLink[this]; }
            set { Fields.InvoCtrlNoAiLink[this] = value; }
        }

        [DisplayName("Invo Ctrl No Ai Link Type"), Expression("jInvoCtrlNo.[AI_LINK_TYPE]")]
        public String InvoCtrlNoAiLinkType
        {
            get { return Fields.InvoCtrlNoAiLinkType[this]; }
            set { Fields.InvoCtrlNoAiLinkType[this] = value; }
        }

        [DisplayName("Invo Ctrl No Ai Link No"), Expression("jInvoCtrlNo.[AI_LINK_NO]")]
        public String InvoCtrlNoAiLinkNo
        {
            get { return Fields.InvoCtrlNoAiLinkNo[this]; }
            set { Fields.InvoCtrlNoAiLinkNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys9"), Expression("jInvoCtrlNo.[ANLYS9]")]
        public String InvoCtrlNoAnlys9
        {
            get { return Fields.InvoCtrlNoAnlys9[this]; }
            set { Fields.InvoCtrlNoAnlys9[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys10"), Expression("jInvoCtrlNo.[ANLYS10]")]
        public String InvoCtrlNoAnlys10
        {
            get { return Fields.InvoCtrlNoAnlys10[this]; }
            set { Fields.InvoCtrlNoAnlys10[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys11"), Expression("jInvoCtrlNo.[ANLYS11]")]
        public String InvoCtrlNoAnlys11
        {
            get { return Fields.InvoCtrlNoAnlys11[this]; }
            set { Fields.InvoCtrlNoAnlys11[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys12"), Expression("jInvoCtrlNo.[ANLYS12]")]
        public String InvoCtrlNoAnlys12
        {
            get { return Fields.InvoCtrlNoAnlys12[this]; }
            set { Fields.InvoCtrlNoAnlys12[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys13"), Expression("jInvoCtrlNo.[ANLYS13]")]
        public String InvoCtrlNoAnlys13
        {
            get { return Fields.InvoCtrlNoAnlys13[this]; }
            set { Fields.InvoCtrlNoAnlys13[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys14"), Expression("jInvoCtrlNo.[ANLYS14]")]
        public String InvoCtrlNoAnlys14
        {
            get { return Fields.InvoCtrlNoAnlys14[this]; }
            set { Fields.InvoCtrlNoAnlys14[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys15"), Expression("jInvoCtrlNo.[ANLYS15]")]
        public String InvoCtrlNoAnlys15
        {
            get { return Fields.InvoCtrlNoAnlys15[this]; }
            set { Fields.InvoCtrlNoAnlys15[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys16"), Expression("jInvoCtrlNo.[ANLYS16]")]
        public String InvoCtrlNoAnlys16
        {
            get { return Fields.InvoCtrlNoAnlys16[this]; }
            set { Fields.InvoCtrlNoAnlys16[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys17"), Expression("jInvoCtrlNo.[ANLYS17]")]
        public String InvoCtrlNoAnlys17
        {
            get { return Fields.InvoCtrlNoAnlys17[this]; }
            set { Fields.InvoCtrlNoAnlys17[this] = value; }
        }

        [DisplayName("Invo Ctrl No Anlys18"), Expression("jInvoCtrlNo.[ANLYS18]")]
        public String InvoCtrlNoAnlys18
        {
            get { return Fields.InvoCtrlNoAnlys18[this]; }
            set { Fields.InvoCtrlNoAnlys18[this] = value; }
        }

        [DisplayName("Invo Ctrl No Po No"), Expression("jInvoCtrlNo.[PO_NO]")]
        public String InvoCtrlNoPoNo
        {
            get { return Fields.InvoCtrlNoPoNo[this]; }
            set { Fields.InvoCtrlNoPoNo[this] = value; }
        }

        [DisplayName("Invo Ctrl No Origin Country"), Expression("jInvoCtrlNo.[ORIGIN_COUNTRY]")]
        public String InvoCtrlNoOriginCountry
        {
            get { return Fields.InvoCtrlNoOriginCountry[this]; }
            set { Fields.InvoCtrlNoOriginCountry[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.RefNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsPayablePaymentDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public StringField InvoCtrlNo;
            public StringField InvoiceNo;
            public DateTimeField InvoiceDate;
            public DateTimeField DiscountDate;
            public DateTimeField DueDate;
            public DecimalField DiscPercent;
            public StringField Ccy;
            public DecimalField InvoExchRate;
            public DecimalField PayExchRate;
            public StringField Settle;
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
            public DateTimeField PaidDate;
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

            public DecimalField RefNoRecnum;
            public StringField RefNoDeposit;
            public StringField RefNoPosted;
            public StringField RefNoVendorNo;
            public StringField RefNoVendorName;
            public StringField RefNoOrderNo;
            public DateTimeField RefNoPaidDate;
            public StringField RefNoPeriod;
            public DecimalField RefNoFiscalYear;
            public DecimalField RefNoPeriodNo;
            public StringField RefNoFundCode;
            public StringField RefNoPayee;
            public StringField RefNoChequeNo;
            public StringField RefNoCcy;
            public DecimalField RefNoExchRate;
            public StringField RefNoSameCurrency;
            public DecimalField RefNoPaidAmt;
            public DecimalField RefNoPaidAmtLocal;
            public DecimalField RefNoBalAmt;
            public DecimalField RefNoDiscAmt;
            public DecimalField RefNoDueAmt;
            public DecimalField RefNoDueAmtLocal;
            public DecimalField RefNoAppliedAmt;
            public DecimalField RefNoAppliedAmtLoc;
            public DecimalField RefNoSettledAmt;
            public DecimalField RefNoForexGainAmt;
            public DecimalField RefNoEndAmt;
            public DecimalField RefNoEndAmtLocal;
            public DecimalField RefNoUnusedAmt;
            public DecimalField RefNoUnusedAmtLoc;
            public DecimalField RefNoAppliedLocCpd;
            public DecimalField RefNoRoundDiff;
            public DateTimeField RefNoCreatedDate;
            public StringField RefNoCreatedBy;
            public DateTimeField RefNoRevisedDate;
            public StringField RefNoRevisedBy;
            public DateTimeField RefNoPostedDate;
            public StringField RefNoPostedBy;
            public StringField RefNoAcctVendor;
            public StringField RefNoAcctCash;
            public StringField RefNoAcctForexDiff;
            public StringField RefNoAcctTermDisc;
            public StringField RefNoAcctRoundDiff;
            public StringField RefNoBatchSelect;
            public StringField RefNoGlLink;
            public StringField RefNoGlLinkType;
            public StringField RefNoGlLinkNo;
            public StringField RefNoFixedCcy;
            public StringField RefNoDefaultCcy;
            public DecimalField RefNoPaidLocalCpd;
            public StringField RefNoOwnerBranch;
            public StringField RefNoSourceBranch;
            public StringField RefNoCanEdit;
            public DecimalField RefNoDiscAmtInvo;
            public DecimalField RefNoTotalDebit;
            public DecimalField RefNoTotalCredit;
            public DecimalField RefNoLastAdjCount;
            public StringField RefNoCcyInv;
            public DecimalField RefNoExchRateInv;
            public DecimalField RefNoAppliedAmtInv;
            public DecimalField RefNoBankAmt;
            public StringField RefNoAnlys1;
            public StringField RefNoAnlys2;
            public StringField RefNoAnlys7;
            public StringField RefNoAnlys8;
            public StringField RefNoRemarks;
            public StringField RefNoToOpen;
            public StringField RefNoToRound;
            public DecimalField RefNoGbvendInvoAmtDiff;
            public DecimalField RefNoGbvendOpenAmtDiff;
            public DecimalField RefNoApledgTotalDebit;
            public DecimalField RefNoApledgTotalCredit;
            public StringField RefNoAllowCancel;
            public DecimalField RefNoChargeAmt;
            public DecimalField RefNoChargeAmtLocal;
            public StringField RefNoAnlys9;
            public StringField RefNoAnlys10;
            public StringField RefNoAnlys11;
            public StringField RefNoAnlys12;
            public StringField RefNoAnlys13;
            public StringField RefNoAnlys14;
            public StringField RefNoAcctDeposit;

            public DecimalField InvoCtrlNoRecnum;
            public StringField InvoCtrlNoMiscellaneous;
            public StringField InvoCtrlNoPosted;
            public StringField InvoCtrlNoClosed;
            public StringField InvoCtrlNoReturned;
            public StringField InvoCtrlNoVendorNo;
            public StringField InvoCtrlNoVendorName;
            public StringField InvoCtrlNoInvoiceNo;
            public DateTimeField InvoCtrlNoInvoiceDate;
            public DateTimeField InvoCtrlNoReceivedDate;
            public StringField InvoCtrlNoPeriod;
            public DecimalField InvoCtrlNoFiscalYear;
            public DecimalField InvoCtrlNoPeriodNo;
            public StringField InvoCtrlNoPayTerms;
            public DecimalField InvoCtrlNoDiscPercent;
            public DecimalField InvoCtrlNoDiscDays;
            public DecimalField InvoCtrlNoNetDays;
            public DateTimeField InvoCtrlNoDiscountDate;
            public DateTimeField InvoCtrlNoDueDate;
            public DateTimeField InvoCtrlNoPlannedDate;
            public StringField InvoCtrlNoPaymentBranch;
            public StringField InvoCtrlNoCcy;
            public DecimalField InvoCtrlNoExchRate;
            public DecimalField InvoCtrlNoTotPriceAmt;
            public DecimalField InvoCtrlNoTotPtaxAmt;
            public DecimalField InvoCtrlNoTotExtPrice;
            public DecimalField InvoCtrlNoTotLdiscAmt;
            public DecimalField InvoCtrlNoTotAtaxAmt;
            public DecimalField InvoCtrlNoTotItemAmt;
            public DecimalField InvoCtrlNoTotTdiscAmt;
            public DecimalField InvoCtrlNoNetTradeAmt;
            public DecimalField InvoCtrlNoTotChgsAmt;
            public DecimalField InvoCtrlNoNetOrdrAmt;
            public DecimalField InvoCtrlNoTotGtaxAmt;
            public DecimalField InvoCtrlNoNetInvoAmt;
            public DecimalField InvoCtrlNoDpsApplied;
            public DecimalField InvoCtrlNoNetBalAmt;
            public DecimalField InvoCtrlNoLocPriceAmt;
            public DecimalField InvoCtrlNoLocPtaxAmt;
            public DecimalField InvoCtrlNoLocExtPrice;
            public DecimalField InvoCtrlNoLocLdiscAmt;
            public DecimalField InvoCtrlNoLocAtaxAmt;
            public DecimalField InvoCtrlNoLocItemAmt;
            public DecimalField InvoCtrlNoLocTdiscAmt;
            public DecimalField InvoCtrlNoLocChgsAmt;
            public DecimalField InvoCtrlNoLocGtaxAmt;
            public DecimalField InvoCtrlNoLocInvoAmt;
            public DecimalField InvoCtrlNoLocDpsApplied;
            public DecimalField InvoCtrlNoGrnNetAmt;
            public DecimalField InvoCtrlNoLgrnNetAmt;
            public DecimalField InvoCtrlNoVariaAmt;
            public DecimalField InvoCtrlNoLvariaAmt;
            public DecimalField InvoCtrlNoItemVariaAmt;
            public DecimalField InvoCtrlNoLitemVariaAmt;
            public DecimalField InvoCtrlNoChgsVariaAmt;
            public DecimalField InvoCtrlNoLchgsVariaAmt;
            public DecimalField InvoCtrlNoLastLineNo;
            public DateTimeField InvoCtrlNoCreatedDate;
            public StringField InvoCtrlNoCreatedBy;
            public DateTimeField InvoCtrlNoRevisedDate;
            public StringField InvoCtrlNoRevisedBy;
            public DateTimeField InvoCtrlNoPostedDate;
            public StringField InvoCtrlNoPostedBy;
            public StringField InvoCtrlNoHold;
            public DateTimeField InvoCtrlNoHoldUntil;
            public DateTimeField InvoCtrlNoHoldDate;
            public StringField InvoCtrlNoHoldBy;
            public StringField InvoCtrlNoAcctVendor;
            public StringField InvoCtrlNoAcctTdisc;
            public StringField InvoCtrlNoAcctGtax;
            public StringField InvoCtrlNoAcctVariance;
            public DecimalField InvoCtrlNoSettledAmt;
            public DecimalField InvoCtrlNoLsettledAmt;
            public DecimalField InvoCtrlNoTermDiscAmt;
            public DecimalField InvoCtrlNoLtermDiscAmt;
            public DecimalField InvoCtrlNoReturnAmt;
            public DecimalField InvoCtrlNoLreturnAmt;
            public DecimalField InvoCtrlNoBalAmt;
            public DecimalField InvoCtrlNoBalAmtLocal;
            public DecimalField InvoCtrlNoOverAllocAmt;
            public DecimalField InvoCtrlNoLoverAllocAmt;
            public StringField InvoCtrlNoBatchSelect;
            public StringField InvoCtrlNoGlLink;
            public StringField InvoCtrlNoGlLinkType;
            public StringField InvoCtrlNoGlLinkNo;
            public DecimalField InvoCtrlNoLastLogNo;
            public StringField InvoCtrlNoLockType;
            public StringField InvoCtrlNoLockRefNo;
            public StringField InvoCtrlNoHoldReason;
            public StringField InvoCtrlNoOwnerBranch;
            public StringField InvoCtrlNoSourceBranch;
            public StringField InvoCtrlNoParticulars;
            public StringField InvoCtrlNoCheckCrlimit;
            public DecimalField InvoCtrlNoCheckCrbal;
            public StringField InvoCtrlNoAcctPutax;
            public StringField InvoCtrlNoPutaxType;
            public DecimalField InvoCtrlNoGputaxPcent;
            public DecimalField InvoCtrlNoTotGputaxAmt;
            public DecimalField InvoCtrlNoTotLputaxAmt;
            public DecimalField InvoCtrlNoLocGputaxAmt;
            public DecimalField InvoCtrlNoLocLputaxAmt;
            public StringField InvoCtrlNoGrnPutaxType;
            public DecimalField InvoCtrlNoGrnGputaxPcent;
            public DecimalField InvoCtrlNoGrnCount;
            public StringField InvoCtrlNoAiLink;
            public StringField InvoCtrlNoAiLinkType;
            public StringField InvoCtrlNoAiLinkNo;
            public StringField InvoCtrlNoAnlys9;
            public StringField InvoCtrlNoAnlys10;
            public StringField InvoCtrlNoAnlys11;
            public StringField InvoCtrlNoAnlys12;
            public StringField InvoCtrlNoAnlys13;
            public StringField InvoCtrlNoAnlys14;
            public StringField InvoCtrlNoAnlys15;
            public StringField InvoCtrlNoAnlys16;
            public StringField InvoCtrlNoAnlys17;
            public StringField InvoCtrlNoAnlys18;
            public StringField InvoCtrlNoPoNo;
            public StringField InvoCtrlNoOriginCountry;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsPayablePaymentDetail";
            }
        }
    }
}
