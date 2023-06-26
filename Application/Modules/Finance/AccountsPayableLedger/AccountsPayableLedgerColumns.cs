﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableLedgerColumns.cs
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

    [ColumnsScript("Finance.AccountsPayableLedger")]
    [BasedOnRow(typeof(Entities.AccountsPayableLedgerRow))]
    public class AccountsPayableLedgerColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
        public String Summary { get; set; }
        public String Ccy { get; set; }
        public String Period { get; set; }
        public String VendorNo2 { get; set; }
        public String Ccy2 { get; set; }
        public Decimal FiscalYear { get; set; }
        public Decimal PeriodNo { get; set; }
        public Decimal InvoAmt { get; set; }
        public Decimal MemoAmt { get; set; }
        public Decimal AdjAmt { get; set; }
        public Decimal PayAmt { get; set; }
        public Decimal DiscAmt { get; set; }
        public Decimal DiffAmt { get; set; }
        public Decimal BalBeg { get; set; }
        public Decimal Credit { get; set; }
        public Decimal Debit { get; set; }
        public Decimal BalEnd { get; set; }
        public Decimal LocalInvoAmt { get; set; }
        public Decimal LocalMemoAmt { get; set; }
        public Decimal LocalAdjAmt { get; set; }
        public Decimal LocalPayAmt { get; set; }
        public Decimal LocalDiscAmt { get; set; }
        public Decimal LocalDiffAmt { get; set; }
        public Decimal LocalBalBeg { get; set; }
        public Decimal LocalCredit { get; set; }
        public Decimal LocalDebit { get; set; }
        public Decimal LocalBalEnd { get; set; }
        public Decimal RfdAmt { get; set; }
        public Decimal LocalRfdAmt { get; set; }
    }
}