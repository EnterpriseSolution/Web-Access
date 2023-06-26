#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AttachmentRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Document.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Document"), TableName("[dbo].[GBATTM]")]
    [DisplayName("Attachment"), InstanceName("Attachment"), TwoLevelCached]   
    public sealed class AttachmentRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Master Table"), Column("MASTER_TABLE"), Size(50), PrimaryKey, QuickSearch]
        public String MasterTable
        {
            get { return Fields.MasterTable[this]; }
            set { Fields.MasterTable[this] = value; }
        }

        [DisplayName("Master Key"), Column("MASTER_KEY"), Size(10), PrimaryKey]
        public Decimal? MasterKey
        {
            get { return Fields.MasterKey[this]; }
            set { Fields.MasterKey[this] = value; }
        }

        [DisplayName("File Type"), Column("FILE_TYPE"), Size(10), NotNull]
        public String FileType
        {
            get { return Fields.FileType[this]; }
            set { Fields.FileType[this] = value; }
        }

        [DisplayName("File"), Column("FILE_PATH"), Size(250)]
        public String FilePath
        {
            get { return Fields.FilePath[this]; }
            set { Fields.FilePath[this] = value; }
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

        [DisplayName("Description"), Column("DESCRIPTION"), Size(60)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Key Segment1"), Column("KEY_SEGMENT1"), Size(30)]
        public String KeySegment1
        {
            get { return Fields.KeySegment1[this]; }
            set { Fields.KeySegment1[this] = value; }
        }

        [DisplayName("Key Segment2"), Column("KEY_SEGMENT2"), Size(30)]
        public String KeySegment2
        {
            get { return Fields.KeySegment2[this]; }
            set { Fields.KeySegment2[this] = value; }
        }

        [DisplayName("Key Segment3"), Column("KEY_SEGMENT3"), Size(30)]
        public String KeySegment3
        {
            get { return Fields.KeySegment3[this]; }
            set { Fields.KeySegment3[this] = value; }
        }

        [DisplayName("Key Segment4"), Column("KEY_SEGMENT4"), Size(30)]
        public String KeySegment4
        {
            get { return Fields.KeySegment4[this]; }
            set { Fields.KeySegment4[this] = value; }
        }

        [DisplayName("Key Segment5"), Column("KEY_SEGMENT5"), Size(30)]
        public String KeySegment5
        {
            get { return Fields.KeySegment5[this]; }
            set { Fields.KeySegment5[this] = value; }
        }

        [DisplayName("Attachment Length"), Column("ATTM_SIZE"), Size(18)]
        public Decimal? AttmSize
        {
            get { return Fields.AttmSize[this]; }
            set { Fields.AttmSize[this] = value; }
        }

        [DisplayName("Attm File"), Column("ATTM_FILE"), Size(2147483647)]
        public Stream AttmFile
        {
            get { return Fields.AttmFile[this]; }
            set { Fields.AttmFile[this] = value; }
        }

        [DisplayName("Uploaded By"), Column("UPLOADED_BY"), Size(10)]
        public String UploadedBy
        {
            get { return Fields.UploadedBy[this]; }
            set { Fields.UploadedBy[this] = value; }
        }

        [DisplayName("Uploaded Date"), Column("UPLOADED_DATE")]
        public DateTime? UploadedDate
        {
            get { return Fields.UploadedDate[this]; }
            set { Fields.UploadedDate[this] = value; }
        }

        [DisplayName("Md5 Hash"), Column("MD5_HASH"), Size(32)]
        public String Md5Hash
        {
            get { return Fields.Md5Hash[this]; }
            set { Fields.Md5Hash[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.MasterTable; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AttachmentRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField MasterTable;
            public DecimalField MasterKey;
            public StringField FileType;
            public StringField FilePath;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public StringField Description;
            public StringField KeySegment1;
            public StringField KeySegment2;
            public StringField KeySegment3;
            public StringField KeySegment4;
            public StringField KeySegment5;
            public DecimalField AttmSize;
            public StreamField AttmFile;
            public StringField UploadedBy;
            public DateTimeField UploadedDate;
            public StringField Md5Hash;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Document.Attachment";
            }
        }
    }
}
