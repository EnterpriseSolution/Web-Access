#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  TabRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBTABH]")]
    [DisplayName("Tab"), InstanceName("Tab"), TwoLevelCached]   
    public sealed class TabRow : Row, IIdRow, INameRow
    {
        [DisplayName("Tabid"), Column("TABID"), PrimaryKey]
        public Int32? Tabid
        {
            get { return Fields.Tabid[this]; }
            set { Fields.Tabid[this] = value; }
        }

        [DisplayName("Caption"), Column("CAPTION"), Size(40), NotNull, QuickSearch]
        public String Caption
        {
            get { return Fields.Caption[this]; }
            set { Fields.Caption[this] = value; }
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

        IIdField IIdRow.IdField
        {
            get { return Fields.Tabid; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Caption; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public TabRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Tabid;
            public StringField Caption;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Tab";
            }
        }
    }
}
