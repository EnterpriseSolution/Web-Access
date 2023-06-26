#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LookupDialogFilterColumnDetailRow.cs
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

    [ConnectionKey("Administration"), TableName("[dbo].[LookupDialogFilterColumnDetail]")]
    [DisplayName("Lookup Dialog Filter Column Detail"), InstanceName("Lookup Dialog Filter Column Detail"), TwoLevelCached]   
    public sealed class LookupDialogFilterColumnDetailRow : Row, IIdRow, INameRow
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

        [DisplayName("Field Name"), Size(64), NotNull]
        public String FieldName
        {
            get { return Fields.FieldName[this]; }
            set { Fields.FieldName[this] = value; }
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

        public LookupDialogFilterColumnDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField LookupName;
            public StringField FilterName;
            public Int32Field EntryNo;
            public StringField FieldName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.LookupDialogFilterColumnDetail";
            }
        }
    }
}
