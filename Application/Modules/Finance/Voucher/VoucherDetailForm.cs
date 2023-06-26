#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherDetailForm.cs
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

    [FormScript("Finance.VoucherDetail")]
    [BasedOnRow(typeof(Entities.VoucherDetailRow))]
    public class VoucherDetailForm
    {
        public String VoucherType { get; set; }
        public String VoucherNo { get; set; }
        public Decimal LineNo { get; set; }
        public String AcctNo { get; set; }
        public String AcctName { get; set; }
        public String BranchNo { get; set; }
        public String CostCentre { get; set; }
        public String Dept { get; set; }
        public String LineRef { get; set; }
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal Debit { get; set; }
        public Decimal Credit { get; set; }
        public Decimal ForexAmt { get; set; }
        public Decimal LedgerAmt { get; set; }
        public String Sign { get; set; }
        public Decimal LedgerDebit { get; set; }
        public Decimal LedgerCredit { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public String Posted { get; set; }
        public String Reconciled { get; set; }
        public String Period { get; set; }
        public Decimal FiscalYear { get; set; }
        public Decimal PeriodNo { get; set; }
        public Decimal JournalNo { get; set; }
        public DateTime VoucherDate { get; set; }
        public Decimal LedgerAmtCpd { get; set; }
        public String Reference { get; set; }
        public DateTime PostedDate { get; set; }
        public Decimal RunningBalance { get; set; }
        public String BalanceSign { get; set; }
        public String ExchDiff { get; set; }
        public String Particulars { get; set; }
        public String ItemGroup { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
        public String InvoiceNo { get; set; }
    }
}