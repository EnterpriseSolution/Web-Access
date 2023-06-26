#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseReturnForm.cs
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

    [FormScript("Purchasing.PurchaseReturn")]
    [BasedOnRow(typeof(Entities.PurchaseReturnRow))]
    public class PurchaseReturnForm
    {
        public String RefNo { get; set; }
        public String EntryMethod { get; set; }
        public String Posted { get; set; }
        public DateTime TranDate { get; set; }
        public String GrnNo { get; set; }
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
        public String DoNo { get; set; }
        public String InvoiceNo { get; set; }
        public String HoldItems { get; set; }
        public String Loc { get; set; }
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        public Decimal TotPriceAmt { get; set; }
        public Decimal TotPtaxAmt { get; set; }
        public Decimal TotExtPrice { get; set; }
        public Decimal TotLdiscAmt { get; set; }
        public Decimal TotAtaxAmt { get; set; }
        public Decimal TotItemAmt { get; set; }
        public Decimal TotRefundAmt { get; set; }
        public Decimal TotVariaAmt { get; set; }
        public Decimal TdiscPcent { get; set; }
        public Decimal TotTdiscAmt { get; set; }
        public Decimal NetTradeAmt { get; set; }
        public Decimal TotChgsAmt { get; set; }
        public Decimal NetOrdrAmt { get; set; }
        public Decimal TotGtaxAmt { get; set; }
        public Decimal NetPayAmt { get; set; }
        public Decimal TotTdiscCpd { get; set; }
        public Decimal LocPriceAmt { get; set; }
        public Decimal LocPtaxAmt { get; set; }
        public Decimal LocExtPrice { get; set; }
        public Decimal LocLdiscAmt { get; set; }
        public Decimal LocAtaxAmt { get; set; }
        public Decimal LocItemAmt { get; set; }
        public Decimal LocRefundAmt { get; set; }
        public Decimal LocVariaAmt { get; set; }
        public Decimal LocTdiscAmt { get; set; }
        public Decimal LocChgsAmt { get; set; }
        public Decimal LocGtaxAmt { get; set; }
        public Decimal LocPayAmt { get; set; }
        public String AcctVendor { get; set; }
        public String AcctTdisc { get; set; }
        public String AcctGtax { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
        public DateTime RevisedDate { get; set; }
        public String RevisedBy { get; set; }
        public DateTime PostedDate { get; set; }
        public String PostedBy { get; set; }
        public Decimal LogNo { get; set; }
        public Decimal LastLogNo { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String SettleAt { get; set; }
        public String Reason { get; set; }
        public String Anlys9 { get; set; }
        public String Anlys10 { get; set; }
        public String Anlys11 { get; set; }
        public String Anlys12 { get; set; }
        public String Anlys13 { get; set; }
        public String Anlys14 { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
    }
}