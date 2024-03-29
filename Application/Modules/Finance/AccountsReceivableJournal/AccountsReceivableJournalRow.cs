﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableJournalRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[ARJRNL]")]
    [DisplayName("Accounts Receivable Journal"), InstanceName("Accounts Receivable Journal"), TwoLevelCached]   
    public sealed class AccountsReceivableJournalRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Entry No"), Column("ENTRY_NO"), Size(8), PrimaryKey]
        public Decimal? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Customer No"), Column("CUSTOMER_NO"), Size(8), NotNull, QuickSearch]
        public String CustomerNo
        {
            get { return Fields.CustomerNo[this]; }
            set { Fields.CustomerNo[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), NotNull]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Tran Date"), Column("TRAN_DATE"), NotNull]
        public DateTime? TranDate
        {
            get { return Fields.TranDate[this]; }
            set { Fields.TranDate[this] = value; }
        }

        [DisplayName("Tran Type"), Column("TRAN_TYPE"), Size(12)]
        public String TranType
        {
            get { return Fields.TranType[this]; }
            set { Fields.TranType[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16)]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4), NotNull]
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

        [DisplayName("Total Amt"), Column("TOTAL_AMT"), Size(14), Scale(2)]
        public Decimal? TotalAmt
        {
            get { return Fields.TotalAmt[this]; }
            set { Fields.TotalAmt[this] = value; }
        }

        [DisplayName("Debit"), Column("DEBIT"), Size(14), Scale(2)]
        public Decimal? Debit
        {
            get { return Fields.Debit[this]; }
            set { Fields.Debit[this] = value; }
        }

        [DisplayName("Credit"), Column("CREDIT"), Size(14), Scale(2)]
        public Decimal? Credit
        {
            get { return Fields.Credit[this]; }
            set { Fields.Credit[this] = value; }
        }

        [DisplayName("Local Debit"), Column("LOCAL_DEBIT"), Size(14), Scale(2)]
        public Decimal? LocalDebit
        {
            get { return Fields.LocalDebit[this]; }
            set { Fields.LocalDebit[this] = value; }
        }

        [DisplayName("Local Credit"), Column("LOCAL_CREDIT"), Size(14), Scale(2)]
        public Decimal? LocalCredit
        {
            get { return Fields.LocalCredit[this]; }
            set { Fields.LocalCredit[this] = value; }
        }

        [DisplayName("Local Balance"), Column("LOCAL_BALANCE"), Size(14), Scale(2)]
        public Decimal? LocalBalance
        {
            get { return Fields.LocalBalance[this]; }
            set { Fields.LocalBalance[this] = value; }
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

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(40)]
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
            get { return Fields.CustomerNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AccountsReceivableJournalRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public DecimalField EntryNo;
            public StringField CustomerNo;
            public StringField Period;
            public DateTimeField TranDate;
            public StringField TranType;
            public StringField RefNo;
            public StringField Ccy;
            public DecimalField ExchRate;
            public DecimalField TotalAmt;
            public DecimalField Debit;
            public DecimalField Credit;
            public DecimalField LocalDebit;
            public DecimalField LocalCredit;
            public DecimalField LocalBalance;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountsReceivableJournal";
            }
        }
    }
}
