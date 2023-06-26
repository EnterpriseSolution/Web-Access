#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Administration"), TableName("[dbo].[LookupDialog]")]
    [DisplayName("Lookup Dialog"), InstanceName("Lookup Dialog"), TwoLevelCached]   
    public sealed class LookupDialogRow : Row, IIdRow, INameRow
    {
        [DisplayName("Lookup Name"), Size(64), PrimaryKey, QuickSearch]
        public String LookupName
        {
            get { return Fields.LookupName[this]; }
            set { Fields.LookupName[this] = value; }
        }

        [DisplayName("Description"), Size(100)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Query Id"), Size(64)]
        public String QueryId
        {
            get { return Fields.QueryId[this]; }
            set { Fields.QueryId[this] = value; }
        }

        [DisplayName("Key Field1"), Size(64)]
        public String KeyField1
        {
            get { return Fields.KeyField1[this]; }
            set { Fields.KeyField1[this] = value; }
        }

        [DisplayName("Key Field2"), Size(64)]
        public String KeyField2
        {
            get { return Fields.KeyField2[this]; }
            set { Fields.KeyField2[this] = value; }
        }

        [DisplayName("Key Field3"), Size(64)]
        public String KeyField3
        {
            get { return Fields.KeyField3[this]; }
            set { Fields.KeyField3[this] = value; }
        }

        [DisplayName("Suspended")]
        public Boolean? Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Created By"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Created Date")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Revised By"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Revised Date")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.LookupName; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LookupName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public LookupDialogRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField LookupName;
            public StringField Description;
            public StringField QueryId;
            public StringField KeyField1;
            public StringField KeyField2;
            public StringField KeyField3;
            public BooleanField Suspended;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.LookupDialog";
            }
        }
    }
}
