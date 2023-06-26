#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountReconciliationForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.AccountReconciliation")]
    [BasedOnRow(typeof(Entities.AccountReconciliationRow))]
    public class AccountReconciliationForm
    {
        public String AcctNo { get; set; }
        public String RefNo { get; set; }
        public String Posted { get; set; }
        public String AcctName { get; set; }
        public DateTime TranDate { get; set; }
        public Decimal BeginAmt { get; set; }
        public String BeginSign { get; set; }
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }
        public Decimal AllocDebit { get; set; }
        public Decimal AllocCredit { get; set; }
        public Decimal AdjustDebit { get; set; }
        public Decimal AdjustCredit { get; set; }
        public Decimal EndAmt { get; set; }
        public String EndSign { get; set; }
        public Decimal EndAllocAmt { get; set; }
        public String EndAllocSign { get; set; }
        public Decimal DetailCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public DateTime CutoffDate { get; set; }
        public DateTime PostedDate { get; set; }
        public String PostedBy { get; set; }
    }
}