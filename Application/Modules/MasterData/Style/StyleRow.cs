#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StyleRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBSTYL]")]
    [DisplayName("Style"), InstanceName("Style"), TwoLevelCached]   
    public sealed class StyleRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Collection Code"), Column("COLLECTION_CODE"), Size(30), QuickSearch]
        public String CollectionCode
        {
            get { return Fields.CollectionCode[this]; }
            set { Fields.CollectionCode[this] = value; }
        }

        [DisplayName("Style Code"), Column("STYLE_CODE"), Size(30), PrimaryKey]
        public String StyleCode
        {
            get { return Fields.StyleCode[this]; }
            set { Fields.StyleCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(120)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Chinese Description"), Column("CHINESE_DESCRIPTION"), Size(120)]
        public String ChineseDescription
        {
            get { return Fields.ChineseDescription[this]; }
            set { Fields.ChineseDescription[this] = value; }
        }

        [DisplayName("Die Cutter"), Column("DIE_CUTTER"), Size(16), Scale(2)]
        public Decimal? DieCutter
        {
            get { return Fields.DieCutter[this]; }
            set { Fields.DieCutter[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CollectionCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public StyleRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField CollectionCode;
            public StringField StyleCode;
            public StringField Description;
            public StringField ChineseDescription;
            public DecimalField DieCutter;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Style";
            }
        }
    }
}
