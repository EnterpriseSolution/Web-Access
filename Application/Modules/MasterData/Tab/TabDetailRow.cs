#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TabDetailRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBTABD]")]
    [DisplayName("Tab Detail"), InstanceName("Tab Detail"), TwoLevelCached]   
    public sealed class TabDetailRow : Row, IIdRow, INameRow
    {
        [DisplayName("Tabid"), Column("TABID"), PrimaryKey, ForeignKey("[dbo].[GBTABH]", "TABID"), LeftJoin("jTabid"), TextualField("TabidCaption")]
        public Int32? Tabid
        {
            get { return Fields.Tabid[this]; }
            set { Fields.Tabid[this] = value; }
        }

        [DisplayName("Item Group"), Column("ITEM_GROUP"), Size(10), PrimaryKey, QuickSearch]
        public String ItemGroup
        {
            get { return Fields.ItemGroup[this]; }
            set { Fields.ItemGroup[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(40), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE"), NotNull]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10), NotNull]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE"), NotNull]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10), NotNull]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Tabid Caption"), Expression("jTabid.[CAPTION]")]
        public String TabidCaption
        {
            get { return Fields.TabidCaption[this]; }
            set { Fields.TabidCaption[this] = value; }
        }

        [DisplayName("Tabid Created Date"), Expression("jTabid.[CREATED_DATE]")]
        public DateTime? TabidCreatedDate
        {
            get { return Fields.TabidCreatedDate[this]; }
            set { Fields.TabidCreatedDate[this] = value; }
        }

        [DisplayName("Tabid Created By"), Expression("jTabid.[CREATED_BY]")]
        public String TabidCreatedBy
        {
            get { return Fields.TabidCreatedBy[this]; }
            set { Fields.TabidCreatedBy[this] = value; }
        }

        [DisplayName("Tabid Revised Date"), Expression("jTabid.[REVISED_DATE]")]
        public DateTime? TabidRevisedDate
        {
            get { return Fields.TabidRevisedDate[this]; }
            set { Fields.TabidRevisedDate[this] = value; }
        }

        [DisplayName("Tabid Revised By"), Expression("jTabid.[REVISED_BY]")]
        public String TabidRevisedBy
        {
            get { return Fields.TabidRevisedBy[this]; }
            set { Fields.TabidRevisedBy[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Tabid; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ItemGroup; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TabDetailRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Tabid;
            public StringField ItemGroup;
            public StringField Description;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;

            public StringField TabidCaption;
            public DateTimeField TabidCreatedDate;
            public StringField TabidCreatedBy;
            public DateTimeField TabidRevisedDate;
            public StringField TabidRevisedBy;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.TabDetail";
            }
        }
    }
}
