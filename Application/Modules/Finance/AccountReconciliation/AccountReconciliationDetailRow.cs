#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountReconciliationDetailRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLRECD]")]
    [DisplayName("Account Reconciliation Detail"), InstanceName("Account Reconciliation Detail"), TwoLevelCached]   
    public sealed class AccountReconciliationDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Acct No"), Column("ACCT_NO"), Size(30), PrimaryKey, QuickSearch]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(12), PrimaryKey]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Voucher Date"), Column("VOUCHER_DATE"), PrimaryKey]
        public DateTime? VoucherDate
        {
            get { return Fields.VoucherDate[this]; }
            set { Fields.VoucherDate[this] = value; }
        }

        [DisplayName("Journal No"), Column("JOURNAL_NO"), Size(8), PrimaryKey]
        public Decimal? JournalNo
        {
            get { return Fields.JournalNo[this]; }
            set { Fields.JournalNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Voucher Type"), Column("VOUCHER_TYPE"), Size(6)]
        public String VoucherType
        {
            get { return Fields.VoucherType[this]; }
            set { Fields.VoucherType[this] = value; }
        }

        [DisplayName("Voucher No"), Column("VOUCHER_NO"), Size(16)]
        public String VoucherNo
        {
            get { return Fields.VoucherNo[this]; }
            set { Fields.VoucherNo[this] = value; }
        }

        [DisplayName("Reference"), Column("REFERENCE"), Size(30)]
        public String Reference
        {
            get { return Fields.Reference[this]; }
            set { Fields.Reference[this] = value; }
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

        [DisplayName("Ledger Amt"), Column("LEDGER_AMT"), Size(16), Scale(2)]
        public Decimal? LedgerAmt
        {
            get { return Fields.LedgerAmt[this]; }
            set { Fields.LedgerAmt[this] = value; }
        }

        [DisplayName("Sign"), Column("SIGN"), Size(6)]
        public String Sign
        {
            get { return Fields.Sign[this]; }
            set { Fields.Sign[this] = value; }
        }

        [DisplayName("Include This"), Column("INCLUDE_THIS"), Size(1)]
        public String IncludeThis
        {
            get { return Fields.IncludeThis[this]; }
            set { Fields.IncludeThis[this] = value; }
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

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
        public String Particulars
        {
            get { return Fields.Particulars[this]; }
            set { Fields.Particulars[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.AcctNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountReconciliationDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField AcctNo;
            public StringField RefNo;
            public DateTimeField VoucherDate;
            public DecimalField JournalNo;
            public DecimalField LineNo;
            public StringField VoucherType;
            public StringField VoucherNo;
            public StringField Reference;
            public StringField LineRef;
            public StringField Ccy;
            public DecimalField Debit;
            public DecimalField Credit;
            public DecimalField LedgerAmt;
            public StringField Sign;
            public StringField IncludeThis;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountReconciliationDetail";
            }
        }
    }
}
