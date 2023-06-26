#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  BuyerDetailRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[PUBVEN]")]
    [DisplayName("Buyer Detail"), InstanceName("Buyer Detail"), TwoLevelCached]   
    public sealed class BuyerDetailRow : Row, IIdRow, INameRow
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

        [DisplayName("Vendor No"), Column("VENDOR_NO"), Size(8), PrimaryKey]
        public String VendorNo
        {
            get { return Fields.VendorNo[this]; }
            set { Fields.VendorNo[this] = value; }
        }

        [DisplayName("Vendor Name"), Column("VENDOR_NAME"), Size(50)]
        public String VendorName
        {
            get { return Fields.VendorName[this]; }
            set { Fields.VendorName[this] = value; }
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

        public BuyerDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField BuyerCode;
            public StringField VendorNo;
            public StringField VendorName;

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
                LocalTextPrefix = "MasterData.BuyerDetail";
            }
        }
    }
}
