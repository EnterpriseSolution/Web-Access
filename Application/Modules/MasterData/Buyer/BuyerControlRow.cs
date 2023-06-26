#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BuyerControlRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[PUBUYL]")]
    [DisplayName("Buyer Control"), InstanceName("Buyer Control"), TwoLevelCached]   
    public sealed class BuyerControlRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Buyer Code"), Column("BUYER_CODE"), Size(6), PrimaryKey, ForeignKey("[dbo].[PUBUYR]", "BUYER_CODE"), LeftJoin("jBuyerCode"), QuickSearch, TextualField("BuyerCodeBuyerName")]
        public String BuyerCode
        {
            get { return Fields.BuyerCode[this]; }
            set { Fields.BuyerCode[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(8), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Type Group"), Column("TYPE_GROUP"), Size(1), NotNull]
        public String TypeGroup
        {
            get { return Fields.TypeGroup[this]; }
            set { Fields.TypeGroup[this] = value; }
        }

        [DisplayName("Type Item"), Column("TYPE_ITEM"), Size(1), NotNull]
        public String TypeItem
        {
            get { return Fields.TypeItem[this]; }
            set { Fields.TypeItem[this] = value; }
        }

        [DisplayName("Entry Code"), Column("ENTRY_CODE"), Size(30), NotNull]
        public String EntryCode
        {
            get { return Fields.EntryCode[this]; }
            set { Fields.EntryCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Max Qty"), Column("MAX_QTY"), Size(12), Scale(4)]
        public Decimal? MaxQty
        {
            get { return Fields.MaxQty[this]; }
            set { Fields.MaxQty[this] = value; }
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

        [DisplayName("Buyer Code Recnum"), Expression("jBuyerCode.[RECNUM]")]
        public Decimal? BuyerCodeRecnum
        {
            get { return Fields.BuyerCodeRecnum[this]; }
            set { Fields.BuyerCodeRecnum[this] = value; }
        }

        [DisplayName("Buyer Code Buyer Name"), Expression("jBuyerCode.[BUYER_NAME]")]
        public String BuyerCodeBuyerName
        {
            get { return Fields.BuyerCodeBuyerName[this]; }
            set { Fields.BuyerCodeBuyerName[this] = value; }
        }

        [DisplayName("Buyer Code Suspended"), Expression("jBuyerCode.[SUSPENDED]")]
        public String BuyerCodeSuspended
        {
            get { return Fields.BuyerCodeSuspended[this]; }
            set { Fields.BuyerCodeSuspended[this] = value; }
        }

        [DisplayName("Buyer Code With Backlog"), Expression("jBuyerCode.[WITH_BACKLOG]")]
        public String BuyerCodeWithBacklog
        {
            get { return Fields.BuyerCodeWithBacklog[this]; }
            set { Fields.BuyerCodeWithBacklog[this] = value; }
        }

        [DisplayName("Buyer Code On Order Count"), Expression("jBuyerCode.[ON_ORDER_COUNT]")]
        public Decimal? BuyerCodeOnOrderCount
        {
            get { return Fields.BuyerCodeOnOrderCount[this]; }
            set { Fields.BuyerCodeOnOrderCount[this] = value; }
        }

        [DisplayName("Buyer Code Last Line No"), Expression("jBuyerCode.[LAST_LINE_NO]")]
        public Decimal? BuyerCodeLastLineNo
        {
            get { return Fields.BuyerCodeLastLineNo[this]; }
            set { Fields.BuyerCodeLastLineNo[this] = value; }
        }

        [DisplayName("Buyer Code Created Date"), Expression("jBuyerCode.[CREATED_DATE]")]
        public DateTime? BuyerCodeCreatedDate
        {
            get { return Fields.BuyerCodeCreatedDate[this]; }
            set { Fields.BuyerCodeCreatedDate[this] = value; }
        }

        [DisplayName("Buyer Code Created By"), Expression("jBuyerCode.[CREATED_BY]")]
        public String BuyerCodeCreatedBy
        {
            get { return Fields.BuyerCodeCreatedBy[this]; }
            set { Fields.BuyerCodeCreatedBy[this] = value; }
        }

        [DisplayName("Buyer Code Revised Date"), Expression("jBuyerCode.[REVISED_DATE]")]
        public DateTime? BuyerCodeRevisedDate
        {
            get { return Fields.BuyerCodeRevisedDate[this]; }
            set { Fields.BuyerCodeRevisedDate[this] = value; }
        }

        [DisplayName("Buyer Code Revised By"), Expression("jBuyerCode.[REVISED_BY]")]
        public String BuyerCodeRevisedBy
        {
            get { return Fields.BuyerCodeRevisedBy[this]; }
            set { Fields.BuyerCodeRevisedBy[this] = value; }
        }

        [DisplayName("Buyer Code Owner Branch"), Expression("jBuyerCode.[OWNER_BRANCH]")]
        public String BuyerCodeOwnerBranch
        {
            get { return Fields.BuyerCodeOwnerBranch[this]; }
            set { Fields.BuyerCodeOwnerBranch[this] = value; }
        }

        [DisplayName("Buyer Code Source Branch"), Expression("jBuyerCode.[SOURCE_BRANCH]")]
        public String BuyerCodeSourceBranch
        {
            get { return Fields.BuyerCodeSourceBranch[this]; }
            set { Fields.BuyerCodeSourceBranch[this] = value; }
        }

        [DisplayName("Buyer Code Supervisor"), Expression("jBuyerCode.[SUPERVISOR]")]
        public String BuyerCodeSupervisor
        {
            get { return Fields.BuyerCodeSupervisor[this]; }
            set { Fields.BuyerCodeSupervisor[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.BuyerCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public BuyerControlRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField BuyerCode;
            public DecimalField LineNo;
            public StringField TypeGroup;
            public StringField TypeItem;
            public StringField EntryCode;
            public StringField Description;
            public StringField Suspended;
            public DecimalField MaxQty;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public DecimalField BuyerCodeRecnum;
            public StringField BuyerCodeBuyerName;
            public StringField BuyerCodeSuspended;
            public StringField BuyerCodeWithBacklog;
            public DecimalField BuyerCodeOnOrderCount;
            public DecimalField BuyerCodeLastLineNo;
            public DateTimeField BuyerCodeCreatedDate;
            public StringField BuyerCodeCreatedBy;
            public DateTimeField BuyerCodeRevisedDate;
            public StringField BuyerCodeRevisedBy;
            public StringField BuyerCodeOwnerBranch;
            public StringField BuyerCodeSourceBranch;
            public StringField BuyerCodeSupervisor;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.BuyerControl";
            }
        }
    }
}
