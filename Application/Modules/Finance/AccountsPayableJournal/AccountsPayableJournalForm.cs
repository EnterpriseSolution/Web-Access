#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableJournalForm.cs
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

    [FormScript("Finance.AccountsPayableJournal")]
    [BasedOnRow(typeof(Entities.AccountsPayableJournalRow))]
    public class AccountsPayableJournalForm
    {
        public Decimal EntryNo { get; set; }
        public String VendorNo { get; set; }
        public String Period { get; set; }
        public DateTime TranDate { get; set; }
        public String TranType { get; set; }
        public String RefNo { get; set; }
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal TotalAmt { get; set; }
        public Decimal Credit { get; set; }
        public Decimal Debit { get; set; }
        public Decimal LocalCredit { get; set; }
        public Decimal LocalDebit { get; set; }
        public Decimal LocalBalance { get; set; }
        public String Particulars { get; set; }
    }
}