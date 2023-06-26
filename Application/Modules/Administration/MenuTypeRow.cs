#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MenuTypeRow.cs
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

    [ConnectionKey(SiteInitialization.Database), TableName("[dbo].[UserGroupMenuType]")]
    [DisplayName("Menu Type"), InstanceName("Menu Type"), TwoLevelCached]
    public sealed class MenuTypeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Int32? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("User Group"), Column("USER_GROUP"), Size(10), PrimaryKey, QuickSearch]
        public String UserGroup
        {
            get { return Fields.UserGroup[this]; }
            set { Fields.UserGroup[this] = value; }
        }

        [DisplayName("Process Code"), Column("PROCESS_CODE"), Size(8), PrimaryKey]
        public String ProcessCode
        {
            get { return Fields.ProcessCode[this]; }
            set { Fields.ProcessCode[this] = value; }
        }

        [DisplayName("Menu Type"), Column("MENU_TYPE"), Size(6), PrimaryKey]
        public String MenuType
        {
            get { return Fields.MenuType[this]; }
            set { Fields.MenuType[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Menu Code"), Column("MENU_CODE"), Size(8), NotNull]
        public String MenuCode
        {
            get { return Fields.MenuCode[this]; }
            set { Fields.MenuCode[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Close Icon"), Column("CLOSE_ICON"), Size(4)]
        public Decimal? CloseIcon
        {
            get { return Fields.CloseIcon[this]; }
            set { Fields.CloseIcon[this] = value; }
        }

        [DisplayName("Open Icon"), Column("OPEN_ICON"), Size(4)]
        public Decimal? OpenIcon
        {
            get { return Fields.OpenIcon[this]; }
            set { Fields.OpenIcon[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.UserGroup; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MenuTypeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Recnum;
            public StringField UserGroup;
            public StringField ProcessCode;
            public StringField MenuType;
            public StringField Description;
            public StringField MenuCode;
            public StringField Suspended;
            public DecimalField CloseIcon;
            public DecimalField OpenIcon;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "EnterpriseSys.MenuType";
            }
        }
    }
}
