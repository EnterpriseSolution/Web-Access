#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogFilterRow.cs
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

    [ConnectionKey("Administration"), TableName("[dbo].[LookupDialogFilter]")]
    [DisplayName("Lookup Dialog Filter"), InstanceName("Lookup Dialog Filter"), TwoLevelCached]   
    public sealed class LookupDialogFilterRow : Row, IIdRow, INameRow
    {
        [DisplayName("Lookup Name"), Size(64), PrimaryKey, ForeignKey("[dbo].[LookupDialog]", "LookupName"), LeftJoin("jLookupName"), QuickSearch, TextualField("LookupNameDescription")]
        public String LookupName
        {
            get { return Fields.LookupName[this]; }
            set { Fields.LookupName[this] = value; }
        }

        [DisplayName("Filter Name"), Size(32), PrimaryKey]
        public String FilterName
        {
            get { return Fields.FilterName[this]; }
            set { Fields.FilterName[this] = value; }
        }

        [DisplayName("Description"), Size(100)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Filter"), Size(1073741823)]
        public String Filter
        {
            get { return Fields.Filter[this]; }
            set { Fields.Filter[this] = value; }
        }

        [DisplayName("Lookup Name Description"), Expression("jLookupName.[Description]")]
        public String LookupNameDescription
        {
            get { return Fields.LookupNameDescription[this]; }
            set { Fields.LookupNameDescription[this] = value; }
        }

        [DisplayName("Lookup Name Query Id"), Expression("jLookupName.[QueryId]")]
        public String LookupNameQueryId
        {
            get { return Fields.LookupNameQueryId[this]; }
            set { Fields.LookupNameQueryId[this] = value; }
        }

        [DisplayName("Lookup Name Key Field1"), Expression("jLookupName.[KeyField1]")]
        public String LookupNameKeyField1
        {
            get { return Fields.LookupNameKeyField1[this]; }
            set { Fields.LookupNameKeyField1[this] = value; }
        }

        [DisplayName("Lookup Name Key Field2"), Expression("jLookupName.[KeyField2]")]
        public String LookupNameKeyField2
        {
            get { return Fields.LookupNameKeyField2[this]; }
            set { Fields.LookupNameKeyField2[this] = value; }
        }

        [DisplayName("Lookup Name Key Field3"), Expression("jLookupName.[KeyField3]")]
        public String LookupNameKeyField3
        {
            get { return Fields.LookupNameKeyField3[this]; }
            set { Fields.LookupNameKeyField3[this] = value; }
        }

        [DisplayName("Lookup Name Suspended"), Expression("jLookupName.[Suspended]")]
        public Boolean? LookupNameSuspended
        {
            get { return Fields.LookupNameSuspended[this]; }
            set { Fields.LookupNameSuspended[this] = value; }
        }

        [DisplayName("Lookup Name Created By"), Expression("jLookupName.[CreatedBy]")]
        public String LookupNameCreatedBy
        {
            get { return Fields.LookupNameCreatedBy[this]; }
            set { Fields.LookupNameCreatedBy[this] = value; }
        }

        [DisplayName("Lookup Name Created Date"), Expression("jLookupName.[CreatedDate]")]
        public DateTime? LookupNameCreatedDate
        {
            get { return Fields.LookupNameCreatedDate[this]; }
            set { Fields.LookupNameCreatedDate[this] = value; }
        }

        [DisplayName("Lookup Name Revised By"), Expression("jLookupName.[RevisedBy]")]
        public String LookupNameRevisedBy
        {
            get { return Fields.LookupNameRevisedBy[this]; }
            set { Fields.LookupNameRevisedBy[this] = value; }
        }

        [DisplayName("Lookup Name Revised Date"), Expression("jLookupName.[RevisedDate]")]
        public DateTime? LookupNameRevisedDate
        {
            get { return Fields.LookupNameRevisedDate[this]; }
            set { Fields.LookupNameRevisedDate[this] = value; }
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

        public LookupDialogFilterRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField LookupName;
            public StringField FilterName;
            public StringField Description;
            public StringField Filter;

            public StringField LookupNameDescription;
            public StringField LookupNameQueryId;
            public StringField LookupNameKeyField1;
            public StringField LookupNameKeyField2;
            public StringField LookupNameKeyField3;
            public BooleanField LookupNameSuspended;
            public StringField LookupNameCreatedBy;
            public DateTimeField LookupNameCreatedDate;
            public StringField LookupNameRevisedBy;
            public DateTimeField LookupNameRevisedDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.LookupDialogFilter";
            }
        }
    }
}
