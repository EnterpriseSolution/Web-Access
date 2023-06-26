#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivablePaymentDepositColumns.cs
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

    [ColumnsScript("Finance.AccountsReceivablePaymentDeposit")]
    [BasedOnRow(typeof(Entities.AccountsReceivablePaymentDepositRow))]
    public class AccountsReceivablePaymentDepositColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String ReceiptNo { get; set; }
        public Int32 LineNo { get; set; }
        public String OrderNo { get; set; }
        public String DepositReceiptNo { get; set; }
        public Boolean Posted { get; set; }
        public DateTime ReceiptDate { get; set; }
        public Decimal DepositAmt { get; set; }
        public Decimal DepositAmtLocal { get; set; }
        public Decimal BalAmt { get; set; }
        public Decimal BalAmtLocal { get; set; }
        public Decimal PaidAmt { get; set; }
        public Decimal PaidAmtLocal { get; set; }
        public Boolean Settle { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys7 { get; set; }
        public String Anlys8 { get; set; }
        public String Anlys9 { get; set; }
        public String Anlys10 { get; set; }
        public String Anlys11 { get; set; }
        public String Anlys12 { get; set; }
        public String Anlys13 { get; set; }
        public String Anlys14 { get; set; }
    }
}