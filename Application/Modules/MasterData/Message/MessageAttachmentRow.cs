#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MessageAttachmentRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[MSGATM]")]
    [DisplayName("Message Attachment"), InstanceName("Message Attachment"), TwoLevelCached]   
    public sealed class MessageAttachmentRow : Row, IIdRow, INameRow
    {
        [DisplayName("Message"), Column("MESSAGE_ID"), PrimaryKey, ForeignKey("[dbo].[MESSAGE]", "MESSAGE_ID"), LeftJoin("jMessage"), TextualField("MessageCreatedBy")]
        public Int32? MessageId
        {
            get { return Fields.MessageId[this]; }
            set { Fields.MessageId[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), PrimaryKey]
        public Int32? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Attachment Type"), Column("ATTACHMENT_TYPE")]
        public Int32? AttachmentType
        {
            get { return Fields.AttachmentType[this]; }
            set { Fields.AttachmentType[this] = value; }
        }

        [DisplayName("File Name"), Column("FILE_NAME"), Size(255), QuickSearch]
        public String FileName
        {
            get { return Fields.FileName[this]; }
            set { Fields.FileName[this] = value; }
        }

        [DisplayName("File Content"), Column("FILE_CONTENT"), Size(2147483647)]
        public Stream FileContent
        {
            get { return Fields.FileContent[this]; }
            set { Fields.FileContent[this] = value; }
        }

        [DisplayName("File Size"), Column("FILE_SIZE")]
        public Int32? FileSize
        {
            get { return Fields.FileSize[this]; }
            set { Fields.FileSize[this] = value; }
        }

        [DisplayName("Message Created By"), Expression("jMessage.[CREATED_BY]")]
        public String MessageCreatedBy
        {
            get { return Fields.MessageCreatedBy[this]; }
            set { Fields.MessageCreatedBy[this] = value; }
        }

        [DisplayName("Message Created Date"), Expression("jMessage.[CREATED_DATE]")]
        public DateTime? MessageCreatedDate
        {
            get { return Fields.MessageCreatedDate[this]; }
            set { Fields.MessageCreatedDate[this] = value; }
        }

        [DisplayName("Message Revised By"), Expression("jMessage.[REVISED_BY]")]
        public String MessageRevisedBy
        {
            get { return Fields.MessageRevisedBy[this]; }
            set { Fields.MessageRevisedBy[this] = value; }
        }

        [DisplayName("Message Revised Date"), Expression("jMessage.[REVISED_DATE]")]
        public DateTime? MessageRevisedDate
        {
            get { return Fields.MessageRevisedDate[this]; }
            set { Fields.MessageRevisedDate[this] = value; }
        }

        [DisplayName("Message Summary"), Expression("jMessage.[SUMMARY]")]
        public String MessageSummary
        {
            get { return Fields.MessageSummary[this]; }
            set { Fields.MessageSummary[this] = value; }
        }

        [DisplayName("Message Detail"), Expression("jMessage.[DETAIL]")]
        public String MessageDetail
        {
            get { return Fields.MessageDetail[this]; }
            set { Fields.MessageDetail[this] = value; }
        }

        [DisplayName("Message Parent Id"), Expression("jMessage.[PARENT_ID]")]
        public Int32? MessageParentId
        {
            get { return Fields.MessageParentId[this]; }
            set { Fields.MessageParentId[this] = value; }
        }

        [DisplayName("Message Post Status"), Expression("jMessage.[POST_STATUS]")]
        public String MessagePostStatus
        {
            get { return Fields.MessagePostStatus[this]; }
            set { Fields.MessagePostStatus[this] = value; }
        }

        [DisplayName("Message Req Id"), Expression("jMessage.[REQ_ID]")]
        public Int32? MessageReqId
        {
            get { return Fields.MessageReqId[this]; }
            set { Fields.MessageReqId[this] = value; }
        }

        [DisplayName("Message Msg To"), Expression("jMessage.[MSG_TO]")]
        public String MessageMsgTo
        {
            get { return Fields.MessageMsgTo[this]; }
            set { Fields.MessageMsgTo[this] = value; }
        }

        [DisplayName("Message Reqmsg Parent Id"), Expression("jMessage.[REQMSG_PARENT_ID]")]
        public Decimal? MessageReqmsgParentId
        {
            get { return Fields.MessageReqmsgParentId[this]; }
            set { Fields.MessageReqmsgParentId[this] = value; }
        }

        [DisplayName("Message Instance No"), Expression("jMessage.[INSTANCE_NO]")]
        public Int32? MessageInstanceNo
        {
            get { return Fields.MessageInstanceNo[this]; }
            set { Fields.MessageInstanceNo[this] = value; }
        }

        [DisplayName("Message Html Text"), Expression("jMessage.[HTML_TEXT]")]
        public String MessageHtmlText
        {
            get { return Fields.MessageHtmlText[this]; }
            set { Fields.MessageHtmlText[this] = value; }
        }

        [DisplayName("Message With Attachment"), Expression("jMessage.[WITH_ATTACHMENT]")]
        public Boolean? MessageWithAttachment
        {
            get { return Fields.MessageWithAttachment[this]; }
            set { Fields.MessageWithAttachment[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.MessageId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.FileName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MessageAttachmentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field MessageId;
            public Int32Field LineNo;
            public Int32Field AttachmentType;
            public StringField FileName;
            public StreamField FileContent;
            public Int32Field FileSize;

            public StringField MessageCreatedBy;
            public DateTimeField MessageCreatedDate;
            public StringField MessageRevisedBy;
            public DateTimeField MessageRevisedDate;
            public StringField MessageSummary;
            public StringField MessageDetail;
            public Int32Field MessageParentId;
            public StringField MessagePostStatus;
            public Int32Field MessageReqId;
            public StringField MessageMsgTo;
            public DecimalField MessageReqmsgParentId;
            public Int32Field MessageInstanceNo;
            public StringField MessageHtmlText;
            public BooleanField MessageWithAttachment;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.MessageAttachment";
            }
        }
    }
}
