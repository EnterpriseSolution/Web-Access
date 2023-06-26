#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PeriodicVoucherScheduleRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLPERS]")]
    [DisplayName("Periodic Voucher Schedule"), InstanceName("Periodic Voucher Schedule"), TwoLevelCached]   
    public sealed class PeriodicVoucherScheduleRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Entry Key"), Column("ENTRY_KEY"), Size(6), PrimaryKey, ForeignKey("[dbo].[GLPERH]", "ENTRY_KEY"), LeftJoin("jEntryKey"), QuickSearch, TextualField("EntryKeyDescription")]
        public String EntryKey
        {
            get { return Fields.EntryKey[this]; }
            set { Fields.EntryKey[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), PrimaryKey]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Voucher No"), Column("VOUCHER_NO"), Size(16)]
        public String VoucherNo
        {
            get { return Fields.VoucherNo[this]; }
            set { Fields.VoucherNo[this] = value; }
        }

        [DisplayName("Voucher Date"), Column("VOUCHER_DATE")]
        public DateTime? VoucherDate
        {
            get { return Fields.VoucherDate[this]; }
            set { Fields.VoucherDate[this] = value; }
        }

        [DisplayName("Exch Rate"), Column("EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? ExchRate
        {
            get { return Fields.ExchRate[this]; }
            set { Fields.ExchRate[this] = value; }
        }

        [DisplayName("Debit Total"), Column("DEBIT_TOTAL"), Size(16), Scale(2)]
        public Decimal? DebitTotal
        {
            get { return Fields.DebitTotal[this]; }
            set { Fields.DebitTotal[this] = value; }
        }

        [DisplayName("Credit Total"), Column("CREDIT_TOTAL"), Size(16), Scale(2)]
        public Decimal? CreditTotal
        {
            get { return Fields.CreditTotal[this]; }
            set { Fields.CreditTotal[this] = value; }
        }

        [DisplayName("Source Date"), Column("SOURCE_DATE")]
        public DateTime? SourceDate
        {
            get { return Fields.SourceDate[this]; }
            set { Fields.SourceDate[this] = value; }
        }

        [DisplayName("Source By"), Column("SOURCE_BY"), Size(10)]
        public String SourceBy
        {
            get { return Fields.SourceBy[this]; }
            set { Fields.SourceBy[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
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

        [DisplayName("Entry Key Recnum"), Expression("jEntryKey.[RECNUM]")]
        public Decimal? EntryKeyRecnum
        {
            get { return Fields.EntryKeyRecnum[this]; }
            set { Fields.EntryKeyRecnum[this] = value; }
        }

        [DisplayName("Entry Key Description"), Expression("jEntryKey.[DESCRIPTION]")]
        public String EntryKeyDescription
        {
            get { return Fields.EntryKeyDescription[this]; }
            set { Fields.EntryKeyDescription[this] = value; }
        }

        [DisplayName("Entry Key Voucher Type"), Expression("jEntryKey.[VOUCHER_TYPE]")]
        public String EntryKeyVoucherType
        {
            get { return Fields.EntryKeyVoucherType[this]; }
            set { Fields.EntryKeyVoucherType[this] = value; }
        }

        [DisplayName("Entry Key Series Code"), Expression("jEntryKey.[SERIES_CODE]")]
        public String EntryKeySeriesCode
        {
            get { return Fields.EntryKeySeriesCode[this]; }
            set { Fields.EntryKeySeriesCode[this] = value; }
        }

        [DisplayName("Entry Key Ccy"), Expression("jEntryKey.[CCY]")]
        public String EntryKeyCcy
        {
            get { return Fields.EntryKeyCcy[this]; }
            set { Fields.EntryKeyCcy[this] = value; }
        }

        [DisplayName("Entry Key Suspended"), Expression("jEntryKey.[SUSPENDED]")]
        public String EntryKeySuspended
        {
            get { return Fields.EntryKeySuspended[this]; }
            set { Fields.EntryKeySuspended[this] = value; }
        }

        [DisplayName("Entry Key Effective From"), Expression("jEntryKey.[EFFECTIVE_FROM]")]
        public DateTime? EntryKeyEffectiveFrom
        {
            get { return Fields.EntryKeyEffectiveFrom[this]; }
            set { Fields.EntryKeyEffectiveFrom[this] = value; }
        }

        [DisplayName("Entry Key Effective To"), Expression("jEntryKey.[EFFECTIVE_TO]")]
        public DateTime? EntryKeyEffectiveTo
        {
            get { return Fields.EntryKeyEffectiveTo[this]; }
            set { Fields.EntryKeyEffectiveTo[this] = value; }
        }

        [DisplayName("Entry Key Last Line No"), Expression("jEntryKey.[LAST_LINE_NO]")]
        public Decimal? EntryKeyLastLineNo
        {
            get { return Fields.EntryKeyLastLineNo[this]; }
            set { Fields.EntryKeyLastLineNo[this] = value; }
        }

        [DisplayName("Entry Key Created Date"), Expression("jEntryKey.[CREATED_DATE]")]
        public DateTime? EntryKeyCreatedDate
        {
            get { return Fields.EntryKeyCreatedDate[this]; }
            set { Fields.EntryKeyCreatedDate[this] = value; }
        }

        [DisplayName("Entry Key Created By"), Expression("jEntryKey.[CREATED_BY]")]
        public String EntryKeyCreatedBy
        {
            get { return Fields.EntryKeyCreatedBy[this]; }
            set { Fields.EntryKeyCreatedBy[this] = value; }
        }

        [DisplayName("Entry Key Revised Date"), Expression("jEntryKey.[REVISED_DATE]")]
        public DateTime? EntryKeyRevisedDate
        {
            get { return Fields.EntryKeyRevisedDate[this]; }
            set { Fields.EntryKeyRevisedDate[this] = value; }
        }

        [DisplayName("Entry Key Revised By"), Expression("jEntryKey.[REVISED_BY]")]
        public String EntryKeyRevisedBy
        {
            get { return Fields.EntryKeyRevisedBy[this]; }
            set { Fields.EntryKeyRevisedBy[this] = value; }
        }

        [DisplayName("Entry Key Owner Branch"), Expression("jEntryKey.[OWNER_BRANCH]")]
        public String EntryKeyOwnerBranch
        {
            get { return Fields.EntryKeyOwnerBranch[this]; }
            set { Fields.EntryKeyOwnerBranch[this] = value; }
        }

        [DisplayName("Entry Key Source Branch"), Expression("jEntryKey.[SOURCE_BRANCH]")]
        public String EntryKeySourceBranch
        {
            get { return Fields.EntryKeySourceBranch[this]; }
            set { Fields.EntryKeySourceBranch[this] = value; }
        }

        [DisplayName("Entry Key Anlys1"), Expression("jEntryKey.[ANLYS1]")]
        public String EntryKeyAnlys1
        {
            get { return Fields.EntryKeyAnlys1[this]; }
            set { Fields.EntryKeyAnlys1[this] = value; }
        }

        [DisplayName("Entry Key Anlys2"), Expression("jEntryKey.[ANLYS2]")]
        public String EntryKeyAnlys2
        {
            get { return Fields.EntryKeyAnlys2[this]; }
            set { Fields.EntryKeyAnlys2[this] = value; }
        }

        [DisplayName("Entry Key Reference"), Expression("jEntryKey.[REFERENCE]")]
        public String EntryKeyReference
        {
            get { return Fields.EntryKeyReference[this]; }
            set { Fields.EntryKeyReference[this] = value; }
        }

        [DisplayName("Entry Key Total Debit"), Expression("jEntryKey.[TOTAL_DEBIT]")]
        public Decimal? EntryKeyTotalDebit
        {
            get { return Fields.EntryKeyTotalDebit[this]; }
            set { Fields.EntryKeyTotalDebit[this] = value; }
        }

        [DisplayName("Entry Key Total Credit"), Expression("jEntryKey.[TOTAL_CREDIT]")]
        public Decimal? EntryKeyTotalCredit
        {
            get { return Fields.EntryKeyTotalCredit[this]; }
            set { Fields.EntryKeyTotalCredit[this] = value; }
        }

        [DisplayName("Entry Key Particulars"), Expression("jEntryKey.[PARTICULARS]")]
        public String EntryKeyParticulars
        {
            get { return Fields.EntryKeyParticulars[this]; }
            set { Fields.EntryKeyParticulars[this] = value; }
        }

        [DisplayName("Entry Key Anlys7"), Expression("jEntryKey.[ANLYS7]")]
        public String EntryKeyAnlys7
        {
            get { return Fields.EntryKeyAnlys7[this]; }
            set { Fields.EntryKeyAnlys7[this] = value; }
        }

        [DisplayName("Entry Key Anlys8"), Expression("jEntryKey.[ANLYS8]")]
        public String EntryKeyAnlys8
        {
            get { return Fields.EntryKeyAnlys8[this]; }
            set { Fields.EntryKeyAnlys8[this] = value; }
        }

        [DisplayName("Entry Key Anlys9"), Expression("jEntryKey.[ANLYS9]")]
        public String EntryKeyAnlys9
        {
            get { return Fields.EntryKeyAnlys9[this]; }
            set { Fields.EntryKeyAnlys9[this] = value; }
        }

        [DisplayName("Entry Key Anlys10"), Expression("jEntryKey.[ANLYS10]")]
        public String EntryKeyAnlys10
        {
            get { return Fields.EntryKeyAnlys10[this]; }
            set { Fields.EntryKeyAnlys10[this] = value; }
        }

        [DisplayName("Entry Key Anlys11"), Expression("jEntryKey.[ANLYS11]")]
        public String EntryKeyAnlys11
        {
            get { return Fields.EntryKeyAnlys11[this]; }
            set { Fields.EntryKeyAnlys11[this] = value; }
        }

        [DisplayName("Entry Key Anlys12"), Expression("jEntryKey.[ANLYS12]")]
        public String EntryKeyAnlys12
        {
            get { return Fields.EntryKeyAnlys12[this]; }
            set { Fields.EntryKeyAnlys12[this] = value; }
        }

        [DisplayName("Entry Key Anlys13"), Expression("jEntryKey.[ANLYS13]")]
        public String EntryKeyAnlys13
        {
            get { return Fields.EntryKeyAnlys13[this]; }
            set { Fields.EntryKeyAnlys13[this] = value; }
        }

        [DisplayName("Entry Key Anlys14"), Expression("jEntryKey.[ANLYS14]")]
        public String EntryKeyAnlys14
        {
            get { return Fields.EntryKeyAnlys14[this]; }
            set { Fields.EntryKeyAnlys14[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.EntryKey; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PeriodicVoucherScheduleRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField EntryKey;
            public StringField Period;
            public StringField Suspended;
            public StringField VoucherNo;
            public DateTimeField VoucherDate;
            public DecimalField ExchRate;
            public DecimalField DebitTotal;
            public DecimalField CreditTotal;
            public DateTimeField SourceDate;
            public StringField SourceBy;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;

            public DecimalField EntryKeyRecnum;
            public StringField EntryKeyDescription;
            public StringField EntryKeyVoucherType;
            public StringField EntryKeySeriesCode;
            public StringField EntryKeyCcy;
            public StringField EntryKeySuspended;
            public DateTimeField EntryKeyEffectiveFrom;
            public DateTimeField EntryKeyEffectiveTo;
            public DecimalField EntryKeyLastLineNo;
            public DateTimeField EntryKeyCreatedDate;
            public StringField EntryKeyCreatedBy;
            public DateTimeField EntryKeyRevisedDate;
            public StringField EntryKeyRevisedBy;
            public StringField EntryKeyOwnerBranch;
            public StringField EntryKeySourceBranch;
            public StringField EntryKeyAnlys1;
            public StringField EntryKeyAnlys2;
            public StringField EntryKeyReference;
            public DecimalField EntryKeyTotalDebit;
            public DecimalField EntryKeyTotalCredit;
            public StringField EntryKeyParticulars;
            public StringField EntryKeyAnlys7;
            public StringField EntryKeyAnlys8;
            public StringField EntryKeyAnlys9;
            public StringField EntryKeyAnlys10;
            public StringField EntryKeyAnlys11;
            public StringField EntryKeyAnlys12;
            public StringField EntryKeyAnlys13;
            public StringField EntryKeyAnlys14;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.PeriodicVoucherSchedule";
            }
        }
    }
}
