#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseRequisitionRow.cs
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

    [ConnectionKey("Purchasing"), TableName("[dbo].[PUREQH]")]
    [DisplayName("Purchase Requisition"), InstanceName("Purchase Requisition"), TwoLevelCached]   
    public sealed class PurchaseRequisitionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Req No"), Column("REQ_NO"), Size(16), PrimaryKey, QuickSearch]
        public String ReqNo
        {
            get { return Fields.ReqNo[this]; }
            set { Fields.ReqNo[this] = value; }
        }

        [DisplayName("Closed"), Column("CLOSED"), Size(1), NotNull]
        public String Closed
        {
            get { return Fields.Closed[this]; }
            set { Fields.Closed[this] = value; }
        }

        [DisplayName("Request By"), Column("REQUEST_BY"), Size(10)]
        public String RequestBy
        {
            get { return Fields.RequestBy[this]; }
            set { Fields.RequestBy[this] = value; }
        }

        [DisplayName("Request Date"), Column("REQUEST_DATE")]
        public DateTime? RequestDate
        {
            get { return Fields.RequestDate[this]; }
            set { Fields.RequestDate[this] = value; }
        }

        [DisplayName("Due Date"), Column("DUE_DATE")]
        public DateTime? DueDate
        {
            get { return Fields.DueDate[this]; }
            set { Fields.DueDate[this] = value; }
        }

        [DisplayName("Remind Date"), Column("REMIND_DATE")]
        public DateTime? RemindDate
        {
            get { return Fields.RemindDate[this]; }
            set { Fields.RemindDate[this] = value; }
        }

        [DisplayName("Reminded"), Column("REMINDED"), Size(1)]
        public String Reminded
        {
            get { return Fields.Reminded[this]; }
            set { Fields.Reminded[this] = value; }
        }

        [DisplayName("Recipients"), Column("RECIPIENTS"), Size(250)]
        public String Recipients
        {
            get { return Fields.Recipients[this]; }
            set { Fields.Recipients[this] = value; }
        }

        [DisplayName("Comments1"), Column("COMMENTS1"), Size(1073741823)]
        public String Comments1
        {
            get { return Fields.Comments1[this]; }
            set { Fields.Comments1[this] = value; }
        }

        [DisplayName("Comments2"), Column("COMMENTS2"), Size(1073741823)]
        public String Comments2
        {
            get { return Fields.Comments2[this]; }
            set { Fields.Comments2[this] = value; }
        }

        [DisplayName("Comments3"), Column("COMMENTS3"), Size(1073741823)]
        public String Comments3
        {
            get { return Fields.Comments3[this]; }
            set { Fields.Comments3[this] = value; }
        }

        [DisplayName("Comments4"), Column("COMMENTS4"), Size(1073741823)]
        public String Comments4
        {
            get { return Fields.Comments4[this]; }
            set { Fields.Comments4[this] = value; }
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

        [DisplayName("Closed By"), Column("CLOSED_BY"), Size(10)]
        public String ClosedBy
        {
            get { return Fields.ClosedBy[this]; }
            set { Fields.ClosedBy[this] = value; }
        }

        [DisplayName("Closed Date"), Column("CLOSED_DATE")]
        public DateTime? ClosedDate
        {
            get { return Fields.ClosedDate[this]; }
            set { Fields.ClosedDate[this] = value; }
        }

        [DisplayName("Message Id"), Column("MESSAGE_ID"), Size(8)]
        public Decimal? MessageId
        {
            get { return Fields.MessageId[this]; }
            set { Fields.MessageId[this] = value; }
        }

        [DisplayName("Status"), Column("STATUS"), Size(1)]
        public String Status
        {
            get { return Fields.Status[this]; }
            set { Fields.Status[this] = value; }
        }

        [DisplayName("Approved"), Column("APPROVED"), Size(1)]
        public String Approved
        {
            get { return Fields.Approved[this]; }
            set { Fields.Approved[this] = value; }
        }

        [DisplayName("Approved By"), Column("APPROVED_BY"), Size(10)]
        public String ApprovedBy
        {
            get { return Fields.ApprovedBy[this]; }
            set { Fields.ApprovedBy[this] = value; }
        }

        [DisplayName("Approved Date"), Column("APPROVED_DATE")]
        public DateTime? ApprovedDate
        {
            get { return Fields.ApprovedDate[this]; }
            set { Fields.ApprovedDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ReqNo; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ReqNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PurchaseRequisitionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ReqNo;
            public StringField Closed;
            public StringField RequestBy;
            public DateTimeField RequestDate;
            public DateTimeField DueDate;
            public DateTimeField RemindDate;
            public StringField Reminded;
            public StringField Recipients;
            public StringField Comments1;
            public StringField Comments2;
            public StringField Comments3;
            public StringField Comments4;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public StringField ClosedBy;
            public DateTimeField ClosedDate;
            public DecimalField MessageId;
            public StringField Status;
            public StringField Approved;
            public StringField ApprovedBy;
            public DateTimeField ApprovedDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Purchasing.PurchaseRequisition";
            }
        }
    }
}
