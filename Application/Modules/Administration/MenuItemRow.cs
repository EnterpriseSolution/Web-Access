#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MenuItemRow.cs
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

    [ConnectionKey(SiteInitialization.Database), TableName("[dbo].[UserGroupMenuDetail]")]
    [DisplayName("Menu Item"), InstanceName("Menu Item"), TwoLevelCached]
    public sealed class MenuItemRow : Row, IIdRow, INameRow
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

        [DisplayName("Function Code"), Column("FUNCTION_CODE"), Size(8), NotNull]
        public String FunctionCode
        {
            get { return Fields.FunctionCode[this]; }
            set { Fields.FunctionCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(100)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Menu Type"), Column("MENU_TYPE"), Size(6), PrimaryKey]
        public String MenuType
        {
            get { return Fields.MenuType[this]; }
            set { Fields.MenuType[this] = value; }
        }

        [DisplayName("Menu Code"), Column("MENU_CODE"), Size(8), PrimaryKey]
        public String MenuCode
        {
            get { return Fields.MenuCode[this]; }
            set { Fields.MenuCode[this] = value; }
        }

        [DisplayName("Ul Row"), Column("UL_ROW")]
        public Int16? UlRow
        {
            get { return Fields.UlRow[this]; }
            set { Fields.UlRow[this] = value; }
        }

        [DisplayName("Ul Col"), Column("UL_COL")]
        public Int16? UlCol
        {
            get { return Fields.UlCol[this]; }
            set { Fields.UlCol[this] = value; }
        }

        [DisplayName("Lr Row"), Column("LR_ROW")]
        public Int16? LrRow
        {
            get { return Fields.LrRow[this]; }
            set { Fields.LrRow[this] = value; }
        }

        [DisplayName("Lr Col"), Column("LR_COL")]
        public Int16? LrCol
        {
            get { return Fields.LrCol[this]; }
            set { Fields.LrCol[this] = value; }
        }

        [DisplayName("Response Type"), Column("RESPONSE_TYPE"), Size(10)]
        public String ResponseType
        {
            get { return Fields.ResponseType[this]; }
            set { Fields.ResponseType[this] = value; }
        }

        [DisplayName("Policy Code"), Column("POLICY_CODE"), Size(12)]
        public String PolicyCode
        {
            get { return Fields.PolicyCode[this]; }
            set { Fields.PolicyCode[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }


        //[DisplayName("Extension"), Column("EXTENSION"), Size(400)]
        //public String Extension
        //{
        //    get { return Fields.Extension[this]; }
        //    set { Fields.Extension[this] = value; }
        //}
        
        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.UserGroup; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MenuItemRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Recnum;
            public StringField UserGroup;
            public StringField ProcessCode;
            public StringField FunctionCode;
            public StringField Description;
            public StringField MenuType;
            public StringField MenuCode;
            public Int16Field UlRow;
            public Int16Field UlCol;
            public Int16Field LrRow;
            public Int16Field LrCol;
            public StringField ResponseType;
            public StringField PolicyCode;
            public StringField Suspended;
            //public StringField Extension;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "EnterpriseSys.MenuItem";
            }
        }
    }
}
