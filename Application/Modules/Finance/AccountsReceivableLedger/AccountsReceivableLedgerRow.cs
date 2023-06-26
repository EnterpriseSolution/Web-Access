#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableLedgerRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[ARLEDG]")]
    [DisplayName("Accounts Receivable Ledger"), InstanceName("Accounts Receivable Ledger"), TwoLevelCached]   
    public sealed class AccountsReceivableLedgerRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8), PrimaryKey, QuickSearch]
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

        [DisplayName("Summary"), Column("SUMMARY"), Size(1), PrimaryKey]
        public String Summary
        {
            get { return Fields.Summary[this]; }
            set { Fields.Summary[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4), PrimaryKey]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), PrimaryKey]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Customer No 2"), Column("CUSTOMER_NO_2"), Size(8), NotNull]
        public String CustomerNo2
        {
            get { return Fields.CustomerNo2[this]; }
            set { Fields.CustomerNo2[this] = value; }
        }

        [DisplayName("Ccy 2"), Column("CCY_2"), Size(4), NotNull]
        public String Ccy2
        {
            get { return Fields.Ccy2[this]; }
            set { Fields.Ccy2[this] = value; }
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

        [DisplayName("Invoice Amt"), Column("INVO_AMT"), Size(16), Scale(2)]
        public Decimal? InvoAmt
        {
            get { return Fields.InvoAmt[this]; }
            set { Fields.InvoAmt[this] = value; }
        }

        [DisplayName("Memo Amt"), Column("MEMO_AMT"), Size(16), Scale(2)]
        public Decimal? MemoAmt
        {
            get { return Fields.MemoAmt[this]; }
            set { Fields.MemoAmt[this] = value; }
        }

        [DisplayName("Adjust Amt"), Column("ADJ_AMT"), Size(16), Scale(2)]
        public Decimal? AdjAmt
        {
            get { return Fields.AdjAmt[this]; }
            set { Fields.AdjAmt[this] = value; }
        }

        [DisplayName("Payment Amt"), Column("PAY_AMT"), Size(16), Scale(2)]
        public Decimal? PayAmt
        {
            get { return Fields.PayAmt[this]; }
            set { Fields.PayAmt[this] = value; }
        }

        [DisplayName("Discount Amt"), Column("DISC_AMT"), Size(16), Scale(2)]
        public Decimal? DiscAmt
        {
            get { return Fields.DiscAmt[this]; }
            set { Fields.DiscAmt[this] = value; }
        }

        [DisplayName("Difference Amt"), Column("DIFF_AMT"), Size(16), Scale(2)]
        public Decimal? DiffAmt
        {
            get { return Fields.DiffAmt[this]; }
            set { Fields.DiffAmt[this] = value; }
        }

        [DisplayName("Balance Beg"), Column("BAL_BEG"), Size(16), Scale(2)]
        public Decimal? BalBeg
        {
            get { return Fields.BalBeg[this]; }
            set { Fields.BalBeg[this] = value; }
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

        [DisplayName("Balance End"), Column("BAL_END"), Size(16), Scale(2)]
        public Decimal? BalEnd
        {
            get { return Fields.BalEnd[this]; }
            set { Fields.BalEnd[this] = value; }
        }

        [DisplayName("Local Invo Amt"), Column("LOCAL_INVO_AMT"), Size(16), Scale(2)]
        public Decimal? LocalInvoAmt
        {
            get { return Fields.LocalInvoAmt[this]; }
            set { Fields.LocalInvoAmt[this] = value; }
        }

        [DisplayName("Local Memo Amt"), Column("LOCAL_MEMO_AMT"), Size(16), Scale(2)]
        public Decimal? LocalMemoAmt
        {
            get { return Fields.LocalMemoAmt[this]; }
            set { Fields.LocalMemoAmt[this] = value; }
        }

        [DisplayName("Local Adj Amt"), Column("LOCAL_ADJ_AMT"), Size(16), Scale(2)]
        public Decimal? LocalAdjAmt
        {
            get { return Fields.LocalAdjAmt[this]; }
            set { Fields.LocalAdjAmt[this] = value; }
        }

        [DisplayName("Local Pay Amt"), Column("LOCAL_PAY_AMT"), Size(16), Scale(2)]
        public Decimal? LocalPayAmt
        {
            get { return Fields.LocalPayAmt[this]; }
            set { Fields.LocalPayAmt[this] = value; }
        }

        [DisplayName("Local Disc Amt"), Column("LOCAL_DISC_AMT"), Size(16), Scale(2)]
        public Decimal? LocalDiscAmt
        {
            get { return Fields.LocalDiscAmt[this]; }
            set { Fields.LocalDiscAmt[this] = value; }
        }

        [DisplayName("Local Diff Amt"), Column("LOCAL_DIFF_AMT"), Size(16), Scale(2)]
        public Decimal? LocalDiffAmt
        {
            get { return Fields.LocalDiffAmt[this]; }
            set { Fields.LocalDiffAmt[this] = value; }
        }

        [DisplayName("Local Bal Beg"), Column("LOCAL_BAL_BEG"), Size(16), Scale(2)]
        public Decimal? LocalBalBeg
        {
            get { return Fields.LocalBalBeg[this]; }
            set { Fields.LocalBalBeg[this] = value; }
        }

        [DisplayName("Local Debit"), Column("LOCAL_DEBIT"), Size(16), Scale(2)]
        public Decimal? LocalDebit
        {
            get { return Fields.LocalDebit[this]; }
            set { Fields.LocalDebit[this] = value; }
        }

        [DisplayName("Local Credit"), Column("LOCAL_CREDIT"), Size(16), Scale(2)]
        public Decimal? LocalCredit
        {
            get { return Fields.LocalCredit[this]; }
            set { Fields.LocalCredit[this] = value; }
        }

        [DisplayName("Local Bal End"), Column("LOCAL_BAL_END"), Size(16), Scale(2)]
        public Decimal? LocalBalEnd
        {
            get { return Fields.LocalBalEnd[this]; }
            set { Fields.LocalBalEnd[this] = value; }
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

        [DisplayName("Refund Amt"), Column("RFD_AMT"), Size(16), Scale(2)]
        public Decimal? RfdAmt
        {
            get { return Fields.RfdAmt[this]; }
            set { Fields.RfdAmt[this] = value; }
        }

        [DisplayName("Local Rfd Amt"), Column("LOCAL_RFD_AMT"), Size(16), Scale(2)]
        public Decimal? LocalRfdAmt
        {
            get { return Fields.LocalRfdAmt[this]; }
            set { Fields.LocalRfdAmt[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CustomerNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsReceivableLedgerRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField CustomerNo;
            public StringField CustomerName;
            public StringField Summary;
            public StringField Ccy;
            public StringField Period;
            public StringField CustomerNo2;
            public StringField Ccy2;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public DecimalField InvoAmt;
            public DecimalField MemoAmt;
            public DecimalField AdjAmt;
            public DecimalField PayAmt;
            public DecimalField DiscAmt;
            public DecimalField DiffAmt;
            public DecimalField BalBeg;
            public DecimalField Debit;
            public DecimalField Credit;
            public DecimalField BalEnd;
            public DecimalField LocalInvoAmt;
            public DecimalField LocalMemoAmt;
            public DecimalField LocalAdjAmt;
            public DecimalField LocalPayAmt;
            public DecimalField LocalDiscAmt;
            public DecimalField LocalDiffAmt;
            public DecimalField LocalBalBeg;
            public DecimalField LocalDebit;
            public DecimalField LocalCredit;
            public DecimalField LocalBalEnd;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public DecimalField RfdAmt;
            public DecimalField LocalRfdAmt;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsReceivableLedger";
            }
        }
    }
}
