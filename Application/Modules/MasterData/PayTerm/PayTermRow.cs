#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PayTermRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBTERM]")]
    [DisplayName("Pay Term"), InstanceName("Pay Term"), TwoLevelCached]   
    public sealed class PayTermRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PAY_TERMS"), Size(6), PrimaryKey, QuickSearch]
        public String PayTerms
        {
            get { return Fields.PayTerms[this]; }
            set { Fields.PayTerms[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(80)]
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

        [DisplayName("Base Date"), Column("BASE_DATE"), Size(1)]
        public String BaseDate
        {
            get { return Fields.BaseDate[this]; }
            set { Fields.BaseDate[this] = value; }
        }

        [DisplayName("Due Days"), Column("DUE_DAYS"), Size(4)]
        public Decimal? DueDays
        {
            get { return Fields.DueDays[this]; }
            set { Fields.DueDays[this] = value; }
        }

        [DisplayName("Disc Days"), Column("DISC_DAYS"), Size(4)]
        public Decimal? DiscDays
        {
            get { return Fields.DiscDays[this]; }
            set { Fields.DiscDays[this] = value; }
        }

        [DisplayName("Disc Percent"), Column("DISC_PERCENT"), Size(6), Scale(2)]
        public Decimal? DiscPercent
        {
            get { return Fields.DiscPercent[this]; }
            set { Fields.DiscPercent[this] = value; }
        }

        [DisplayName("Adjust Crlimit"), Column("ADJUST_CRLIMIT"), Size(1)]
        public String AdjustCrlimit
        {
            get { return Fields.AdjustCrlimit[this]; }
            set { Fields.AdjustCrlimit[this] = value; }
        }

        [DisplayName("Min Due Days"), Column("MIN_DUE_DAYS"), Size(4)]
        public Decimal? MinDueDays
        {
            get { return Fields.MinDueDays[this]; }
            set { Fields.MinDueDays[this] = value; }
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

        [DisplayName("Pay Terms"), Column("PHASE1_PAY_TERMS"), Size(6)]
        public String Phase1PayTerms
        {
            get { return Fields.Phase1PayTerms[this]; }
            set { Fields.Phase1PayTerms[this] = value; }
        }

        [DisplayName("Base Date"), Column("PHASE1_BASE_DATE"), Size(1)]
        public String Phase1BaseDate
        {
            get { return Fields.Phase1BaseDate[this]; }
            set { Fields.Phase1BaseDate[this] = value; }
        }

        [DisplayName("Due Days"), Column("PHASE1_DUE_DAYS"), Size(4)]
        public Decimal? Phase1DueDays
        {
            get { return Fields.Phase1DueDays[this]; }
            set { Fields.Phase1DueDays[this] = value; }
        }

        [DisplayName("Pay Percent"), Column("PHASE1_PAY_PERCENT"), Size(6), Scale(2)]
        public Decimal? Phase1PayPercent
        {
            get { return Fields.Phase1PayPercent[this]; }
            set { Fields.Phase1PayPercent[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PHASE2_PAY_TERMS"), Size(6)]
        public String Phase2PayTerms
        {
            get { return Fields.Phase2PayTerms[this]; }
            set { Fields.Phase2PayTerms[this] = value; }
        }

        [DisplayName("Base Date"), Column("PHASE2_BASE_DATE"), Size(1)]
        public String Phase2BaseDate
        {
            get { return Fields.Phase2BaseDate[this]; }
            set { Fields.Phase2BaseDate[this] = value; }
        }

        [DisplayName("Due Days"), Column("PHASE2_DUE_DAYS"), Size(4)]
        public Decimal? Phase2DueDays
        {
            get { return Fields.Phase2DueDays[this]; }
            set { Fields.Phase2DueDays[this] = value; }
        }

        [DisplayName("Pay Percent"), Column("PHASE2_PAY_PERCENT"), Size(6), Scale(2)]
        public Decimal? Phase2PayPercent
        {
            get { return Fields.Phase2PayPercent[this]; }
            set { Fields.Phase2PayPercent[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PHASE3_PAY_TERMS"), Size(6)]
        public String Phase3PayTerms
        {
            get { return Fields.Phase3PayTerms[this]; }
            set { Fields.Phase3PayTerms[this] = value; }
        }

        [DisplayName("Base Date"), Column("PHASE3_BASE_DATE"), Size(1)]
        public String Phase3BaseDate
        {
            get { return Fields.Phase3BaseDate[this]; }
            set { Fields.Phase3BaseDate[this] = value; }
        }

        [DisplayName("Due Days"), Column("PHASE3_DUE_DAYS"), Size(4)]
        public Decimal? Phase3DueDays
        {
            get { return Fields.Phase3DueDays[this]; }
            set { Fields.Phase3DueDays[this] = value; }
        }

        [DisplayName("Pay Percent"), Column("PHASE3_PAY_PERCENT"), Size(6), Scale(2)]
        public Decimal? Phase3PayPercent
        {
            get { return Fields.Phase3PayPercent[this]; }
            set { Fields.Phase3PayPercent[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PHASE4_PAY_TERMS"), Size(6)]
        public String Phase4PayTerms
        {
            get { return Fields.Phase4PayTerms[this]; }
            set { Fields.Phase4PayTerms[this] = value; }
        }

        [DisplayName("Base Date"), Column("PHASE4_BASE_DATE"), Size(1)]
        public String Phase4BaseDate
        {
            get { return Fields.Phase4BaseDate[this]; }
            set { Fields.Phase4BaseDate[this] = value; }
        }

        [DisplayName("Due Days"), Column("PHASE4_DUE_DAYS"), Size(4)]
        public Decimal? Phase4DueDays
        {
            get { return Fields.Phase4DueDays[this]; }
            set { Fields.Phase4DueDays[this] = value; }
        }

        [DisplayName("Pay Percent"), Column("PHASE4_PAY_PERCENT"), Size(6), Scale(2)]
        public Decimal? Phase4PayPercent
        {
            get { return Fields.Phase4PayPercent[this]; }
            set { Fields.Phase4PayPercent[this] = value; }
        }

        [DisplayName("Pay Terms"), Column("PHASE5_PAY_TERMS"), Size(6)]
        public String Phase5PayTerms
        {
            get { return Fields.Phase5PayTerms[this]; }
            set { Fields.Phase5PayTerms[this] = value; }
        }

        [DisplayName("Base Date"), Column("PHASE5_BASE_DATE"), Size(1)]
        public String Phase5BaseDate
        {
            get { return Fields.Phase5BaseDate[this]; }
            set { Fields.Phase5BaseDate[this] = value; }
        }

        [DisplayName("Due Days"), Column("PHASE5_DUE_DAYS"), Size(4)]
        public Decimal? Phase5DueDays
        {
            get { return Fields.Phase5DueDays[this]; }
            set { Fields.Phase5DueDays[this] = value; }
        }

        [DisplayName("Pay Percent"), Column("PHASE5_PAY_PERCENT"), Size(6), Scale(2)]
        public Decimal? Phase5PayPercent
        {
            get { return Fields.Phase5PayPercent[this]; }
            set { Fields.Phase5PayPercent[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.PayTerms; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PayTermRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField PayTerms;
            public StringField Description;
            public BooleanField Suspended;
            public StringField BaseDate;
            public DecimalField DueDays;
            public DecimalField DiscDays;
            public DecimalField DiscPercent;
            public StringField AdjustCrlimit;
            public DecimalField MinDueDays;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Phase1PayTerms;
            public StringField Phase1BaseDate;
            public DecimalField Phase1DueDays;
            public DecimalField Phase1PayPercent;
            public StringField Phase2PayTerms;
            public StringField Phase2BaseDate;
            public DecimalField Phase2DueDays;
            public DecimalField Phase2PayPercent;
            public StringField Phase3PayTerms;
            public StringField Phase3BaseDate;
            public DecimalField Phase3DueDays;
            public DecimalField Phase3PayPercent;
            public StringField Phase4PayTerms;
            public StringField Phase4BaseDate;
            public DecimalField Phase4DueDays;
            public DecimalField Phase4PayPercent;
            public StringField Phase5PayTerms;
            public StringField Phase5BaseDate;
            public DecimalField Phase5DueDays;
            public DecimalField Phase5PayPercent;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.PayTerm";
            }
        }
    }
}
