﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableLedgerForm.cs
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

    [FormScript("Finance.AccountsReceivableLedger")]
    [BasedOnRow(typeof(Entities.AccountsReceivableLedgerRow))]
    public class AccountsReceivableLedgerForm
    {
        public String CustomerNo { get; set; }
        public String CustomerName { get; set; }
        public String Summary { get; set; }
        public String Ccy { get; set; }
        public String Period { get; set; }
        //public String CustomerNo2 { get; set; }
        //public String Ccy2 { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        [Category(CategoryName.Transaction)]
        public Decimal InvoAmt { get; set; }
        public Decimal MemoAmt { get; set; }
        public Decimal AdjAmt { get; set; }
        public Decimal PayAmt { get; set; }
        public Decimal DiscAmt { get; set; }
        public Decimal DiffAmt { get; set; }
        public Decimal BalBeg { get; set; }
        public Decimal Debit { get; set; }
        public Decimal Credit { get; set; }
        public Decimal BalEnd { get; set; }
        public Decimal RfdAmt { get; set; }

        [Category(CategoryName.Local)]
        public Decimal LocalInvoAmt { get; set; }
        public Decimal LocalMemoAmt { get; set; }
        public Decimal LocalAdjAmt { get; set; }
        public Decimal LocalPayAmt { get; set; }
        public Decimal LocalDiscAmt { get; set; }
        public Decimal LocalDiffAmt { get; set; }
        public Decimal LocalBalBeg { get; set; }
        public Decimal LocalDebit { get; set; }
        public Decimal LocalCredit { get; set; }
        public Decimal LocalBalEnd { get; set; }
        public Decimal LocalRfdAmt { get; set; }

        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}