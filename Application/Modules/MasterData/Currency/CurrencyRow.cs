#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CurrencyRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;
using Matrix.MasterData.Entities;

namespace Matrix.Enterprise.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Enterprise"), TableName("[dbo].[GBCURR]")]
    [DisplayName("Currency"), InstanceName("Currency"), TwoLevelCached]
    public sealed class CurrencyRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ccy"), Column("CCY"), Size(4), PrimaryKey, QuickSearch]
        public String Ccy
        {
            get { return Fields.Ccy[this]; }
            set { Fields.Ccy[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Default Rate"), Column("DEFAULT_RATE"), Size(12), Scale(6)]
        public Decimal? DefaultRate
        {
            get { return Fields.DefaultRate[this]; }
            set { Fields.DefaultRate[this] = value; }
        }

        [DisplayName("Acct Ar Forex"), Column("ACCT_AR_FOREX"), Size(30)]
        public String AcctArForex
        {
            get { return Fields.AcctArForex[this]; }
            set { Fields.AcctArForex[this] = value; }
        }

        [DisplayName("Acct Ap Forex"), Column("ACCT_AP_FOREX"), Size(30)]
        public String AcctApForex
        {
            get { return Fields.AcctApForex[this]; }
            set { Fields.AcctApForex[this] = value; }
        }

        [DisplayName("Last Entry No"), Column("LAST_ENTRY_NO"), Size(8)]
        public Decimal? LastEntryNo
        {
            get { return Fields.LastEntryNo[this]; }
            set { Fields.LastEntryNo[this] = value; }
        }

        [DisplayName("Rate Use Count"), Column("RATE_USE_COUNT"), Size(8)]
        public Decimal? RateUseCount
        {
            get { return Fields.RateUseCount[this]; }
            set { Fields.RateUseCount[this] = value; }
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

        [DisplayName("Arevised Date"), Column("AREVISED_DATE")]
        public DateTime? ArevisedDate
        {
            get { return Fields.ArevisedDate[this]; }
            set { Fields.ArevisedDate[this] = value; }
        }

        [DisplayName("Arevised By"), Column("AREVISED_BY"), Size(10)]
        public String ArevisedBy
        {
            get { return Fields.ArevisedBy[this]; }
            set { Fields.ArevisedBy[this] = value; }
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

        [DisplayName("Ap Invo Bal"), Column("AP_INVO_BAL"), Size(16), Scale(2)]
        public Decimal? ApInvoBal
        {
            get { return Fields.ApInvoBal[this]; }
            set { Fields.ApInvoBal[this] = value; }
        }

        [DisplayName("Ap Open Bal"), Column("AP_OPEN_BAL"), Size(16), Scale(2)]
        public Decimal? ApOpenBal
        {
            get { return Fields.ApOpenBal[this]; }
            set { Fields.ApOpenBal[this] = value; }
        }

        [DisplayName("Ap Net Bal"), Column("AP_NET_BAL"), Size(16), Scale(2)]
        public Decimal? ApNetBal
        {
            get { return Fields.ApNetBal[this]; }
            set { Fields.ApNetBal[this] = value; }
        }

        [DisplayName("Ap Linvo Bal"), Column("AP_LINVO_BAL"), Size(16), Scale(2)]
        public Decimal? ApLinvoBal
        {
            get { return Fields.ApLinvoBal[this]; }
            set { Fields.ApLinvoBal[this] = value; }
        }

        [DisplayName("Ap Lopen Bal"), Column("AP_LOPEN_BAL"), Size(16), Scale(2)]
        public Decimal? ApLopenBal
        {
            get { return Fields.ApLopenBal[this]; }
            set { Fields.ApLopenBal[this] = value; }
        }

        [DisplayName("Ap Lnet Bal"), Column("AP_LNET_BAL"), Size(16), Scale(2)]
        public Decimal? ApLnetBal
        {
            get { return Fields.ApLnetBal[this]; }
            set { Fields.ApLnetBal[this] = value; }
        }

        [DisplayName("Ar Invo Bal"), Column("AR_INVO_BAL"), Size(16), Scale(2)]
        public Decimal? ArInvoBal
        {
            get { return Fields.ArInvoBal[this]; }
            set { Fields.ArInvoBal[this] = value; }
        }

        [DisplayName("Ar Open Bal"), Column("AR_OPEN_BAL"), Size(16), Scale(2)]
        public Decimal? ArOpenBal
        {
            get { return Fields.ArOpenBal[this]; }
            set { Fields.ArOpenBal[this] = value; }
        }

        [DisplayName("Ar Net Bal"), Column("AR_NET_BAL"), Size(16), Scale(2)]
        public Decimal? ArNetBal
        {
            get { return Fields.ArNetBal[this]; }
            set { Fields.ArNetBal[this] = value; }
        }

        [DisplayName("Ar Linvo Bal"), Column("AR_LINVO_BAL"), Size(16), Scale(2)]
        public Decimal? ArLinvoBal
        {
            get { return Fields.ArLinvoBal[this]; }
            set { Fields.ArLinvoBal[this] = value; }
        }

        [DisplayName("Ar Lopen Bal"), Column("AR_LOPEN_BAL"), Size(16), Scale(2)]
        public Decimal? ArLopenBal
        {
            get { return Fields.ArLopenBal[this]; }
            set { Fields.ArLopenBal[this] = value; }
        }

        [DisplayName("Ar Lnet Bal"), Column("AR_LNET_BAL"), Size(16), Scale(2)]
        public Decimal? ArLnetBal
        {
            get { return Fields.ArLnetBal[this]; }
            set { Fields.ArLnetBal[this] = value; }
        }

        [MasterDetailRelation(foreignKey: "Ccy")]
        [DisplayName("Detail List"), NotMapped]
        public List<ExchangeRateRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }
        
        IIdField IIdRow.IdField
        {
            get { return Fields.Ccy; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CurrencyRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Ccy;
            public StringField Description;
            public BooleanField Suspended;
            public DecimalField DefaultRate;
            public StringField AcctArForex;
            public StringField AcctApForex;
            public DecimalField LastEntryNo;
            public DecimalField RateUseCount;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField ArevisedDate;
            public StringField ArevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public DecimalField ApInvoBal;
            public DecimalField ApOpenBal;
            public DecimalField ApNetBal;
            public DecimalField ApLinvoBal;
            public DecimalField ApLopenBal;
            public DecimalField ApLnetBal;
            public DecimalField ArInvoBal;
            public DecimalField ArOpenBal;
            public DecimalField ArNetBal;
            public DecimalField ArLinvoBal;
            public DecimalField ArLopenBal;
            public DecimalField ArLnetBal;

            public RowListField<ExchangeRateRow> DetailList;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Enterprise.Currency";
            }
        }
    }
}
