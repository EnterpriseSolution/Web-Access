#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountReconciliationDetailForm.cs
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

    [FormScript("Finance.AccountReconciliationDetail")]
    [BasedOnRow(typeof(Entities.AccountReconciliationDetailRow))]
    public class AccountReconciliationDetailForm
    {
        public String AcctNo { get; set; }
        public String RefNo { get; set; }
        public DateTime VoucherDate { get; set; }
        public Decimal JournalNo { get; set; }
        public Decimal LineNo { get; set; }
        public String VoucherType { get; set; }
        public String VoucherNo { get; set; }
        public String Reference { get; set; }
        public String LineRef { get; set; }
        public String Ccy { get; set; }
        public Decimal Debit { get; set; }
        public Decimal Credit { get; set; }
        public Decimal LedgerAmt { get; set; }
        public String Sign { get; set; }
        public String IncludeThis { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String Particulars { get; set; }
    }
}