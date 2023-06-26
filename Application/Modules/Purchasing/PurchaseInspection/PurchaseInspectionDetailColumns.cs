#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseInspectionDetailColumns.cs
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

    [ColumnsScript("Purchasing.PurchaseInspectionDetail")]
    [BasedOnRow(typeof(Entities.PurchaseInspectionDetailRow))]
    public class PurchaseInspectionDetailColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String RefNoEntryMethod { get; set; }
        public Decimal EntryNo { get; set; }
        public String OrderNo { get; set; }
        public Decimal LineNo { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public Decimal QtyReceived { get; set; }
        public Decimal QtyPending { get; set; }
        public Decimal QtyInspected { get; set; }
        public Decimal QtyRejected { get; set; }
        public String Reorder { get; set; }
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
        public String GrnNo { get; set; }
        public String Loc { get; set; }
        public DateTime InspectionDate { get; set; }
        public String Posted { get; set; }
        public Decimal LogNo { get; set; }
        public String VendorNo { get; set; }
        public String AcctPurchase { get; set; }
        public String AcctLdisc { get; set; }
        public String AcctGtax { get; set; }
        public Decimal CostAccepted { get; set; }
        public Decimal CostRejected { get; set; }
        public String Remarks { get; set; }
        public String ExtDescription { get; set; }
        public String AdjustRcvd { get; set; }
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