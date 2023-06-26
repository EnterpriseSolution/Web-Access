#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AttachmentColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Document.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Document.Attachment")]
    [BasedOnRow(typeof(Entities.AttachmentRow))]
    public class AttachmentColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String MasterTable { get; set; }
        [AlignRight]
        public Decimal MasterKey { get; set; }
        public String FileType { get; set; }
        public String FilePath { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        public String Description { get; set; }
        //public String KeySegment1 { get; set; }
        //public String KeySegment2 { get; set; }
        //public String KeySegment3 { get; set; }
        //public String KeySegment4 { get; set; }
        //public String KeySegment5 { get; set; }
        [AlignRight]
        public Decimal AttmSize { get; set; }
        //public Stream AttmFile { get; set; }
        //public String UploadedBy { get; set; }
        //public DateTime UploadedDate { get; set; }
        public String Md5Hash { get; set; }
    }
}