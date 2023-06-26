#region Enterprise Solution
// Copyright © 2006-2015 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Microsoft.Common.Enum
// File:  FinanceInterfaceExportField.cs 
// Date: 2014/07/14 0:39

#endregion
using System;
using Microsoft.Common;

namespace Microsoft.Enums
{
    public enum FinanceInterfaceExportField
    {
        [DisplayText("Voucher Type (A)")]
        [StringValue("H01 VOUCHER_TYPE")]
        HeaderVoucherType,

        [DisplayText("Voucher No (A)")]
        [StringValue("H02 VOUCHER_NO")]
        HeaderVoucherNo,

        [DisplayText("Posted (A)")]
        [StringValue("H04 POSTED")]
        HeaderPosted,

        [DisplayText("Hold (A)")]
        [StringValue("H05 HOLD")]
        HeaderHold,

        [DisplayText("Voucher Date (D)")]
        [StringValue("H06 VOUCHER_DATE")]
        HeaderVoucherDate,

        [DisplayText("Period (A)")]
        [StringValue("H07 PERIOD")]
        HeaderPreiod,

        [DisplayText("Fiscal Year (N)")]
        [StringValue("H08 FISCAL_YEAR")]
        HeaderFiscalYear,

        [DisplayText("Period No (N)")]
        [StringValue("H09 PERIOD_NO")]
        HeaderPreiodNo,

        [DisplayText("Reference (A)")]
        [StringValue("H10 REFERENCE")]
        HeaderReference,

        [DisplayText("Total Debit (N)")]
        [StringValue("H13 TOTAL_DEBIT")]
        HeaderTotalDebit,

        [DisplayText("Total Credit (N)")]
        [StringValue("H14 TOTAL_CREDIT")]
        HeaderTotalCredit,

        [DisplayText("Journal No (N)")]
        [StringValue("H17 JOURNAL_NO")]
        HeaderJournalNo,

        [DisplayText("Source Type (A)")]
        [StringValue("H18 SOURCE_TYPE")]
        HeaderSourceType,

        [DisplayText("Source Reference (A)")]
        [StringValue("H19 SOURCE_REF")]
        HeaderSourceRef,

        [DisplayText("Analysis 1 (A)")]
        [StringValue("H20 ANLYS1")]
        HeaderAnlys1,

        [DisplayText("Analysis 2 (A)")]
        [StringValue("H21 ANLYS2")]
        HeaderAnlys2,

        [DisplayText("Created Date (D)")]
        [StringValue("H24 CREATED_DATE")]
        HeaderCreatedDate,

        [DisplayText("Created By (A)")]
        [StringValue("H25 CREATED_BY")]
        HeaderCreatedBy,

        [DisplayText("Revised Date (D)")]
        [StringValue("H26 REVISED_DATE")]
        HeaderRevisedDate,

        [DisplayText("Revised By (A)")]
        [StringValue("H27 REVISED_BY")]
        HeaderRevisedBy,

        [DisplayText("Posted By (A)")]
        [StringValue("H28 POSTED_BY")]
        HeaderPostedBy,

        [DisplayText("Posted Date (D)")]
        [StringValue("H29 POSTED_DATE")]
        HeaderPostedDate,

        [DisplayText("Particulars (A)")]
        [StringValue("H32 PARTICULARS")]
        HeaderParticulars,

        [DisplayText("Voucher Type (A)")]
        [StringValue("L01 VOUCHER_TYPE")]
        DetailVoucherType,

        [DisplayText("Voucher No (A)")]
        [StringValue("L02 VOUCHER_NO")]
        DetailVoucherNo,

        [DisplayText("Line No (N)")]
        [StringValue("L04 LINE_NO")]
        DetailLineNo,

        [DisplayText("Account No (A)")]
        [StringValue("L05 ACCT_NO")]
        DetailAcctNo,

        [DisplayText("Cost Centre (A)")]
        [StringValue("L08 COST_CENTRE")]
        DetailCostCenter,

        [DisplayText("Department (A)")]
        [StringValue("L09 DEPT")]
        DetailDept,

        [DisplayText("Line Reference (A)")]
        [StringValue("L10 LINE_REF")]
        DetailRef,

        [DisplayText("Currency (A)")]
        [StringValue("L11 CCY")]
        DetailCcy,

        [DisplayText("Exchange Rate (N)")]
        [StringValue("L12 EXCH_RATE")]
        DetailExchRate,

        [DisplayText("Foreign Debit Amount (N)")]
        [StringValue("L13 DEBIT")]
        DetailDebit,

        [DisplayText("Foreign Credit Amount (N)")]
        [StringValue("L14 CREDIT")]
        DetailCredit,

        [DisplayText("Foreign Amount (N)")]
        [StringValue("L15 FOREX_AMT")]
        DetailForexAmt,

        [DisplayText("Local Amount (N)")]
        [StringValue("L16 LEDGER_AMT")]
        DetailLedgerAmt,

        [DisplayText("Sign (A)")]
        [StringValue("L17 SIGN")]
        DetailSign,

        [DisplayText("Local Debit Amount (N)")]
        [StringValue("L18 LEDGER_DEBIT")]
        DetailLedgerDebit,

        [DisplayText("Local Credit Amount (N)")]
        [StringValue("L19 LEDGER_CREDIT")]
        DetailLedgerCredit,

        [DisplayText("Analysis Code 1 (A)")]
        [StringValue("L20 ANLYS1")]
        DetailAnalysisCode1,

        [DisplayText("Analysis Code 2 (A)")]
        [StringValue("L21 ANLYS2")]
        DetailAnalysisCode2,

        [DisplayText("Analysis Code 3 (A)")]
        [StringValue("L22 ANLYS3")]
        DetailAnalysisCode3,

        [DisplayText("Analysis Code 4 (A)")]
        [StringValue("L23 ANLYS4")]
        DetailAnalysisCode4,

        [DisplayText("Analysis Code 5 (A)")]
        [StringValue("L24 ANLYS5")]
        DetailAnalysisCode5,

        [DisplayText("Analysis Code 6 (A)")]
        [StringValue("L25 ANLYS6")]
        DetailAnalysisCode6,

        [DisplayText("Period (A)")]
        [StringValue("L28 PERIOD")]
        DetailPeriod,

        [DisplayText("Fiscal Year (N)")]
        [StringValue("L29 FISCAL_YEAR")]
        DetailFiscalYear,

        [DisplayText("Period No (N)")]
        [StringValue("L30 PERIOD_NO")]
        DetailPeriodNo,

        [DisplayText("Journal No (N)")]
        [StringValue("L31 JOURNAL_NO")]
        DetailJournalNo,

        [DisplayText("Voucher Date (D)")]
        [StringValue("L32 VOUCHER_DATE")]
        DetailVoucherDate,

        [DisplayText("Reference (A)")]
        [StringValue("L34 REFERENCE")]
        DetailReference,

        [DisplayText("Posted Date (D)")]
        [StringValue("L35 POSTED_DATE")]
        DetailPostedDate,

        [DisplayText("Particulars (A)")]
        [StringValue("L39 PARTICULARS")]
        DetailParticulars,

        [DisplayText("User Defined Value")]
        [StringValue("USR User Defined")]
        UserDefined,

        [DisplayText("Customize Voucher No")]
        [StringValue("S01 Customize Voucher No.")]
        CustomizeVoucherNo,

        [DisplayText("Running No. by Period")]
        [StringValue("S02 Running No. by Period")]
        RounningNobyPeriod,

        [DisplayText("Running No. by Period and Group")]
        [StringValue("S03 Running No. by Period and Group")]
        RounningNoByPeriodandGroup,

        [DisplayText("Running No. by Transaction")]
        [StringValue("S04 Running No. by Transaction")]
        RounningNoByTransaction
    }
}
