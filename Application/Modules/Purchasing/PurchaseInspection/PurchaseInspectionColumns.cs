#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseInspectionColumns.cs
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

    [ColumnsScript("Purchasing.PurchaseInspection")]
    [BasedOnRow(typeof(Entities.PurchaseInspectionRow))]
    public class PurchaseInspectionColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String RefNo { get; set; }
        public DateTime InspectionDate { get; set; }
        //public String EntryMethod { get; set; }
        //public String Posted { get; set; }
        public String InspectedBy { get; set; }
        public String Loc { get; set; }
        public String GrnNo { get; set; }
        public String VendorNo { get; set; }
        public String VendorName { get; set; }
        public DateTime ReceivedDate { get; set; }

        //public String Ccy { get; set; }
        //public Decimal ExchRate { get; set; }
        //public String FullInspection { get; set; }
        //public Decimal PendingCount { get; set; }
        //public String WithRejects { get; set; }
        //public String HoldItems { get; set; }
        //public String ReOrderNo { get; set; }
        //public DateTime ReOrderDate { get; set; }
        //public DateTime ReDueDate { get; set; }
        //public DateTime ReSchedDate { get; set; }
        //public String ReShipTo { get; set; }
        //public String ReShipVia { get; set; }
        //public String ReShipTerms { get; set; }
        //public Decimal ReCount { get; set; }
        //public Decimal TotPriceAmt { get; set; }
        //public Decimal TotPtaxAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotLdiscAmt { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
        //public Decimal TotItemAmt { get; set; }
        //public Decimal TdiscPcent { get; set; }
        //public Decimal TotTdiscAmt { get; set; }
        //public Decimal NetTradeAmt { get; set; }
        //public Decimal LocPriceAmt { get; set; }
        //public Decimal LocPtaxAmt { get; set; }
        //public Decimal LocExtPrice { get; set; }
        //public Decimal LocLdiscAmt { get; set; }
        //public Decimal LocAtaxAmt { get; set; }
        //public Decimal LocItemAmt { get; set; }
        //public Decimal LocTdiscAmt { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public Decimal LogNo { get; set; }
        //public String LastLogNo { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String SettleAt { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String DoNo { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
    }
}