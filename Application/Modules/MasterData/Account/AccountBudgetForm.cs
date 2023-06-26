#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountBudgetForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.MasterData.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.AccountBudget")]
    [BasedOnRow(typeof(Entities.AccountBudgetRow))]
    public class AccountBudgetForm
    {
        public String AcctNo { get; set; }
        public String Period { get; set; }
        public Decimal FiscalYear { get; set; }
        public Decimal PeriodNo { get; set; }
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }
        public String ControlDebit { get; set; }
        public String ControlCredit { get; set; }
        public Decimal BudgetDebit { get; set; }
        public Decimal BudgetCredit { get; set; }
        public DateTime BudgetDate { get; set; }
        public String BudgetBy { get; set; }
    }
}