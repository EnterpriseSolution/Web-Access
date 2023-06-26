#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  DepartmentRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Enterprise"), TableName("[dbo].[GBDEPT]")]
    [DisplayName("Department"), InstanceName("Department"), TwoLevelCached]
    public sealed class DepartmentRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Dept"), Column("DEPT"), Size(4), PrimaryKey, QuickSearch]
        public String Dept
        {
            get { return Fields.Dept[this]; }
            set { Fields.Dept[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        [Serenity.Data.BoolStringConverterAttribute]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Acct Mvt Issue"), Column("ACCT_MVT_ISSUE"), Size(30)]
        public String AcctMvtIssue
        {
            get { return Fields.AcctMvtIssue[this]; }
            set { Fields.AcctMvtIssue[this] = value; }
        }

        [DisplayName("Acct Mvt Rcpt"), Column("ACCT_MVT_RCPT"), Size(30)]
        public String AcctMvtRcpt
        {
            get { return Fields.AcctMvtRcpt[this]; }
            set { Fields.AcctMvtRcpt[this] = value; }
        }

        [DisplayName("Acct Pur Misc"), Column("ACCT_PUR_MISC"), Size(30)]
        public String AcctPurMisc
        {
            get { return Fields.AcctPurMisc[this]; }
            set { Fields.AcctPurMisc[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Dept; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public DepartmentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Dept;
            public StringField Description;
            public BooleanField Suspended;
            public StringField AcctMvtIssue;
            public StringField AcctMvtRcpt;
            public StringField AcctPurMisc;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DateTimeField ArevisedDate;
            public StringField ArevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Enterprise.Department";
            }
        }
    }
}
