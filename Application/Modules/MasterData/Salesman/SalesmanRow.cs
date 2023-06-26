#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesmanRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[SLSMAN]")]
    [DisplayName("Salesman"), InstanceName("Salesman"), TwoLevelCached]   
    public sealed class SalesmanRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Salesman"), Column("SALESMAN"), Size(6), PrimaryKey, QuickSearch]
        public String Salesman
        {
            get { return Fields.Salesman[this]; }
            set { Fields.Salesman[this] = value; }
        }

        [DisplayName("Salesman Name"), Column("SALESMAN_NAME"), Size(40), NotNull]
        public String SalesmanName
        {
            get { return Fields.SalesmanName[this]; }
            set { Fields.SalesmanName[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [BoolStringConverter]
        public bool? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Rank"), Column("RANK"), Size(4)]
        public Decimal? Rank
        {
            get { return Fields.Rank[this]; }
            set { Fields.Rank[this] = value; }
        }

        [DisplayName("Employee No"), Column("EMP_NO"), Size(10)]
        public String EmpNo
        {
            get { return Fields.EmpNo[this]; }
            set { Fields.EmpNo[this] = value; }
        }

        [DisplayName("Supervisor"), Column("SUPERVISOR"), Size(6)]
        public String Supervisor
        {
            get { return Fields.Supervisor[this]; }
            set { Fields.Supervisor[this] = value; }
        }

        [DisplayName("With Backlog"), Column("WITH_BACKLOG"), Size(1), NotNull]
        public String WithBacklog
        {
            get { return Fields.WithBacklog[this]; }
            set { Fields.WithBacklog[this] = value; }
        }

        [DisplayName("On Order Count"), Column("ON_ORDER_COUNT"), Size(6)]
        public Decimal? OnOrderCount
        {
            get { return Fields.OnOrderCount[this]; }
            set { Fields.OnOrderCount[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Salesman; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SalesmanRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Salesman;
            public StringField SalesmanName;
            public BooleanField Suspended;
            public DecimalField Rank;
            public StringField EmpNo;
            public StringField Supervisor;
            public StringField WithBacklog;
            public DecimalField OnOrderCount;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Salesman";
            }
        }
    }
}
