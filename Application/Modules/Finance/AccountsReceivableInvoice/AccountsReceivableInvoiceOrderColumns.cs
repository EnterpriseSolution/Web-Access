#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableInvoiceOrderColumns.cs
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

    [ColumnsScript("Finance.AccountsReceivableInvoiceOrder")]
    [BasedOnRow(typeof(Entities.AccountsReceivableInvoiceOrderRow))]
    public class AccountsReceivableInvoiceOrderColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String InvoiceNoDirectEntry { get; set; }
        public String ShipmentRef { get; set; }
        public String OrderNo { get; set; }
        public Decimal TotPriceAmt { get; set; }
        public Decimal TotExtPrice { get; set; }
        public Decimal TotLdiscAmt { get; set; }
        public Decimal TotItemAmt { get; set; }
        public Decimal TdiscPcent { get; set; }
        public Decimal TotTdiscAmt { get; set; }
        public Decimal NetTradeAmt { get; set; }
        public Decimal TotChgsAmt { get; set; }
        public Decimal NetOrdrAmt { get; set; }
        public Decimal NetPayAmt { get; set; }
        public Decimal DpsCover { get; set; }
        public Decimal DpsPcent { get; set; }
        public Decimal DpsApplied { get; set; }
        public Decimal LocDpsApplied { get; set; }
        public Decimal NetBalAmt { get; set; }
        public String SltaxType { get; set; }
        public Decimal GsltaxPcent { get; set; }
        public Decimal TotGsltaxAmt { get; set; }
        public Decimal TotLsltaxAmt { get; set; }
        public String Anlys9 { get; set; }
        public String Anlys10 { get; set; }
        public String Anlys11 { get; set; }
        public String Anlys12 { get; set; }
        public String CustomerPo { get; set; }
        public String Anlys21 { get; set; }
        public String Anlys22 { get; set; }
        public String Anlys23 { get; set; }
        public String Anlys24 { get; set; }
        public String Anlys25 { get; set; }
        public String Anlys26 { get; set; }
    }
}