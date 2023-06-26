#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  MenuRow.cs
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

    [ConnectionKey(SiteInitialization.Database), TableName("[dbo].[UserGroupMenu]")]
    [DisplayName("Menu"), InstanceName("Menu"), TwoLevelCached]
    public sealed class MenuRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Int32? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("User Group"), Column("USER_GROUP"), Size(10), PrimaryKey, ForeignKey("[dbo].[ADUGRP]", "USER_GROUP"), LeftJoin("jUserGroup"), QuickSearch, TextualField("UserGroupDescription")]
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

        [DisplayName("Description"), Column("DESCRIPTION"), Size(40)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Node"), Column("NODE"), Size(1)]
        public String Node
        {
            get { return Fields.Node[this]; }
            set { Fields.Node[this] = value; }
        }

        [DisplayName("Menu Code"), Column("MENU_CODE"), Size(8), NotNull]
        public String MenuCode
        {
            get { return Fields.MenuCode[this]; }
            set { Fields.MenuCode[this] = value; }
        }

        [DisplayName("Menu Level"), Column("MENU_LEVEL"), NotNull]
        public Int16? MenuLevel
        {
            get { return Fields.MenuLevel[this]; }
            set { Fields.MenuLevel[this] = value; }
        }

        [DisplayName("Image File"), Column("IMAGE_FILE"), Size(40)]
        public String ImageFile
        {
            get { return Fields.ImageFile[this]; }
            set { Fields.ImageFile[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Created Date"), Column("CREATED_DATE")]
        public DateTime? CreatedDate
        {
            get { return Fields.CreatedDate[this]; }
            set { Fields.CreatedDate[this] = value; }
        }

        [DisplayName("Created By"), Column("CREATED_BY"), Size(10)]
        public String CreatedBy
        {
            get { return Fields.CreatedBy[this]; }
            set { Fields.CreatedBy[this] = value; }
        }

        [DisplayName("Revised Date"), Column("REVISED_DATE")]
        public DateTime? RevisedDate
        {
            get { return Fields.RevisedDate[this]; }
            set { Fields.RevisedDate[this] = value; }
        }

        [DisplayName("Revised By"), Column("REVISED_BY"), Size(10)]
        public String RevisedBy
        {
            get { return Fields.RevisedBy[this]; }
            set { Fields.RevisedBy[this] = value; }
        }

        [DisplayName("Close Icon"), Column("CLOSE_ICON")]
        public Int16? CloseIcon
        {
            get { return Fields.CloseIcon[this]; }
            set { Fields.CloseIcon[this] = value; }
        }

        [DisplayName("Open Icon"), Column("OPEN_ICON")]
        public Int16? OpenIcon
        {
            get { return Fields.OpenIcon[this]; }
            set { Fields.OpenIcon[this] = value; }
        }

        [DisplayName("User Group Recnum"), Expression("jUserGroup.[RECNUM]")]
        public Decimal? UserGroupRecnum
        {
            get { return Fields.UserGroupRecnum[this]; }
            set { Fields.UserGroupRecnum[this] = value; }
        }

        [DisplayName("User Group Description"), Expression("jUserGroup.[DESCRIPTION]")]
        public String UserGroupDescription
        {
            get { return Fields.UserGroupDescription[this]; }
            set { Fields.UserGroupDescription[this] = value; }
        }

        [DisplayName("User Group Suspended"), Expression("jUserGroup.[SUSPENDED]")]
        public String UserGroupSuspended
        {
            get { return Fields.UserGroupSuspended[this]; }
            set { Fields.UserGroupSuspended[this] = value; }
        }

        [DisplayName("User Group Created Date"), Expression("jUserGroup.[CREATED_DATE]")]
        public DateTime? UserGroupCreatedDate
        {
            get { return Fields.UserGroupCreatedDate[this]; }
            set { Fields.UserGroupCreatedDate[this] = value; }
        }

        [DisplayName("User Group Created By"), Expression("jUserGroup.[CREATED_BY]")]
        public String UserGroupCreatedBy
        {
            get { return Fields.UserGroupCreatedBy[this]; }
            set { Fields.UserGroupCreatedBy[this] = value; }
        }

        [DisplayName("User Group Revised Date"), Expression("jUserGroup.[REVISED_DATE]")]
        public DateTime? UserGroupRevisedDate
        {
            get { return Fields.UserGroupRevisedDate[this]; }
            set { Fields.UserGroupRevisedDate[this] = value; }
        }

        [DisplayName("User Group Revised By"), Expression("jUserGroup.[REVISED_BY]")]
        public String UserGroupRevisedBy
        {
            get { return Fields.UserGroupRevisedBy[this]; }
            set { Fields.UserGroupRevisedBy[this] = value; }
        }

        [DisplayName("User Group Last Module No"), Expression("jUserGroup.[LAST_MODULE_NO]")]
        public Int32? UserGroupLastModuleNo
        {
            get { return Fields.UserGroupLastModuleNo[this]; }
            set { Fields.UserGroupLastModuleNo[this] = value; }
        }

        [DisplayName("User Group Email"), Expression("jUserGroup.[EMAIL]")]
        public String UserGroupEmail
        {
            get { return Fields.UserGroupEmail[this]; }
            set { Fields.UserGroupEmail[this] = value; }
        }

        [DisplayName("User Group View Only"), Expression("jUserGroup.[VIEW_ONLY]")]
        public Boolean? UserGroupViewOnly
        {
            get { return Fields.UserGroupViewOnly[this]; }
            set { Fields.UserGroupViewOnly[this] = value; }
        }

        [NotMapped]
        public int MenuCodeShort { get; set; }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.UserGroup; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public MenuRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Recnum;
            public StringField UserGroup;
            public StringField ProcessCode;
            public StringField Description;
            public StringField Node;
            public StringField MenuCode;
            public Int16Field MenuLevel;
            public StringField ImageFile;
            public StringField Suspended;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public Int16Field CloseIcon;
            public Int16Field OpenIcon;

            public DecimalField UserGroupRecnum;
            public StringField UserGroupDescription;
            public StringField UserGroupSuspended;
            public DateTimeField UserGroupCreatedDate;
            public StringField UserGroupCreatedBy;
            public DateTimeField UserGroupRevisedDate;
            public StringField UserGroupRevisedBy;
            public Int32Field UserGroupLastModuleNo;
            public StringField UserGroupEmail;
            public BooleanField UserGroupViewOnly;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "EnterpriseSys.Menu";
            }
        }
    }
}
