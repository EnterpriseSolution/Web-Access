#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableInvoiceSummaryForm.cs
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

    [FormScript("Finance.AccountsPayableInvoiceSummary")]
    [BasedOnRow(typeof(Entities.AccountsPayableInvoiceSummaryRow))]
    public class AccountsPayableInvoiceSummaryForm
    {
        public String ControlNo { get; set; }
        public String GrnNo { get; set; }
        public String Posted { get; set; }
        public String Returned { get; set; }
        public String DoNo { get; set; }
        public DateTime ReceivedDate { get; set; }
        public String Loc { get; set; }
        public String Inspected { get; set; }
        public Decimal TotPriceAmt { get; set; }
        public Decimal TotPtaxAmt { get; set; }
        public Decimal TotExtPrice { get; set; }
        public Decimal TotLdiscAmt { get; set; }
        public Decimal TotAtaxAmt { get; set; }
        public Decimal TotItemAmt { get; set; }
        public Decimal TotTdiscAmt { get; set; }
        public Decimal NetTradeAmt { get; set; }
        public Decimal TotChgsAmt { get; set; }
        public Decimal NetOrdrAmt { get; set; }
        public Decimal TotGtaxAmt { get; set; }
        public Decimal NetInvoAmt { get; set; }
        public Decimal DpsApplied { get; set; }
        public Decimal NetBalAmt { get; set; }
        public Decimal LocPriceAmt { get; set; }
        public Decimal LocPtaxAmt { get; set; }
        public Decimal LocExtPrice { get; set; }
        public Decimal LocLdiscAmt { get; set; }
        public Decimal LocAtaxAmt { get; set; }
        public Decimal LocItemAmt { get; set; }
        public Decimal LocTdiscAmt { get; set; }
        public Decimal LocChgsAmt { get; set; }
        public Decimal LocGtaxAmt { get; set; }
        public Decimal LocInvoAmt { get; set; }
        public Decimal LocDpsApplied { get; set; }
        public Decimal GrnNetAmt { get; set; }
        public Decimal LgrnNetAmt { get; set; }
        public Decimal VariaAmt { get; set; }
        public Decimal LocalVariaAmt { get; set; }
        public Decimal ItemVariaAmt { get; set; }
        public Decimal LitemVariaAmt { get; set; }
        public Decimal ChgsVariaAmt { get; set; }
        public Decimal LchgsVariaAmt { get; set; }
        public String PutaxType { get; set; }
        public Decimal GputaxPcent { get; set; }
        public Decimal TotGputaxAmt { get; set; }
        public Decimal TotLputaxAmt { get; set; }
        public Decimal LocGputaxAmt { get; set; }
        public Decimal LocLputaxAmt { get; set; }
        public String PoPutaxType { get; set; }
        public Decimal PoGputaxPcent { get; set; }
    }
}