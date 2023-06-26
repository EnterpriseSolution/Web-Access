#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsPayableInvoiceOrderColumns.cs
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

    [ColumnsScript("Finance.AccountsPayableInvoiceOrder")]
    [BasedOnRow(typeof(Entities.AccountsPayableInvoiceOrderRow))]
    public class AccountsPayableInvoiceOrderColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        //[EditLink]
        //public String ControlNoMiscellaneous { get; set; }
        public String GrnNo { get; set; }
        public String OrderNo { get; set; }
        public Decimal TotPriceAmt { get; set; }
        public Decimal TotPtaxAmt { get; set; }
        public Decimal TotExtPrice { get; set; }
        //public Decimal TotLdiscAmt { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
        public Decimal TotItemAmt { get; set; }
        //public Decimal TdiscPcent { get; set; }
        //public Decimal TotTdiscAmt { get; set; }
        //public Decimal NetTradeAmt { get; set; }
        //public Decimal TotChgsAmt { get; set; }
        //public Decimal NetOrdrAmt { get; set; }
        //public Decimal TotGtaxAmt { get; set; }
        //public Decimal NetInvoAmt { get; set; }
        //public Decimal DpsCover { get; set; }
        //public Decimal DpsPcent { get; set; }
        //public Decimal DpsApplied { get; set; }
        public Decimal NetBalAmt { get; set; }
        //public Decimal LocDpsApplied { get; set; }
        //public String PutaxType { get; set; }
        //public Decimal GputaxPcent { get; set; }
        //public Decimal TotGputaxAmt { get; set; }
        //public Decimal TotLputaxAmt { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
    }
}