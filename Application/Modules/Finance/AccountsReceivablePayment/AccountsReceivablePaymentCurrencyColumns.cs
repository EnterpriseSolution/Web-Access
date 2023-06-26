#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivablePaymentCurrencyColumns.cs
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

    [ColumnsScript("Finance.AccountsReceivablePaymentCurrency")]
    [BasedOnRow(typeof(Entities.AccountsReceivablePaymentCurrencyRow))]
    public class AccountsReceivablePaymentCurrencyColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String ReceiptNo { get; set; }
        public String Ccy { get; set; }
        public String Description { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal BalAmt { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
    }
}