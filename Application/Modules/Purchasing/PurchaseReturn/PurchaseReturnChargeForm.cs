#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseReturnChargeForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Purchasing.PurchaseReturnCharge")]
    [BasedOnRow(typeof(Entities.PurchaseReturnChargeRow))]
    public class PurchaseReturnChargeForm
    {
        public String RefNo { get; set; }
        public Decimal EntryNo { get; set; }
        public String OrderNo { get; set; }
        public Decimal SeqNo { get; set; }
        public String ChargeType { get; set; }
        public String Particulars { get; set; }
        public Decimal BalAmt { get; set; }
        public Decimal ReturnAmt { get; set; }
        public Decimal LocReturnAmt { get; set; }
        public String AcctPurchase { get; set; }
        public String Deduction { get; set; }
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