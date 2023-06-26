#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ExchangeRateRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBRATE]")]
    [DisplayName("Exchange Rate"), InstanceName("Exchange Rate"), TwoLevelCached]   
    public sealed class ExchangeRateRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4), PrimaryKey, ForeignKey("[dbo].[GBCURR]", "CCY"), LeftJoin("jCcy"), QuickSearch, TextualField("CcyDescription")]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Entry No"), Column("ENTRY_NO"), Size(6), PrimaryKey]
        public Decimal? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("From Date"), Column("FROM_DATE"), NotNull]
        public DateTime? FromDate
        {
            get { return Fields.FromDate[this]; }
            set { Fields.FromDate[this] = value; }
        }

        [DisplayName("To Date"), Column("TO_DATE")]
        public DateTime? ToDate
        {
            get { return Fields.ToDate[this]; }
            set { Fields.ToDate[this] = value; }
        }

        [DisplayName("Exch Rate"), Column("EXCH_RATE"), Size(12), Scale(6)]
        public Decimal? ExchRate
        {
            get { return Fields.ExchRate[this]; }
            set { Fields.ExchRate[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
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

        [DisplayName("Ccy Recnum"), Expression("jCcy.[RECNUM]")]
        public Decimal? CcyRecnum
        {
            get { return Fields.CcyRecnum[this]; }
            set { Fields.CcyRecnum[this] = value; }
        }

        [DisplayName("Ccy Description"), Expression("jCcy.[DESCRIPTION]")]
        public String CcyDescription
        {
            get { return Fields.CcyDescription[this]; }
            set { Fields.CcyDescription[this] = value; }
        }

        [DisplayName("Ccy Suspended"), Expression("jCcy.[SUSPENDED]")]
        public String CcySuspended
        {
            get { return Fields.CcySuspended[this]; }
            set { Fields.CcySuspended[this] = value; }
        }

        [DisplayName("Ccy Default Rate"), Expression("jCcy.[DEFAULT_RATE]")]
        public Decimal? CcyDefaultRate
        {
            get { return Fields.CcyDefaultRate[this]; }
            set { Fields.CcyDefaultRate[this] = value; }
        }

        [DisplayName("Ccy Acct Ar Forex"), Expression("jCcy.[ACCT_AR_FOREX]")]
        public String CcyAcctArForex
        {
            get { return Fields.CcyAcctArForex[this]; }
            set { Fields.CcyAcctArForex[this] = value; }
        }

        [DisplayName("Ccy Acct Ap Forex"), Expression("jCcy.[ACCT_AP_FOREX]")]
        public String CcyAcctApForex
        {
            get { return Fields.CcyAcctApForex[this]; }
            set { Fields.CcyAcctApForex[this] = value; }
        }

        [DisplayName("Ccy Last Entry No"), Expression("jCcy.[LAST_ENTRY_NO]")]
        public Decimal? CcyLastEntryNo
        {
            get { return Fields.CcyLastEntryNo[this]; }
            set { Fields.CcyLastEntryNo[this] = value; }
        }

        [DisplayName("Ccy Rate Use Count"), Expression("jCcy.[RATE_USE_COUNT]")]
        public Decimal? CcyRateUseCount
        {
            get { return Fields.CcyRateUseCount[this]; }
            set { Fields.CcyRateUseCount[this] = value; }
        }

        [DisplayName("Ccy Created Date"), Expression("jCcy.[CREATED_DATE]")]
        public DateTime? CcyCreatedDate
        {
            get { return Fields.CcyCreatedDate[this]; }
            set { Fields.CcyCreatedDate[this] = value; }
        }

        [DisplayName("Ccy Created By"), Expression("jCcy.[CREATED_BY]")]
        public String CcyCreatedBy
        {
            get { return Fields.CcyCreatedBy[this]; }
            set { Fields.CcyCreatedBy[this] = value; }
        }

        [DisplayName("Ccy Revised Date"), Expression("jCcy.[REVISED_DATE]")]
        public DateTime? CcyRevisedDate
        {
            get { return Fields.CcyRevisedDate[this]; }
            set { Fields.CcyRevisedDate[this] = value; }
        }

        [DisplayName("Ccy Revised By"), Expression("jCcy.[REVISED_BY]")]
        public String CcyRevisedBy
        {
            get { return Fields.CcyRevisedBy[this]; }
            set { Fields.CcyRevisedBy[this] = value; }
        }

        [DisplayName("Ccy Arevised Date"), Expression("jCcy.[AREVISED_DATE]")]
        public DateTime? CcyArevisedDate
        {
            get { return Fields.CcyArevisedDate[this]; }
            set { Fields.CcyArevisedDate[this] = value; }
        }

        [DisplayName("Ccy Arevised By"), Expression("jCcy.[AREVISED_BY]")]
        public String CcyArevisedBy
        {
            get { return Fields.CcyArevisedBy[this]; }
            set { Fields.CcyArevisedBy[this] = value; }
        }

        [DisplayName("Ccy Owner Branch"), Expression("jCcy.[OWNER_BRANCH]")]
        public String CcyOwnerBranch
        {
            get { return Fields.CcyOwnerBranch[this]; }
            set { Fields.CcyOwnerBranch[this] = value; }
        }

        [DisplayName("Ccy Source Branch"), Expression("jCcy.[SOURCE_BRANCH]")]
        public String CcySourceBranch
        {
            get { return Fields.CcySourceBranch[this]; }
            set { Fields.CcySourceBranch[this] = value; }
        }

        [DisplayName("Ccy Ap Invo Bal"), Expression("jCcy.[AP_INVO_BAL]")]
        public Decimal? CcyApInvoBal
        {
            get { return Fields.CcyApInvoBal[this]; }
            set { Fields.CcyApInvoBal[this] = value; }
        }

        [DisplayName("Ccy Ap Open Bal"), Expression("jCcy.[AP_OPEN_BAL]")]
        public Decimal? CcyApOpenBal
        {
            get { return Fields.CcyApOpenBal[this]; }
            set { Fields.CcyApOpenBal[this] = value; }
        }

        [DisplayName("Ccy Ap Net Bal"), Expression("jCcy.[AP_NET_BAL]")]
        public Decimal? CcyApNetBal
        {
            get { return Fields.CcyApNetBal[this]; }
            set { Fields.CcyApNetBal[this] = value; }
        }

        [DisplayName("Ccy Ap Linvo Bal"), Expression("jCcy.[AP_LINVO_BAL]")]
        public Decimal? CcyApLinvoBal
        {
            get { return Fields.CcyApLinvoBal[this]; }
            set { Fields.CcyApLinvoBal[this] = value; }
        }

        [DisplayName("Ccy Ap Lopen Bal"), Expression("jCcy.[AP_LOPEN_BAL]")]
        public Decimal? CcyApLopenBal
        {
            get { return Fields.CcyApLopenBal[this]; }
            set { Fields.CcyApLopenBal[this] = value; }
        }

        [DisplayName("Ccy Ap Lnet Bal"), Expression("jCcy.[AP_LNET_BAL]")]
        public Decimal? CcyApLnetBal
        {
            get { return Fields.CcyApLnetBal[this]; }
            set { Fields.CcyApLnetBal[this] = value; }
        }

        [DisplayName("Ccy Ar Invo Bal"), Expression("jCcy.[AR_INVO_BAL]")]
        public Decimal? CcyArInvoBal
        {
            get { return Fields.CcyArInvoBal[this]; }
            set { Fields.CcyArInvoBal[this] = value; }
        }

        [DisplayName("Ccy Ar Open Bal"), Expression("jCcy.[AR_OPEN_BAL]")]
        public Decimal? CcyArOpenBal
        {
            get { return Fields.CcyArOpenBal[this]; }
            set { Fields.CcyArOpenBal[this] = value; }
        }

        [DisplayName("Ccy Ar Net Bal"), Expression("jCcy.[AR_NET_BAL]")]
        public Decimal? CcyArNetBal
        {
            get { return Fields.CcyArNetBal[this]; }
            set { Fields.CcyArNetBal[this] = value; }
        }

        [DisplayName("Ccy Ar Linvo Bal"), Expression("jCcy.[AR_LINVO_BAL]")]
        public Decimal? CcyArLinvoBal
        {
            get { return Fields.CcyArLinvoBal[this]; }
            set { Fields.CcyArLinvoBal[this] = value; }
        }

        [DisplayName("Ccy Ar Lopen Bal"), Expression("jCcy.[AR_LOPEN_BAL]")]
        public Decimal? CcyArLopenBal
        {
            get { return Fields.CcyArLopenBal[this]; }
            set { Fields.CcyArLopenBal[this] = value; }
        }

        [DisplayName("Ccy Ar Lnet Bal"), Expression("jCcy.[AR_LNET_BAL]")]
        public Decimal? CcyArLnetBal
        {
            get { return Fields.CcyArLnetBal[this]; }
            set { Fields.CcyArLnetBal[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Ccy; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ExchangeRateRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Ccy;
            public DecimalField EntryNo;
            public DateTimeField FromDate;
            public DateTimeField ToDate;
            public DecimalField ExchRate;
            public BooleanField Suspended;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public DecimalField CcyRecnum;
            public StringField CcyDescription;
            public StringField CcySuspended;
            public DecimalField CcyDefaultRate;
            public StringField CcyAcctArForex;
            public StringField CcyAcctApForex;
            public DecimalField CcyLastEntryNo;
            public DecimalField CcyRateUseCount;
            public DateTimeField CcyCreatedDate;
            public StringField CcyCreatedBy;
            public DateTimeField CcyRevisedDate;
            public StringField CcyRevisedBy;
            public DateTimeField CcyArevisedDate;
            public StringField CcyArevisedBy;
            public StringField CcyOwnerBranch;
            public StringField CcySourceBranch;
            public DecimalField CcyApInvoBal;
            public DecimalField CcyApOpenBal;
            public DecimalField CcyApNetBal;
            public DecimalField CcyApLinvoBal;
            public DecimalField CcyApLopenBal;
            public DecimalField CcyApLnetBal;
            public DecimalField CcyArInvoBal;
            public DecimalField CcyArOpenBal;
            public DecimalField CcyArNetBal;
            public DecimalField CcyArLinvoBal;
            public DecimalField CcyArLopenBal;
            public DecimalField CcyArLnetBal;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.ExchangeRate";
            }
        }
    }
}
