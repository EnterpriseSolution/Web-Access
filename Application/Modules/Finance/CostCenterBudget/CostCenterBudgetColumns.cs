#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CostCenterBudgetColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Finance.CostCenterBudget")]
    [BasedOnRow(typeof(Entities.CostCenterBudgetRow))]
    public class CostCenterBudgetColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String AcctNo { get; set; }
        public String CostCentre { get; set; }
        public String Period { get; set; }

        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        public Decimal BudgetDebit { get; set; }
        public Decimal BudgetCredit { get; set; }
        public DateTime BudgetDate { get; set; }
        public String BudgetBy { get; set; }

        public Boolean ControlDebit { get; set; }
        public Decimal TotalDebit { get; set; }
        public Boolean ControlCredit { get; set; }
        public Decimal TotalCredit { get; set; }
    }
}