#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivablePaymentDetailColumns.cs
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

    [ColumnsScript("Finance.AccountsReceivablePaymentDetail")]
    [BasedOnRow(typeof(Entities.AccountsReceivablePaymentDetailRow))]
    public class AccountsReceivablePaymentDetailColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String ReceiptNoDeposit { get; set; }
        public String InvoiceNoDirectEntry { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DiscountDate { get; set; }
        public DateTime DueDate { get; set; }
        public Decimal DiscPercent { get; set; }
        public String Ccy { get; set; }
        public Decimal InvoExchRate { get; set; }
        public Decimal PayExchRate { get; set; }
        public Decimal BalAmt { get; set; }
        public Decimal BalAmtInvo { get; set; }
        public Decimal DiscAmt { get; set; }
        public Decimal DiscAmtInvo { get; set; }
        public Decimal DueAmt { get; set; }
        public Decimal DueAmtInvo { get; set; }
        public Decimal DueAmtLocal { get; set; }
        public Decimal AppliedAmt { get; set; }
        public Decimal AppliedAmtLoc { get; set; }
        public Decimal SettledAmt { get; set; }
        public Decimal ForexGainAmt { get; set; }
        public Decimal EndAmt { get; set; }
        public Decimal EndAmtLocal { get; set; }
        public String Posted { get; set; }
        public Decimal LogNo { get; set; }
        public Decimal LastLogNo { get; set; }
        public DateTime ReceiptDate { get; set; }
        public String Settle { get; set; }
        public Decimal AppliedAmtInv { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public Decimal InvRoundDiff { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
    }
}