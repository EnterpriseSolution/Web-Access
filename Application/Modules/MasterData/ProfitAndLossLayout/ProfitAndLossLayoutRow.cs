#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ProfitAndLossLayoutRow.cs
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

    [ConnectionKey("MasterData"), TableName("[dbo].[GLFINP]")]
    [DisplayName("Profit And Loss Statement Layout"), InstanceName("Profit And Loss Layout"), TwoLevelCached]   
    public sealed class ProfitAndLossLayoutRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(8), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Line No"), Column("LINE_NO"), Size(6), PrimaryKey]
        public Decimal? LineNo
        {
            get { return Fields.LineNo[this]; }
            set { Fields.LineNo[this] = value; }
        }

        [DisplayName("Line Type"), Column("LINE_TYPE"), Size(2), QuickSearch]
        public String LineType
        {
            get { return Fields.LineType[this]; }
            set { Fields.LineType[this] = value; }
        }

        [DisplayName("Line Skip"), Column("LINE_SKIP"), Size(2)]
        public Decimal? LineSkip
        {
            get { return Fields.LineSkip[this]; }
            set { Fields.LineSkip[this] = value; }
        }

        [DisplayName("Description"), Column("DESCRIPTION"), Size(30)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("Acct From"), Column("ACCT_FROM"), Size(30)]
        public String AcctFrom
        {
            get { return Fields.AcctFrom[this]; }
            set { Fields.AcctFrom[this] = value; }
        }

        [DisplayName("Acct To"), Column("ACCT_TO"), Size(30)]
        public String AcctTo
        {
            get { return Fields.AcctTo[this]; }
            set { Fields.AcctTo[this] = value; }
        }

        [DisplayName("Acct Operator"), Column("ACCT_OPERATOR"), Size(1)]
        public String AcctOperator
        {
            get { return Fields.AcctOperator[this]; }
            set { Fields.AcctOperator[this] = value; }
        }

        [DisplayName("Total Level"), Column("TOTAL_LEVEL"), Size(2)]
        public Decimal? TotalLevel
        {
            get { return Fields.TotalLevel[this]; }
            set { Fields.TotalLevel[this] = value; }
        }

        [DisplayName("Normal Sign"), Column("NORMAL_SIGN"), Size(1)]
        public String NormalSign
        {
            get { return Fields.NormalSign[this]; }
            set { Fields.NormalSign[this] = value; }
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

        [DisplayName("Report"), Column("REPORT"), Size(1)]
        public String Report
        {
            get { return Fields.Report[this]; }
            set { Fields.Report[this] = value; }
        }

        [DisplayName("Cell Line No"), Column("CELL_LINE_NO"), Size(6)]
        public Decimal? CellLineNo
        {
            get { return Fields.CellLineNo[this]; }
            set { Fields.CellLineNo[this] = value; }
        }

        [DisplayName("Cell Value Period"), Column("CELL_VALUE_PERIOD"), Size(6)]
        public String CellValuePeriod
        {
            get { return Fields.CellValuePeriod[this]; }
            set { Fields.CellValuePeriod[this] = value; }
        }

        [DisplayName("Cell Value Fiscal Year"), Column("CELL_VALUE_FISCAL_YEAR"), Size(6)]
        public String CellValueFiscalYear
        {
            get { return Fields.CellValueFiscalYear[this]; }
            set { Fields.CellValueFiscalYear[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.LineType; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ProfitAndLossLayoutRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public DecimalField LineNo;
            public StringField LineType;
            public DecimalField LineSkip;
            public StringField Description;
            public StringField AcctFrom;
            public StringField AcctTo;
            public StringField AcctOperator;
            public DecimalField TotalLevel;
            public StringField NormalSign;
            public DateTimeField CreatedDate;
            public StringField CreatedBy;
            public DateTimeField RevisedDate;
            public StringField RevisedBy;
            public StringField OwnerBranch;
            public StringField SourceBranch;
            public StringField Report;
            public DecimalField CellLineNo;
            public StringField CellValuePeriod;
            public StringField CellValueFiscalYear;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "MasterData.ProfitAndLossLayout";
            }
        }
    }
}
