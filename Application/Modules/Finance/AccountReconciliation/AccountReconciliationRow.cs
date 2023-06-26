#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountReconciliationRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLRECH]")]
    [DisplayName("Account Reconciliation"), InstanceName("Account Reconciliation"), TwoLevelCached]   
    public sealed class AccountReconciliationRow : Row, IIdRow, INameRow
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

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        public String Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Acct Name"), Column("ACCT_NAME"), Size(50), NotNull]
        public String AcctName
        {
            get { return Fields.AcctName[this]; }
            set { Fields.AcctName[this] = value; }
        }

        [DisplayName("Tran Date"), Column("TRAN_DATE"), NotNull]
        public DateTime? TranDate
        {
            get { return Fields.TranDate[this]; }
            set { Fields.TranDate[this] = value; }
        }

        [DisplayName("Begin Amt"), Column("BEGIN_AMT"), Size(14), Scale(2)]
        public Decimal? BeginAmt
        {
            get { return Fields.BeginAmt[this]; }
            set { Fields.BeginAmt[this] = value; }
        }

        [DisplayName("Begin Sign"), Column("BEGIN_SIGN"), Size(6)]
        public String BeginSign
        {
            get { return Fields.BeginSign[this]; }
            set { Fields.BeginSign[this] = value; }
        }

        [DisplayName("Total Debit"), Column("TOTAL_DEBIT"), Size(16), Scale(2)]
        public Decimal? TotalDebit
        {
            get { return Fields.TotalDebit[this]; }
            set { Fields.TotalDebit[this] = value; }
        }

        [DisplayName("Total Credit"), Column("TOTAL_CREDIT"), Size(16), Scale(2)]
        public Decimal? TotalCredit
        {
            get { return Fields.TotalCredit[this]; }
            set { Fields.TotalCredit[this] = value; }
        }

        [DisplayName("Alloc Debit"), Column("ALLOC_DEBIT"), Size(16), Scale(2)]
        public Decimal? AllocDebit
        {
            get { return Fields.AllocDebit[this]; }
            set { Fields.AllocDebit[this] = value; }
        }

        [DisplayName("Alloc Credit"), Column("ALLOC_CREDIT"), Size(16), Scale(2)]
        public Decimal? AllocCredit
        {
            get { return Fields.AllocCredit[this]; }
            set { Fields.AllocCredit[this] = value; }
        }

        [DisplayName("Adjust Debit"), Column("ADJUST_DEBIT"), Size(16), Scale(2)]
        public Decimal? AdjustDebit
        {
            get { return Fields.AdjustDebit[this]; }
            set { Fields.AdjustDebit[this] = value; }
        }

        [DisplayName("Adjust Credit"), Column("ADJUST_CREDIT"), Size(16), Scale(2)]
        public Decimal? AdjustCredit
        {
            get { return Fields.AdjustCredit[this]; }
            set { Fields.AdjustCredit[this] = value; }
        }

        [DisplayName("End Amt"), Column("END_AMT"), Size(16), Scale(2)]
        public Decimal? EndAmt
        {
            get { return Fields.EndAmt[this]; }
            set { Fields.EndAmt[this] = value; }
        }

        [DisplayName("End Sign"), Column("END_SIGN"), Size(6)]
        public String EndSign
        {
            get { return Fields.EndSign[this]; }
            set { Fields.EndSign[this] = value; }
        }

        [DisplayName("End Alloc Amt"), Column("END_ALLOC_AMT"), Size(16), Scale(2)]
        public Decimal? EndAllocAmt
        {
            get { return Fields.EndAllocAmt[this]; }
            set { Fields.EndAllocAmt[this] = value; }
        }

        [DisplayName("End Alloc Sign"), Column("END_ALLOC_SIGN"), Size(6)]
        public String EndAllocSign
        {
            get { return Fields.EndAllocSign[this]; }
            set { Fields.EndAllocSign[this] = value; }
        }

        [DisplayName("Detail Count"), Column("DETAIL_COUNT"), Size(6)]
        public Decimal? DetailCount
        {
            get { return Fields.DetailCount[this]; }
            set { Fields.DetailCount[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE"), NotNull]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10), NotNull]
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

        [DisplayName("Cutoff Date"), Column("CUTOFF_DATE")]
        public DateTime? CutoffDate
        {
            get { return Fields.CutoffDate[this]; }
            set { Fields.CutoffDate[this] = value; }
        }

        [DisplayName("Posted Date"), Column("POSTED_DATE")]
        public DateTime? PostedDate
        {
            get { return Fields.PostedDate[this]; }
            set { Fields.PostedDate[this] = value; }
        }

        [DisplayName("Posted By"), Column("POSTED_BY"), Size(10)]
        public String PostedBy
        {
            get { return Fields.PostedBy[this]; }
            set { Fields.PostedBy[this] = value; }
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

        public AccountReconciliationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField AcctNo;
            public StringField RefNo;
            public StringField Posted;
            public StringField AcctName;
            public DateTimeField TranDate;
            public DecimalField BeginAmt;
            public StringField BeginSign;
            public DecimalField TotalDebit;
            public DecimalField TotalCredit;
            public DecimalField AllocDebit;
            public DecimalField AllocCredit;
            public DecimalField AdjustDebit;
            public DecimalField AdjustCredit;
            public DecimalField EndAmt;
            public StringField EndSign;
            public DecimalField EndAllocAmt;
            public StringField EndAllocSign;
            public DecimalField DetailCount;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public DateTimeField CutoffDate;
            public DateTimeField PostedDate;
            public StringField PostedBy;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.AccountReconciliation";
            }
        }
    }
}
