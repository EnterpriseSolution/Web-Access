#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MessageAttachmentColumns.cs
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

    [ColumnsScript("MasterData.MessageAttachment")]
    [BasedOnRow(typeof(Entities.MessageAttachmentRow))]
    public class MessageAttachmentColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public String MessageCreatedBy { get; set; }
        public Int32 LineNo { get; set; }
        public Int32 AttachmentType { get; set; }
        [EditLink]
        public String FileName { get; set; }
        public Stream FileContent { get; set; }
        public Int32 FileSize { get; set; }
    }
}