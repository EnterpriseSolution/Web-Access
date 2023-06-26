#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherDetailRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLVOUD]")]
    [DisplayName("Voucher Detail"), InstanceName("Voucher Detail"), TwoLevelCached]   
    public sealed class VoucherDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Voucher Type"), Column("VOUCHER_TYPE"), Size(6), PrimaryKey, QuickSearch]
        public String VoucherType
        {
            get { return Fields.VoucherType[this]; }
            set { Fields.VoucherType[this] = value; }
        }

        [DisplayName("Voucher No"), Column("VOUCHER_NO"), Size(16), PrimaryKey]
        public String VoucherNo
        {
            get { return Fields.VoucherNo[this]; }
            set { Fields.VoucherNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Acct No"), Column("ACCT_NO"), Size(30), NotNull]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
        }

        [DisplayName("Acct Name"), Column("ACCT_NAME"), Size(50)]
        public String AcctName
        {
            get { return Fields.AcctName[this]; }
            set { Fields.AcctName[this] = value; }
        }

        [DisplayName("Branch No"), Column("BRANCH_NO"), Size(4), NotNull]
        public String BranchNo
        {
            get { return Fields.BranchNo[this]; }
            set { Fields.BranchNo[this] = value; }
        }

        [DisplayName("Cost Centre"), Column("COST_CENTRE"), Size(4), NotNull]
        public String CostCentre
        {
            get { return Fields.CostCentre[this]; }
            set { Fields.CostCentre[this] = value; }
        }

        [DisplayName("Dept"), Column("DEPT"), Size(4), NotNull]
        public String Dept
        {
            get { return Fields.Dept[this]; }
            set { Fields.Dept[this] = value; }
        }

        [DisplayName("Line Ref"), Column("LINE_REF"), Size(30)]
        public String LineRef
        {
            get { return Fields.LineRef[this]; }
            set { Fields.LineRef[this] = value; }
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

        [DisplayName("Debit"), Column("DEBIT"), Size(16), Scale(2)]
        public Decimal? Debit
        {
            get { return Fields.Debit[this]; }
            set { Fields.Debit[this] = value; }
        }

        [DisplayName("Credit"), Column("CREDIT"), Size(16), Scale(2)]
        public Decimal? Credit
        {
            get { return Fields.Credit[this]; }
            set { Fields.Credit[this] = value; }
        }

        [DisplayName("Forex Amt"), Column("FOREX_AMT"), Size(16), Scale(2)]
        public Decimal? ForexAmt
        {
            get { return Fields.ForexAmt[this]; }
            set { Fields.ForexAmt[this] = value; }
        }

        [DisplayName("Ledger Amt"), Column("LEDGER_AMT"), Size(16), Scale(2)]
        public Decimal? LedgerAmt
        {
            get { return Fields.LedgerAmt[this]; }
            set { Fields.LedgerAmt[this] = value; }
        }

        [DisplayName("Sign"), Column("SIGN"), Size(6), NotNull]
        public String Sign
        {
            get { return Fields.Sign[this]; }
            set { Fields.Sign[this] = value; }
        }

        [DisplayName("Ledger Debit"), Column("LEDGER_DEBIT"), Size(16), Scale(2)]
        public Decimal? LedgerDebit
        {
            get { return Fields.LedgerDebit[this]; }
            set { Fields.LedgerDebit[this] = value; }
        }

        [DisplayName("Ledger Credit"), Column("LEDGER_CREDIT"), Size(16), Scale(2)]
        public Decimal? LedgerCredit
        {
            get { return Fields.LedgerCredit[this]; }
            set { Fields.LedgerCredit[this] = value; }
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

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Reconciled"), Column("RECONCILED"), Size(1), NotNull]
        public String Reconciled
        {
            get { return Fields.Reconciled[this]; }
            set { Fields.Reconciled[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), NotNull]
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

        [DisplayName("Journal No"), Column("JOURNAL_NO"), Size(8), NotNull]
        public Decimal? JournalNo
        {
            get { return Fields.JournalNo[this]; }
            set { Fields.JournalNo[this] = value; }
        }

        [DisplayName("Voucher Date"), Column("VOUCHER_DATE"), NotNull]
        public DateTime? VoucherDate
        {
            get { return Fields.VoucherDate[this]; }
            set { Fields.VoucherDate[this] = value; }
        }

        [DisplayName("Ledger Amt Cpd"), Column("LEDGER_AMT_CPD"), Size(16), Scale(2)]
        public Decimal? LedgerAmtCpd
        {
            get { return Fields.LedgerAmtCpd[this]; }
            set { Fields.LedgerAmtCpd[this] = value; }
        }

        [DisplayName("Reference"), Column("REFERENCE"), Size(30)]
        public String Reference
        {
            get { return Fields.Reference[this]; }
            set { Fields.Reference[this] = value; }
        }

        [DisplayName("Posted Date"), Column("POSTED_DATE"), NotNull]
        public DateTime? PostedDate
        {
            get { return Fields.PostedDate[this]; }
            set { Fields.PostedDate[this] = value; }
        }

        [DisplayName("Running Balance"), Column("RUNNING_BALANCE"), Size(16), Scale(2)]
        public Decimal? RunningBalance
        {
            get { return Fields.RunningBalance[this]; }
            set { Fields.RunningBalance[this] = value; }
        }

        [DisplayName("Balance Sign"), Column("BALANCE_SIGN"), Size(6)]
        public String BalanceSign
        {
            get { return Fields.BalanceSign[this]; }
            set { Fields.BalanceSign[this] = value; }
        }

        [DisplayName("Exch Diff"), Column("EXCH_DIFF"), Size(1)]
        public String ExchDiff
        {
            get { return Fields.ExchDiff[this]; }
            set { Fields.ExchDiff[this] = value; }
        }

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
        }

        [DisplayName("Item Group"), Column("ITEM_GROUP"), Size(10)]
        public String ItemGroup
        {
            get { return Fields.ItemGroup[this]; }
            set { Fields.ItemGroup[this] = value; }
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

        [DisplayName("Invoice No"), Column("INVOICE_NO"), Size(16)]
        public String InvoiceNo
        {
            get { return Fields.InvoiceNo[this]; }
            set { Fields.InvoiceNo[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.VoucherType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VoucherDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField VoucherType;
            public StringField VoucherNo;
            public DecimalField LineNo;
            public StringField AcctNo;
            public StringField AcctName;
            public StringField BranchNo;
            public StringField CostCentre;
            public StringField Dept;
            public StringField LineRef;
            public StringField Ccy;
            public DecimalField ExchRate;
            public DecimalField Debit;
            public DecimalField Credit;
            public DecimalField ForexAmt;
            public DecimalField LedgerAmt;
            public StringField Sign;
            public DecimalField LedgerDebit;
            public DecimalField LedgerCredit;
            public StringField Anlys1;
            public StringField Anlys2;
            public StringField Anlys3;
            public StringField Anlys4;
            public StringField Anlys5;
            public StringField Anlys6;
            public StringField Posted;
            public StringField Reconciled;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public DecimalField JournalNo;
            public DateTimeField VoucherDate;
            public DecimalField LedgerAmtCpd;
            public StringField Reference;
            public DateTimeField PostedDate;
            public DecimalField RunningBalance;
            public StringField BalanceSign;
            public StringField ExchDiff;
            public StringField Particulars;
            public StringField ItemGroup;
            public StringField Anlys15;
            public StringField Anlys16;
            public StringField Anlys17;
            public StringField Anlys18;
            public StringField Anlys19;
            public StringField Anlys20;
            public StringField InvoiceNo;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.VoucherDetail";
            }
        }
    }
}
