﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableInvoiceDetailForm.cs
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

    [FormScript("Finance.AccountsPayableInvoiceDetail")]
    [BasedOnRow(typeof(Entities.AccountsPayableInvoiceDetailRow))]
    public class AccountsPayableInvoiceDetailForm
    {
        public String ControlNo { get; set; }
        public String GrnNo { get; set; }
        public Decimal EntryNo { get; set; }
        public String Posted { get; set; }
        public String Returned { get; set; }
        public String OrderNo { get; set; }
        public Decimal LineNo { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public Decimal Qty { get; set; }
        public Decimal Price { get; set; }
        public Decimal Ptax { get; set; }
        public Decimal NetPrice { get; set; }
        public Decimal ExtPrice { get; set; }
        public Decimal LdiscPcent { get; set; }
        public Decimal LdiscAmt { get; set; }
        public Decimal AtaxAmt { get; set; }
        public Decimal NetItemAmt { get; set; }
        public Decimal PriceAmt { get; set; }
        public Decimal PtaxAmt { get; set; }
        public Decimal LocPriceAmt { get; set; }
        public Decimal LocPtaxAmt { get; set; }
        public Decimal LocExtPrice { get; set; }
        public Decimal LocLdiscAmt { get; set; }
        public Decimal LocAtaxAmt { get; set; }
        public Decimal LocItemAmt { get; set; }
        public Decimal GrnItemAmt { get; set; }
        public Decimal LgrnItemAmt { get; set; }
        public Decimal VariaAmt { get; set; }
        public Decimal LocVariaAmt { get; set; }
        public String AcctPurchase { get; set; }
        public String AcctLdisc { get; set; }
        public String AcctPtax { get; set; }
        public String AcctAtax { get; set; }
        public String AcctVariance { get; set; }
        public Decimal ReturnQty { get; set; }
        public Decimal ReturnAmt { get; set; }
        public Decimal LreturnAmt { get; set; }
        public Decimal PutaxPcent { get; set; }
        public Decimal PutaxAmt { get; set; }
        public Decimal LocPutaxAmt { get; set; }
        public String AcctPutax { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
    }
}