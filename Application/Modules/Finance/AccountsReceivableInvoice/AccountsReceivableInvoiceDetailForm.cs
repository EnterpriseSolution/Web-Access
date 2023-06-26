#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableInvoiceDetailForm.cs
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

    [FormScript("Finance.AccountsReceivableInvoiceDetail")]
    [BasedOnRow(typeof(Entities.AccountsReceivableInvoiceDetailRow))]
    public class AccountsReceivableInvoiceDetailForm
    {
        public String InvoiceNo { get; set; }
        public Decimal LineNo { get; set; }
        public String ItemNo { get; set; }
        public String Posted { get; set; }
        public String Returned { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal Qty { get; set; }
        public Decimal LotSize { get; set; }
        public Decimal Price { get; set; }
        public Decimal ExtPrice { get; set; }
        public Decimal LocExtPrice { get; set; }
        public Decimal PriceCpd { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public Decimal ReturnQty { get; set; }
        public Decimal ReturnAmt { get; set; }
        public Decimal LreturnAmt { get; set; }
        public DateTime InvoiceDate { get; set; }
        public String CustomerNo { get; set; }
        public String AcctSales { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
        public String ExtDescription { get; set; }
        public Decimal SltaxPcent { get; set; }
        public Decimal SltaxAmt { get; set; }
        public Decimal LocSltaxAmt { get; set; }
        public String AcctSltax { get; set; }
        public String ShipmentRef { get; set; }
        public Decimal ShipmentEntryNo { get; set; }
        public String OrderNo { get; set; }
        public Decimal LdiscPcent { get; set; }
        public Decimal LdiscAmt { get; set; }
        public Decimal NetItemAmt { get; set; }
        public Decimal OrderLineNo { get; set; }
        public Decimal PriceAmt { get; set; }
        public Decimal NetPrice { get; set; }
        public String AcctLdisc { get; set; }
        public Decimal ShipItemAmt { get; set; }
        public Decimal LshipItemAmt { get; set; }
        public Decimal LocItemAmt { get; set; }
        public Decimal LocPriceAmt { get; set; }
        public Decimal LocLdiscAmt { get; set; }
        public String AcctVariance { get; set; }
        public Decimal VariaAmt { get; set; }
        public Decimal LocalVariaAmt { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
    }
}