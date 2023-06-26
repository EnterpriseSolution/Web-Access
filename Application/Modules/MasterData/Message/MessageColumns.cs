#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MessageColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("MasterData.Message")]
    [BasedOnRow(typeof(Entities.MessageRow))]
    public class MessageColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Int32 MessageId { get; set; }
        [EditLink]
        public String CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public String RevisedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String Summary { get; set; }
        public String Detail { get; set; }
        public Int32 ParentId { get; set; }
        public String PostStatus { get; set; }
        public Int32 ReqId { get; set; }
        public String MsgTo { get; set; }
        public Decimal ReqmsgParentId { get; set; }
        public Int32 InstanceNo { get; set; }
        public String HtmlText { get; set; }
        public Boolean WithAttachment { get; set; }
    }
}