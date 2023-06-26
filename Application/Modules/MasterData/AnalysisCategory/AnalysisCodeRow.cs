#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AnalysisCodeRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GBANCO]")]
    [DisplayName("Analysis Code"), InstanceName("Analysis Code"), TwoLevelCached]   
    public sealed class AnalysisCodeRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Category"), Column("CATEGORY"), Size(30), PrimaryKey, ForeignKey("[dbo].[GBANTL]", "CATEGORY"), LeftJoin("jCategory"), QuickSearch, TextualField("CategoryDescription")]
        public String Category
        {
            get { return Fields.Category[this]; }
            set { Fields.Category[this] = value; }
        }

        [DisplayName("Analysis Code"), Column("ANALYSIS_CODE"), Size(30), PrimaryKey]
        public String AnalysisCode
        {
            get { return Fields.AnalysisCode[this]; }
            set { Fields.AnalysisCode[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(40), NotNull]
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

        [DisplayName("Owner Branch"), Column("OWNER_BRANCH"), Size(4)]
        public String OwnerBranch
        {
            get { return Fields.OwnerBranch[this]; }
            set { Fields.OwnerBranch[this] = value; }
        }

        [DisplayName("Source Branch"), Column("SOURCE_BRANCH"), Size(4)]
        public String SourceBranch
        {
            get { return Fields.SourceBranch[this]; }
            set { Fields.SourceBranch[this] = value; }
        }

        [DisplayName("Category Recnum"), Expression("jCategory.[RECNUM]")]
        public Decimal? CategoryRecnum
        {
            get { return Fields.CategoryRecnum[this]; }
            set { Fields.CategoryRecnum[this] = value; }
        }

        [DisplayName("Category Description"), Expression("jCategory.[DESCRIPTION]")]
        public String CategoryDescription
        {
            get { return Fields.CategoryDescription[this]; }
            set { Fields.CategoryDescription[this] = value; }
        }

        [DisplayName("Category Caption"), Expression("jCategory.[CAPTION]")]
        public String CategoryCaption
        {
            get { return Fields.CategoryCaption[this]; }
            set { Fields.CategoryCaption[this] = value; }
        }

        [DisplayName("Category Created Date"), Expression("jCategory.[CREATED_DATE]")]
        public DateTime? CategoryCreatedDate
        {
            get { return Fields.CategoryCreatedDate[this]; }
            set { Fields.CategoryCreatedDate[this] = value; }
        }

        [DisplayName("Category Created By"), Expression("jCategory.[CREATED_BY]")]
        public String CategoryCreatedBy
        {
            get { return Fields.CategoryCreatedBy[this]; }
            set { Fields.CategoryCreatedBy[this] = value; }
        }

        [DisplayName("Category Revised Date"), Expression("jCategory.[REVISED_DATE]")]
        public DateTime? CategoryRevisedDate
        {
            get { return Fields.CategoryRevisedDate[this]; }
            set { Fields.CategoryRevisedDate[this] = value; }
        }

        [DisplayName("Category Revised By"), Expression("jCategory.[REVISED_BY]")]
        public String CategoryRevisedBy
        {
            get { return Fields.CategoryRevisedBy[this]; }
            set { Fields.CategoryRevisedBy[this] = value; }
        }

        [DisplayName("Category Owner Branch"), Expression("jCategory.[OWNER_BRANCH]")]
        public String CategoryOwnerBranch
        {
            get { return Fields.CategoryOwnerBranch[this]; }
            set { Fields.CategoryOwnerBranch[this] = value; }
        }

        [DisplayName("Category Source Branch"), Expression("jCategory.[SOURCE_BRANCH]")]
        public String CategorySourceBranch
        {
            get { return Fields.CategorySourceBranch[this]; }
            set { Fields.CategorySourceBranch[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Category; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public AnalysisCodeRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField Category;
            public StringField AnalysisCode;
            public StringField Description;
            public StringField Suspended;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;

            public DecimalField CategoryRecnum;
            public StringField CategoryDescription;
            public StringField CategoryCaption;
            public DateTimeField CategoryCreatedDate;
            public StringField CategoryCreatedBy;
            public DateTimeField CategoryRevisedDate;
            public StringField CategoryRevisedBy;
            public StringField CategoryOwnerBranch;
            public StringField CategorySourceBranch;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.AnalysisCode";
            }
        }
    }
}
