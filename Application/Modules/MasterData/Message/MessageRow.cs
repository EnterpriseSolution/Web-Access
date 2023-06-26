#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MessageRow.cs
// Date: 2018/04/03 20:51

#endregion

using System.Collections.Generic;

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("MasterData"), TableName("[dbo].[MESSAGE]")]
    [DisplayName("Message"), InstanceName("Message"), TwoLevelCached]   
    public sealed class MessageRow : Row, IIdRow, INameRow
    {
        [DisplayName("Message Id"), Column("MESSAGE_ID"), Identity]
        public Int32? MessageId
        {
            get { return Fields.MessageId[this]; }
            set { Fields.MessageId[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10), QuickSearch]
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

        [DisplayName("Summary"), Column("SUMMARY"), Size(255)]
        public String Summary
        {
            get { return Fields.Summary[this]; }
            set { Fields.Summary[this] = value; }
        }

        [DisplayName("Detail"), Column("DETAIL")]
        public String Detail
        {
            get { return Fields.Detail[this]; }
            set { Fields.Detail[this] = value; }
        }

        [DisplayName("Parent Id"), Column("PARENT_ID")]
        public Int32? ParentId
        {
            get { return Fields.ParentId[this]; }
            set { Fields.ParentId[this] = value; }
        }

        [DisplayName("Post Status"), Column("POST_STATUS"), Size(1)]
        public String PostStatus
        {
            get { return Fields.PostStatus[this]; }
            set { Fields.PostStatus[this] = value; }
        }

        [DisplayName("Req Id"), Column("REQ_ID")]
        public Int32? ReqId
        {
            get { return Fields.ReqId[this]; }
            set { Fields.ReqId[this] = value; }
        }

        [DisplayName("Msg To"), Column("MSG_TO"), Size(1000)]
        public String MsgTo
        {
            get { return Fields.MsgTo[this]; }
            set { Fields.MsgTo[this] = value; }
        }

        [DisplayName("Reqmsg Parent Id"), Column("REQMSG_PARENT_ID"), Size(8)]
        public Decimal? ReqmsgParentId
        {
            get { return Fields.ReqmsgParentId[this]; }
            set { Fields.ReqmsgParentId[this] = value; }
        }

        [DisplayName("Instance No"), Column("INSTANCE_NO")]
        public Int32? InstanceNo
        {
            get { return Fields.InstanceNo[this]; }
            set { Fields.InstanceNo[this] = value; }
        }

        [DisplayName("Html Text"), Column("HTML_TEXT"), Size(1073741823)]
        public String HtmlText
        {
            get { return Fields.HtmlText[this]; }
            set { Fields.HtmlText[this] = value; }
        }

        [DisplayName("With Attachment"), Column("WITH_ATTACHMENT")]
        public Boolean? WithAttachment
        {
            get { return Fields.WithAttachment[this]; }
            set { Fields.WithAttachment[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MessageId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Summary; }
        }

        [MasterDetailRelation(foreignKey: "MessageId",IncludeColumns = "FileName")]
        [DisplayName("Detail List"), NotMapped]
        public List<MessageAttachmentRow> DetailList
        {
            get { return Fields.DetailList[this]; }
            set { Fields.DetailList[this] = value; }
        }


        public static readonly RowFields Fields = new RowFields().Init();

        public MessageRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public RowListField<MessageAttachmentRow> DetailList;
            
            public Int32Field MessageId;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public StringField Summary;
            public StringField Detail;
            public Int32Field ParentId;
            public StringField PostStatus;
            public Int32Field ReqId;
            public StringField MsgTo;
            public DecimalField ReqmsgParentId;
            public Int32Field InstanceNo;
            public StringField HtmlText;
            public BooleanField WithAttachment;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Message";
            }
        }
    }
}
