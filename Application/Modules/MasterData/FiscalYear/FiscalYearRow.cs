#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FiscalYearRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Runtime.InteropServices.ComTypes;

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[GBPERH]")]
    [DisplayName("Accounting Periods"), InstanceName("Fiscal Year"), TwoLevelCached]   
    [LookupScript("MasterData.FiscalYearRow")]
    public sealed class FiscalYearRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Fiscal Year"), Column("FISCAL_YEAR"), Size(4), PrimaryKey]
        public Decimal? FiscalYear
        {
            get { return Fields.FiscalYear[this]; }
            set { Fields.FiscalYear[this] = value; }
        }

        [DisplayName("Allow Entries"), Column("ALLOW_ENTRIES"), Size(1), QuickSearch]
        public String AllowEntries
        {
            get { return Fields.AllowEntries[this]; }
            set { Fields.AllowEntries[this] = value; }
        }

        [DisplayName("Closed"), Column("CLOSED"), Size(1)]
        public String Closed
        {
            get { return Fields.Closed[this]; }
            set { Fields.Closed[this] = value; }
        }

        [DisplayName("Last Period"), Column("LAST_PERIOD"), Size(2)]
        public Decimal? LastPeriod
        {
            get { return Fields.LastPeriod[this]; }
            set { Fields.LastPeriod[this] = value; }
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

        [DisplayName("Closed Date"), Column("CLOSED_DATE")]
        public DateTime? ClosedDate
        {
            get { return Fields.ClosedDate[this]; }
            set { Fields.ClosedDate[this] = value; }
        }

        [DisplayName("Closed By"), Column("CLOSED_BY"), Size(10)]
        public String ClosedBy
        {
            get { return Fields.ClosedBy[this]; }
            set { Fields.ClosedBy[this] = value; }
        }

        [DisplayName("Ytd Pl Credit"), Column("YTD_PL_CREDIT"), Size(16), Scale(2)]
        public Decimal? YtdPlCredit
        {
            get { return Fields.YtdPlCredit[this]; }
            set { Fields.YtdPlCredit[this] = value; }
        }

        [DisplayName("Ytd Pl Debit"), Column("YTD_PL_DEBIT"), Size(16), Scale(2)]
        public Decimal? YtdPlDebit
        {
            get { return Fields.YtdPlDebit[this]; }
            set { Fields.YtdPlDebit[this] = value; }
        }

        [DisplayName("Ytd Pl Net"), Column("YTD_PL_NET"), Size(16), Scale(2)]
        public Decimal? YtdPlNet
        {
            get { return Fields.YtdPlNet[this]; }
            set { Fields.YtdPlNet[this] = value; }
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

        [DisplayName("Fiscal Year"),Expression("CAST(t0.FISCAL_YEAR AS nvarchar(8))")]
        public String FiscalYearName
        {
            get { return Fields.FiscalYearName[this]; }
            set { Fields.FiscalYearName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.FiscalYear; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.FiscalYearName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public FiscalYearRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public DecimalField FiscalYear;
            public StringField AllowEntries;
            public StringField Closed;
            public DecimalField LastPeriod;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField ClosedDate;
            public StringField ClosedBy;
            public DecimalField YtdPlCredit;
            public DecimalField YtdPlDebit;
            public DecimalField YtdPlNet;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public readonly StringField FiscalYearName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.FiscalYear";
            }
        }
    }
}
