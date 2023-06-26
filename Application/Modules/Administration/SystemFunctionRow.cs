#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SystemFunctionRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprisesys.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey(SiteInitialization.Database), TableName("[dbo].[SystemFunction]")]
    [DisplayName("System Function"), InstanceName("System Function"), TwoLevelCached]
    public sealed class SystemFunctionRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Module Code"), Column("MODULE_CODE"), Size(4), PrimaryKey, ForeignKey("[dbo].[ADMODU]", "MODULE_CODE"), LeftJoin("jModuleCode"), QuickSearch, TextualField("ModuleCodeDescription")]
        public String ModuleCode
        {
            get { return Fields.ModuleCode[this]; }
            set { Fields.ModuleCode[this] = value; }
        }

        [DisplayName("Function No"), Column("FUNCTION_NO"), PrimaryKey]
        public Int16? FunctionNo
        {
            get { return Fields.FunctionNo[this]; }
            set { Fields.FunctionNo[this] = value; }
        }

        [DisplayName("Function Code"), Column("FUNCTION_CODE"), Size(8), NotNull]
        public String FunctionCode
        {
            get { return Fields.FunctionCode[this]; }
            set { Fields.FunctionCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(100), NotNull]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Suspended"), Column("SUSPENDED"), Size(1)]
        public String Suspended
        {
            get { return Fields.Suspended[this]; }
            set { Fields.Suspended[this] = value; }
        }

        [DisplayName("Series Option"), Column("SERIES_OPTION"), Size(1), NotNull]
        public String SeriesOption
        {
            get { return Fields.SeriesOption[this]; }
            set { Fields.SeriesOption[this] = value; }
        }

        [DisplayName("Series Code"), Column("SERIES_CODE"), Size(8)]
        public String SeriesCode
        {
            get { return Fields.SeriesCode[this]; }
            set { Fields.SeriesCode[this] = value; }
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

        [DisplayName("Icon"), Column("ICON"), Size(4)]
        public Decimal? Icon
        {
            get { return Fields.Icon[this]; }
            set { Fields.Icon[this] = value; }
        }

        [DisplayName("File"), Column("FILE"), Size(60)]
        public String File
        {
            get { return Fields.File[this]; }
            set { Fields.File[this] = value; }
        }

        [DisplayName("Page"), Column("PAGE"), Size(4)]
        public Decimal? Page
        {
            get { return Fields.Page[this]; }
            set { Fields.Page[this] = value; }
        }

        [DisplayName("Attachment"), Column("ATTACHMENT"), Size(1)]
        public String Attachment
        {
            get { return Fields.Attachment[this]; }
            set { Fields.Attachment[this] = value; }
        }

        [DisplayName("Extension"), Column("EXTENSION"), Size(400)]
        public String Extension
        {
            get { return Fields.Extension[this]; }
            set { Fields.Extension[this] = value; }
        }

        [DisplayName("Module Code Recnum"), Expression("jModuleCode.[RECNUM]")]
        public Decimal? ModuleCodeRecnum
        {
            get { return Fields.ModuleCodeRecnum[this]; }
            set { Fields.ModuleCodeRecnum[this] = value; }
        }

        [DisplayName("Module Code Description"), Expression("jModuleCode.[DESCRIPTION]")]
        public String ModuleCodeDescription
        {
            get { return Fields.ModuleCodeDescription[this]; }
            set { Fields.ModuleCodeDescription[this] = value; }
        }

        [DisplayName("Module Code Desktop Bmp"), Expression("jModuleCode.[DESKTOP_BMP]")]
        public String ModuleCodeDesktopBmp
        {
            get { return Fields.ModuleCodeDesktopBmp[this]; }
            set { Fields.ModuleCodeDesktopBmp[this] = value; }
        }

        [DisplayName("Module Code Installed"), Expression("jModuleCode.[INSTALLED]")]
        public String ModuleCodeInstalled
        {
            get { return Fields.ModuleCodeInstalled[this]; }
            set { Fields.ModuleCodeInstalled[this] = value; }
        }

        [DisplayName("Module Code Last Line No"), Expression("jModuleCode.[LAST_LINE_NO]")]
        public Int16? ModuleCodeLastLineNo
        {
            get { return Fields.ModuleCodeLastLineNo[this]; }
            set { Fields.ModuleCodeLastLineNo[this] = value; }
        }

        [DisplayName("Module Code Created Date"), Expression("jModuleCode.[CREATED_DATE]")]
        public DateTime? ModuleCodeCreatedDate
        {
            get { return Fields.ModuleCodeCreatedDate[this]; }
            set { Fields.ModuleCodeCreatedDate[this] = value; }
        }

        [DisplayName("Module Code Created By"), Expression("jModuleCode.[CREATED_BY]")]
        public String ModuleCodeCreatedBy
        {
            get { return Fields.ModuleCodeCreatedBy[this]; }
            set { Fields.ModuleCodeCreatedBy[this] = value; }
        }

        [DisplayName("Module Code Revised Date"), Expression("jModuleCode.[REVISED_DATE]")]
        public DateTime? ModuleCodeRevisedDate
        {
            get { return Fields.ModuleCodeRevisedDate[this]; }
            set { Fields.ModuleCodeRevisedDate[this] = value; }
        }

        [DisplayName("Module Code Revised By"), Expression("jModuleCode.[REVISED_BY]")]
        public String ModuleCodeRevisedBy
        {
            get { return Fields.ModuleCodeRevisedBy[this]; }
            set { Fields.ModuleCodeRevisedBy[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.FunctionCode; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Description; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SystemFunctionRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField ModuleCode;
            public Int16Field FunctionNo;
            public StringField FunctionCode;
            public StringField Description;
            public StringField Suspended;
            public StringField SeriesOption;
            public StringField SeriesCode;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public DecimalField Icon;
            public StringField File;
            public DecimalField Page;
            public StringField Attachment;
            public StringField Extension;

            public DecimalField ModuleCodeRecnum;
            public StringField ModuleCodeDescription;
            public StringField ModuleCodeDesktopBmp;
            public StringField ModuleCodeInstalled;
            public Int16Field ModuleCodeLastLineNo;
            public DateTimeField ModuleCodeCreatedDate;
            public StringField ModuleCodeCreatedBy;
            public DateTimeField ModuleCodeRevisedDate;
            public StringField ModuleCodeRevisedBy;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Enterprisesys.SystemFunction";
            }
        }
    }
}
