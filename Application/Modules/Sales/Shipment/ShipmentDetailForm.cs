#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ShipmentDetailForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Sales.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Sales.ShipmentDetail")]
    [BasedOnRow(typeof(Entities.ShipmentDetailRow))]
    public class ShipmentDetailForm
    {
        public String RefNo { get; set; }
        public Decimal EntryNo { get; set; }
        public String Selected { get; set; }
        public String OrderNo { get; set; }
        public Decimal LineNo { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public String Configurable { get; set; }
        public Decimal QtyBalance { get; set; }
        public Decimal QtyDue { get; set; }
        public Decimal QtyShipped { get; set; }
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
        public Decimal LdiscRate { get; set; }
        public Decimal AtaxRate { get; set; }
        public Decimal LdiscAmtCpd { get; set; }
        public Decimal AtaxAmtCpd { get; set; }
        public Decimal LocPriceAmt { get; set; }
        public Decimal LocPtaxAmt { get; set; }
        public Decimal LocExtPrice { get; set; }
        public Decimal LocLdiscAmt { get; set; }
        public Decimal LocAtaxAmt { get; set; }
        public Decimal LocItemAmt { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String Anlys3 { get; set; }
        public String Anlys4 { get; set; }
        public String Anlys5 { get; set; }
        public String Anlys6 { get; set; }
        public String Posted { get; set; }
        public Decimal LogNo { get; set; }
        public String Returned { get; set; }
        public DateTime ShipmentDate { get; set; }
        public String CustomerNo { get; set; }
        public String ShipFrom { get; set; }
        public String CommisType { get; set; }
        public String CommisRefNo { get; set; }
        public String CustItemNo { get; set; }
        public String AcctSales { get; set; }
        public String AcctLdisc { get; set; }
        public String AcctPtax { get; set; }
        public String AcctAtax { get; set; }
        public String ItemTaxCode { get; set; }
        public Decimal QtyReturned { get; set; }
        public Decimal RetPriceAmt { get; set; }
        public Decimal RetPtaxAmt { get; set; }
        public Decimal RetExtPrice { get; set; }
        public Decimal RetLdiscAmt { get; set; }
        public Decimal RetAtaxAmt { get; set; }
        public Decimal RetItemAmt { get; set; }
        public Decimal LretPriceAmt { get; set; }
        public Decimal LretPtaxAmt { get; set; }
        public Decimal LretExtPrice { get; set; }
        public Decimal LretLdiscAmt { get; set; }
        public Decimal LretAtaxAmt { get; set; }
        public Decimal LretItemAmt { get; set; }
        public Decimal QtyPacked { get; set; }
        public Decimal CostReturned { get; set; }
        public String StdAssort { get; set; }
        public String ExtDescription { get; set; }
        public String VendorPack { get; set; }
        public Decimal SltaxPcent { get; set; }
        public Decimal SltaxAmt { get; set; }
        public Decimal LocSltaxAmt { get; set; }
        public String AcctSltax { get; set; }
        public Decimal MarkupPcent { get; set; }
        public Decimal Markup { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String Anlys18 { get; set; }
        public String Anlys19 { get; set; }
        public String Anlys20 { get; set; }
        public Decimal LotSizeCost { get; set; }
    }
}