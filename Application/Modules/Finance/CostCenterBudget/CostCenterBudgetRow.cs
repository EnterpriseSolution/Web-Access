#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CostCenterBudgetRow.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Finance"), TableName("[dbo].[GLBUDGC]")]
    [DisplayName("Cost Center Budget"), InstanceName("Cost Center Budget"), TwoLevelCached]   
    public sealed class CostCenterBudgetRow : Row, IIdRow, INameRow
    {
        [DisplayName("Recnum"), Column("RECNUM"), Size(28), Identity]
        public Decimal? Recnum
        {
            get { return Fields.Recnum[this]; }
            set { Fields.Recnum[this] = value; }
        }

        [DisplayName("Acct No"), Column("ACCT_NO"), Size(30), PrimaryKey, QuickSearch]
        public String AcctNo
        {
            get { return Fields.AcctNo[this]; }
            set { Fields.AcctNo[this] = value; }
        }

        [DisplayName("Cost Centre"), Column("COST_CENTRE"), Size(4), PrimaryKey]
        public String CostCentre
        {
            get { return Fields.CostCentre[this]; }
            set { Fields.CostCentre[this] = value; }
        }

        [DisplayName("Period"), Column("PERIOD"), Size(7), PrimaryKey]
        public String Period
        {
            get { return Fields.Period[this]; }
            set { Fields.Period[this] = value; }
        }

        [DisplayName("Fiscal Year"), Column("FISCAL_YEAR"), Size(4)]
        public Decimal? FiscalYear
        {
            get { return Fields.FiscalYear[this]; }
            set { Fields.FiscalYear[this] = value; }
        }

        [DisplayName("Period No"), Column("PERIOD_NO"), Size(2)]
        public Decimal? PeriodNo
        {
            get { return Fields.PeriodNo[this]; }
            set { Fields.PeriodNo[this] = value; }
        }

        [DisplayName("Total Debit"), Column("TOTAL_DEBIT"), Size(16), Scale(2)]
        public Decimal? TotalDebit
        {
            get { return Fields.TotalDebit[this]; }
            set { Fields.TotalDebit[this] = value; }
        }

        [DisplayName("Total Credit"), Column("TOTAL_CREDIT"), Size(16), Scale(2)]
        public Decimal? TotalCredit
        {
            get { return Fields.TotalCredit[this]; }
            set { Fields.TotalCredit[this] = value; }
        }

        [DisplayName("Control Debit"), Column("CONTROL_DEBIT")]
        public Boolean? ControlDebit
        {
            get { return Fields.ControlDebit[this]; }
            set { Fields.ControlDebit[this] = value; }
        }

        [DisplayName("Control Credit"), Column("CONTROL_CREDIT")]
        public Boolean? ControlCredit
        {
            get { return Fields.ControlCredit[this]; }
            set { Fields.ControlCredit[this] = value; }
        }

        [DisplayName("Budget Debit"), Column("BUDGET_DEBIT"), Size(16), Scale(2)]
        public Decimal? BudgetDebit
        {
            get { return Fields.BudgetDebit[this]; }
            set { Fields.BudgetDebit[this] = value; }
        }

        [DisplayName("Budget Credit"), Column("BUDGET_CREDIT"), Size(16), Scale(2)]
        public Decimal? BudgetCredit
        {
            get { return Fields.BudgetCredit[this]; }
            set { Fields.BudgetCredit[this] = value; }
        }

        [DisplayName("Budget Date"), Column("BUDGET_DATE")]
        public DateTime? BudgetDate
        {
            get { return Fields.BudgetDate[this]; }
            set { Fields.BudgetDate[this] = value; }
        }

        [DisplayName("Budget By"), Column("BUDGET_BY"), Size(10)]
        public String BudgetBy
        {
            get { return Fields.BudgetBy[this]; }
            set { Fields.BudgetBy[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Recnum; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.AcctNo; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public CostCenterBudgetRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public DecimalField Recnum;
            public StringField AcctNo;
            public StringField CostCentre;
            public StringField Period;
            public DecimalField FiscalYear;
            public DecimalField PeriodNo;
            public DecimalField TotalDebit;
            public DecimalField TotalCredit;
            public BooleanField ControlDebit;
            public BooleanField ControlCredit;
            public DecimalField BudgetDebit;
            public DecimalField BudgetCredit;
            public DateTimeField BudgetDate;
            public StringField BudgetBy;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Finance.CostCenterBudget";
            }
        }
    }
}
