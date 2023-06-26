#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogFilterDetailRow.cs
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

    [ConnectionKey("Administration"), TableName("[dbo].[LookupDialogFilterDetail]")]
    [DisplayName("Lookup Dialog Filter Detail"), InstanceName("Lookup Dialog Filter Detail"), TwoLevelCached]   
    public sealed class LookupDialogFilterDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Lookup Name"), Size(64), PrimaryKey, QuickSearch]
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

        [DisplayName("Entry No"), PrimaryKey]
        public Int32? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Entity Name"), Size(64)]
        public String EntityName
        {
            get { return Fields.EntityName[this]; }
            set { Fields.EntityName[this] = value; }
        }

        [DisplayName("Field Name"), Size(64)]
        public String FieldName
        {
            get { return Fields.FieldName[this]; }
            set { Fields.FieldName[this] = value; }
        }

        [DisplayName("Field Value"), Size(64)]
        public String FieldValue
        {
            get { return Fields.FieldValue[this]; }
            set { Fields.FieldValue[this] = value; }
        }

        [DisplayName("Operator")]
        public Int32? Operator
        {
            get { return Fields.Operator[this]; }
            set { Fields.Operator[this] = value; }
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

        public LookupDialogFilterDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField LookupName;
            public StringField FilterName;
            public Int32Field EntryNo;
            public StringField EntityName;
            public StringField FieldName;
            public StringField FieldValue;
            public Int32Field Operator;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.LookupDialogFilterDetail";
            }
        }
    }
}
