#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseRequisitionDetailRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUREQD]")]
    [DisplayName("Purchase Requisition Detail"), InstanceName("Purchase Requisition Detail"), TwoLevelCached]   
    public sealed class PurchaseRequisitionDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Req No"), Column("REQ_NO"), Size(16), PrimaryKey, ForeignKey("[dbo].[PUREQH]", "REQ_NO"), LeftJoin("jReqNo"), QuickSearch, TextualField("ReqNoClosed")]
        public String ReqNo
        {
            get { return Fields.ReqNo[this]; }
            set { Fields.ReqNo[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Item No"), Column("ITEM_NO"), Size(30), NotNull]
        public String ItemNo
        {
            get { return Fields.ItemNo[this]; }
            set { Fields.ItemNo[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Uom"), Column("UOM"), Size(4)]
        public String Uom
        {
            get { return Fields.Uom[this]; }
            set { Fields.Uom[this] = value; }
        }

        [DisplayName("Lot Size"), Column("LOT_SIZE"), Size(10), Scale(4)]
        public Decimal? LotSize
        {
            get { return Fields.LotSize[this]; }
            set { Fields.LotSize[this] = value; }
        }

        [DisplayName("Qty"), Column("QTY"), Size(14), Scale(4)]
        public Decimal? Qty
        {
            get { return Fields.Qty[this]; }
            set { Fields.Qty[this] = value; }
        }

        [DisplayName("Ext Description"), Column("EXT_DESCRIPTION"), Size(1073741823)]
        public String ExtDescription
        {
            get { return Fields.ExtDescription[this]; }
            set { Fields.ExtDescription[this] = value; }
        }

        [DisplayName("Qty Allocated"), Column("QTY_ALLOCATED"), Size(14), Scale(4)]
        public Decimal? QtyAllocated
        {
            get { return Fields.QtyAllocated[this]; }
            set { Fields.QtyAllocated[this] = value; }
        }

        [DisplayName("Remark"), Column("REMARK"), Size(1073741823)]
        public String Remark
        {
            get { return Fields.Remark[this]; }
            set { Fields.Remark[this] = value; }
        }

        [DisplayName("Qty Pre Allocated"), Column("QTY_PRE_ALLOCATED"), Size(14), Scale(4)]
        public Decimal? QtyPreAllocated
        {
            get { return Fields.QtyPreAllocated[this]; }
            set { Fields.QtyPreAllocated[this] = value; }
        }

        [DisplayName("Req No Recnum"), Expression("jReqNo.[RECNUM]")]
        public Decimal? ReqNoRecnum
        {
            get { return Fields.ReqNoRecnum[this]; }
            set { Fields.ReqNoRecnum[this] = value; }
        }

        [DisplayName("Req No Closed"), Expression("jReqNo.[CLOSED]")]
        public String ReqNoClosed
        {
            get { return Fields.ReqNoClosed[this]; }
            set { Fields.ReqNoClosed[this] = value; }
        }

        [DisplayName("Req No Request By"), Expression("jReqNo.[REQUEST_BY]")]
        public String ReqNoRequestBy
        {
            get { return Fields.ReqNoRequestBy[this]; }
            set { Fields.ReqNoRequestBy[this] = value; }
        }

        [DisplayName("Req No Request Date"), Expression("jReqNo.[REQUEST_DATE]")]
        public DateTime? ReqNoRequestDate
        {
            get { return Fields.ReqNoRequestDate[this]; }
            set { Fields.ReqNoRequestDate[this] = value; }
        }

        [DisplayName("Req No Due Date"), Expression("jReqNo.[DUE_DATE]")]
        public DateTime? ReqNoDueDate
        {
            get { return Fields.ReqNoDueDate[this]; }
            set { Fields.ReqNoDueDate[this] = value; }
        }

        [DisplayName("Req No Remind Date"), Expression("jReqNo.[REMIND_DATE]")]
        public DateTime? ReqNoRemindDate
        {
            get { return Fields.ReqNoRemindDate[this]; }
            set { Fields.ReqNoRemindDate[this] = value; }
        }

        [DisplayName("Req No Reminded"), Expression("jReqNo.[REMINDED]")]
        public String ReqNoReminded
        {
            get { return Fields.ReqNoReminded[this]; }
            set { Fields.ReqNoReminded[this] = value; }
        }

        [DisplayName("Req No Recipients"), Expression("jReqNo.[RECIPIENTS]")]
        public String ReqNoRecipients
        {
            get { return Fields.ReqNoRecipients[this]; }
            set { Fields.ReqNoRecipients[this] = value; }
        }

        [DisplayName("Req No Comments1"), Expression("jReqNo.[COMMENTS1]")]
        public String ReqNoComments1
        {
            get { return Fields.ReqNoComments1[this]; }
            set { Fields.ReqNoComments1[this] = value; }
        }

        [DisplayName("Req No Comments2"), Expression("jReqNo.[COMMENTS2]")]
        public String ReqNoComments2
        {
            get { return Fields.ReqNoComments2[this]; }
            set { Fields.ReqNoComments2[this] = value; }
        }

        [DisplayName("Req No Comments3"), Expression("jReqNo.[COMMENTS3]")]
        public String ReqNoComments3
        {
            get { return Fields.ReqNoComments3[this]; }
            set { Fields.ReqNoComments3[this] = value; }
        }

        [DisplayName("Req No Comments4"), Expression("jReqNo.[COMMENTS4]")]
        public String ReqNoComments4
        {
            get { return Fields.ReqNoComments4[this]; }
            set { Fields.ReqNoComments4[this] = value; }
        }

        [DisplayName("Req No Created By"), Expression("jReqNo.[CREATED_BY]")]
        public String ReqNoCreatedBy
        {
            get { return Fields.ReqNoCreatedBy[this]; }
            set { Fields.ReqNoCreatedBy[this] = value; }
        }

        [DisplayName("Req No Created Date"), Expression("jReqNo.[CREATED_DATE]")]
        public DateTime? ReqNoCreatedDate
        {
            get { return Fields.ReqNoCreatedDate[this]; }
            set { Fields.ReqNoCreatedDate[this] = value; }
        }

        [DisplayName("Req No Revised By"), Expression("jReqNo.[REVISED_BY]")]
        public String ReqNoRevisedBy
        {
            get { return Fields.ReqNoRevisedBy[this]; }
            set { Fields.ReqNoRevisedBy[this] = value; }
        }

        [DisplayName("Req No Revised Date"), Expression("jReqNo.[REVISED_DATE]")]
        public DateTime? ReqNoRevisedDate
        {
            get { return Fields.ReqNoRevisedDate[this]; }
            set { Fields.ReqNoRevisedDate[this] = value; }
        }

        [DisplayName("Req No Closed By"), Expression("jReqNo.[CLOSED_BY]")]
        public String ReqNoClosedBy
        {
            get { return Fields.ReqNoClosedBy[this]; }
            set { Fields.ReqNoClosedBy[this] = value; }
        }

        [DisplayName("Req No Closed Date"), Expression("jReqNo.[CLOSED_DATE]")]
        public DateTime? ReqNoClosedDate
        {
            get { return Fields.ReqNoClosedDate[this]; }
            set { Fields.ReqNoClosedDate[this] = value; }
        }

        [DisplayName("Req No Message Id"), Expression("jReqNo.[MESSAGE_ID]")]
        public Decimal? ReqNoMessageId
        {
            get { return Fields.ReqNoMessageId[this]; }
            set { Fields.ReqNoMessageId[this] = value; }
        }

        [DisplayName("Req No Status"), Expression("jReqNo.[STATUS]")]
        public String ReqNoStatus
        {
            get { return Fields.ReqNoStatus[this]; }
            set { Fields.ReqNoStatus[this] = value; }
        }

        [DisplayName("Req No Approved"), Expression("jReqNo.[APPROVED]")]
        public String ReqNoApproved
        {
            get { return Fields.ReqNoApproved[this]; }
            set { Fields.ReqNoApproved[this] = value; }
        }

        [DisplayName("Req No Approved By"), Expression("jReqNo.[APPROVED_BY]")]
        public String ReqNoApprovedBy
        {
            get { return Fields.ReqNoApprovedBy[this]; }
            set { Fields.ReqNoApprovedBy[this] = value; }
        }

        [DisplayName("Req No Approved Date"), Expression("jReqNo.[APPROVED_DATE]")]
        public DateTime? ReqNoApprovedDate
        {
            get { return Fields.ReqNoApprovedDate[this]; }
            set { Fields.ReqNoApprovedDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ReqNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseRequisitionDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ReqNo;
            public DecimalField LineNo;
            public StringField ItemNo;
            public StringField Description;
            public StringField Uom;
            public DecimalField LotSize;
            public DecimalField Qty;
            public StringField ExtDescription;
            public DecimalField QtyAllocated;
            public StringField Remark;
            public DecimalField QtyPreAllocated;

            public DecimalField ReqNoRecnum;
            public StringField ReqNoClosed;
            public StringField ReqNoRequestBy;
            public DateTimeField ReqNoRequestDate;
            public DateTimeField ReqNoDueDate;
            public DateTimeField ReqNoRemindDate;
            public StringField ReqNoReminded;
            public StringField ReqNoRecipients;
            public StringField ReqNoComments1;
            public StringField ReqNoComments2;
            public StringField ReqNoComments3;
            public StringField ReqNoComments4;
            public StringField ReqNoCreatedBy;
            public DateTimeField ReqNoCreatedDate;
            public StringField ReqNoRevisedBy;
            public DateTimeField ReqNoRevisedDate;
            public StringField ReqNoClosedBy;
            public DateTimeField ReqNoClosedDate;
            public DecimalField ReqNoMessageId;
            public StringField ReqNoStatus;
            public StringField ReqNoApproved;
            public StringField ReqNoApprovedBy;
            public DateTimeField ReqNoApprovedDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseRequisitionDetail";
            }
        }
    }
}
