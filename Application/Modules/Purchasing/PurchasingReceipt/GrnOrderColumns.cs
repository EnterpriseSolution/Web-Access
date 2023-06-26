#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  GrnOrderColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Purchasing.GrnOrder")]
    [BasedOnRow(typeof(Entities.GrnOrderRow))]
    public class GrnOrderColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String GrnNoEntryMethod { get; set; }
        [AlignRight]
        public Decimal SeqNo { get; set; }
        public String OrderNo { get; set; }
        public String Posted { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime NextDueDate { get; set; }
        public String Final { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public Decimal TotPriceAmt { get; set; }
        public Decimal TotPtaxAmt { get; set; }
        public Decimal TotExtPrice { get; set; }
        public Decimal TotLdiscAmt { get; set; }
        public Decimal TotAtaxAmt { get; set; }
        public Decimal TotItemAmt { get; set; }
        public Decimal TdiscPcent { get; set; }
        public Decimal TotTdiscAmt { get; set; }
        public Decimal NetTradeAmt { get; set; }
        public Decimal TotChgsAmt { get; set; }
        public Decimal NetOrdrAmt { get; set; }
        public Decimal TotGtaxAmt { get; set; }
        public Decimal NetPayAmt { get; set; }
        public Decimal DpsCover { get; set; }
        public Decimal DpsPcent { get; set; }
        public Decimal DpsApplied { get; set; }
        public Decimal LocDpsApplied { get; set; }
        public Decimal NetBalAmt { get; set; }
        public Decimal TdiscRate { get; set; }
        public Decimal GtaxRate { get; set; }
        public Decimal DpsRate { get; set; }
        public Decimal TotTdiscCpd { get; set; }
        public Decimal TotGtaxCpd { get; set; }
        public Decimal DpsAppliedCpd { get; set; }
        public Decimal LastLineNo { get; set; }
        public Decimal LastChgsNo { get; set; }
        public Decimal LogNo { get; set; }
        public Decimal LastLogNo { get; set; }
        public String Buyer { get; set; }
        public DateTime ReceivedDate { get; set; }
        public Decimal DetailCount { get; set; }
        public Decimal ChargesCount { get; set; }
        public Decimal DpsEntryNo { get; set; }
        public Decimal CheckCrbal { get; set; }
        public String PutaxType { get; set; }
        public Decimal GputaxPcent { get; set; }
        public Decimal TotGputaxAmt { get; set; }
        public Decimal TotLputaxAmt { get; set; }
        public String Anlys7 { get; set; }
        public String Anlys8 { get; set; }
        public String ReceiveAll { get; set; }
        public String Anlys9 { get; set; }
        public String Anlys10 { get; set; }
        public String Anlys11 { get; set; }
        public String Anlys12 { get; set; }
        public String Anlys13 { get; set; }
        public String Anlys14 { get; set; }
    }
}