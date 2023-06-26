#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ColorRow.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.AdminLTE.Audit.Tranzol.Modules.Common.BaseClass;

namespace Matrix.MasterData.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    /*
        Inherit your RowClass with interface IAuditLog. 
    This will automatically pic the identity column to have insert in audit log.

        If you do not have Identity Column or need any other column to keep reference in audit 
        table then use IExAuditLog and assign the field.

        If you want not to log any field in audit then use IgnoreAuditLog attribute on the field. 
        For example: Do not need to log logging field like InsertUserId, InsertDate, UpdateUserId, 
        UpdateDate because that will already tracked by audit table.

        [NotNull, Insertable(false), Updatable(false), IgnoreAuditLog]
        [ForeignKey("[dbo].[Users]", "Id"), LeftJoin("jCreatedByUserDetails"), TextualField("CreatedByUserName")]
        public Int32? InsertUserId
        {
            get { return loggingFields.InsertUserId[this]; }
            set { loggingFields.InsertUserId[this] = value; }
        }

    */

    [ConnectionKey("MasterData"), TableName("[dbo].[GBCOLR]")]
    [DisplayName("Color"), InstanceName("Color"), TwoLevelCached]   
    public sealed class ColorRow : Row, IIdRow, INameRow, IAuditLog
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Color Code"), Column("COLOR_CODE"), Size(30), PrimaryKey, QuickSearch]
        public String ColorCode
        {
            get { return Fields.ColorCode[this]; }
            set { Fields.ColorCode[this] = value; }
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

        [DisplayName("Color Group"), Column("COLOR_GROUP"), Size(10), PrimaryKey]
        public String ColorGroup
        {
            get { return Fields.ColorGroup[this]; }
            set { Fields.ColorGroup[this] = value; }
        }

        [DisplayName("Item Group"), Column("ITEM_GROUP"), Size(10)]
        public String ItemGroup
        {
            get { return Fields.ItemGroup[this]; }
            set { Fields.ItemGroup[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ColorCode; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ColorRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ColorCode;
            public StringField Description;
            public StringField ChineseDescription;
            public StringField CreatedBy;
            public DateTimeField CreatedDate;
            public StringField RevisedBy;
            public DateTimeField RevisedDate;
            public StringField ColorGroup;
            public StringField ItemGroup;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.Color";
            }
        }
    }
}
