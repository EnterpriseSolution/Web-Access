#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ReportDialogOptionItemRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.EnterpriseSys.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey(SiteInitialization.Database), TableName("[dbo].[ReportDialogOptionItem]")]
    [DisplayName("Report Dialog Option Item"), InstanceName("Report Dialog Option Item"), TwoLevelCached]
    public sealed class ReportDialogOptionItemRow : Row, IIdRow, INameRow
    {
        [DisplayName("Report Id"), Size(16), PrimaryKey, QuickSearch]
        public String ReportId
        {
            get { return Fields.ReportId[this]; }
            set { Fields.ReportId[this] = value; }
        }

        [DisplayName("Option No"), PrimaryKey]
        public Int32? OptionNo
        {
            get { return Fields.OptionNo[this]; }
            set { Fields.OptionNo[this] = value; }
        }

        [DisplayName("Entry No"), PrimaryKey]
        public Int32? EntryNo
        {
            get { return Fields.EntryNo[this]; }
            set { Fields.EntryNo[this] = value; }
        }

        [DisplayName("Caption"), Size(30)]
        public String Caption
        {
            get { return Fields.Caption[this]; }
            set { Fields.Caption[this] = value; }
        }

        [DisplayName("Value"), Size(50)]
        public String Value
        {
            get { return Fields.Value[this]; }
            set { Fields.Value[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ReportId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ReportId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ReportDialogOptionItemRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public StringField ReportId;
            public Int32Field OptionNo;
            public Int32Field EntryNo;
            public StringField Caption;
            public StringField Value;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "EnterpriseSys.ReportDialogOptionItem";
            }
        }
    }
}
