#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CostCenterBudgetForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.CostCenterBudget")]
    [BasedOnRow(typeof(Entities.CostCenterBudgetRow))]
    public class CostCenterBudgetForm
    {
        public String AcctNo { get; set; }
        public String CostCentre { get; set; }
        public String Period { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        [Category(CategoryName.Budget)]
        public Decimal BudgetDebit { get; set; }
        public Decimal BudgetCredit { get; set; }
        public DateTime BudgetDate { get; set; }
        public String BudgetBy { get; set; }

        [Category(CategoryName.TransactionVoucher)]
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }
        public Boolean ControlDebit { get; set; }
        public Boolean ControlCredit { get; set; }
    }
}