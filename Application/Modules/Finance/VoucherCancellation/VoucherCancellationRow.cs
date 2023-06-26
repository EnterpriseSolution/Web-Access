#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherCancellationRow.cs
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

    [ConnectionKey("Finance"), TableName("[dbo].[GLVOHC]")]
    [DisplayName("Voucher Cancellation"), InstanceName("Voucher Cancellation"), TwoLevelCached]   
    public sealed class VoucherCancellationRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Ref No"), Column("REF_NO"), Size(16), PrimaryKey, QuickSearch]
        public String RefNo
        {
            get { return Fields.RefNo[this]; }
            set { Fields.RefNo[this] = value; }
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

        [DisplayName("Posted"), Column("POSTED"), Size(1), NotNull]
        [BoolStringConverter]
        public bool? Posted
        {
            get { return Fields.Posted[this]; }
            set { Fields.Posted[this] = value; }
        }

        [DisplayName("Voucher Type"), Column("VOUCHER_TYPE"), Size(6), NotNull]
        public String VoucherType
        {
            get { return Fields.VoucherType[this]; }
            set { Fields.VoucherType[this] = value; }
        }

        [DisplayName("Voucher No"), Column("VOUCHER_NO"), Size(16), NotNull]
        public String VoucherNo
        {
            get { return Fields.VoucherNo[this]; }
            set { Fields.VoucherNo[this] = value; }
        }

        [DisplayName("Tran Date"), Column("TRAN_DATE")]
        public DateTime? TranDate
        {
            get { return Fields.TranDate[this]; }
            set { Fields.TranDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
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

        [DisplayName("Particulars"), Column("PARTICULARS"), Size(1073741823)]
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
            get { return Fields.RefNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public VoucherCancellationRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField RefNo;
            public DateTimeField PostedDate;
            public StringField PostedBy;
            public BooleanField Posted;
            public StringField VoucherType;
            public StringField VoucherNo;
            public DateTimeField TranDate;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Particulars;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.VoucherCancellation";
            }
        }
    }
}
