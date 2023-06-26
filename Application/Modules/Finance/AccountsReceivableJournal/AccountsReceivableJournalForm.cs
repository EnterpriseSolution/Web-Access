#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableJournalForm.cs
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

    [FormScript("Finance.AccountsReceivableJournal")]
    [BasedOnRow(typeof(Entities.AccountsReceivableJournalRow))]
    public class AccountsReceivableJournalForm
    {
        public Decimal EntryNo { get; set; }

        public String CustomerNo { get; set; }
        public String Period { get; set; }
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        
        [Category(CategoryName.Entry)]
        public DateTime TranDate { get; set; }
        public String TranType { get; set; }
        public String RefNo { get; set; }
        
        [Category(CategoryName.Transaction)]
        public Decimal Debit { get; set; }
        public Decimal Credit { get; set; }
        public Decimal TotalAmt { get; set; }

        [Category(CategoryName.Local)]
        public Decimal LocalDebit { get; set; }
        public Decimal LocalCredit { get; set; }
        public Decimal LocalBalance { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Particulars { get; set; }
    }
}