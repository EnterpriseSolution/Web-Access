#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountReconciliationAdjustmentForm.cs
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

    [FormScript("Finance.AccountReconciliationAdjustment")]
    [BasedOnRow(typeof(Entities.AccountReconciliationAdjustmentRow))]
    public class AccountReconciliationAdjustmentForm
    {
        public String AdjAcctNo { get; set; }
        public String RefNo { get; set; }
        public Decimal LineNo { get; set; }
        public String AcctNo { get; set; }
        public String CostCentre { get; set; }
        public String Dept { get; set; }
        public String LineRef { get; set; }
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal Debit { get; set; }
        public Decimal Credit { get; set; }
        public Decimal CompLdgDebit { get; set; }
        public Decimal CompLdgCredit { get; set; }
        public Decimal LedgerDebit { get; set; }
        public Decimal LedgerCredit { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String Particulars { get; set; }
    }
}