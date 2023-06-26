#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CalendarRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBCALH]")]
    [DisplayName("Calendar"), InstanceName("Calendar"), TwoLevelCached]   
    public sealed class CalendarRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Tran Month"), Column("TRAN_MONTH"), Size(7), PrimaryKey, QuickSearch]
        public String TranMonth
        {
            get { return Fields.TranMonth[this]; }
            set { Fields.TranMonth[this] = value; }
        }

        [DisplayName("Tran Year"), Column("TRAN_YEAR"), Size(4), NotNull]
        public Decimal? TranYear
        {
            get { return Fields.TranYear[this]; }
            set { Fields.TranYear[this] = value; }
        }

        [DisplayName("Month No"), Column("MONTH_NO"), Size(4), NotNull]
        public Decimal? MonthNo
        {
            get { return Fields.MonthNo[this]; }
            set { Fields.MonthNo[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.TranMonth; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CalendarRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField TranMonth;
            public DecimalField TranYear;
            public DecimalField MonthNo;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Calendar";
            }
        }
    }
}
