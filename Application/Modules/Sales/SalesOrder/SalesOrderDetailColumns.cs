#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesOrderDetailColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Sales.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Sales.SalesOrderDetail")]
    [BasedOnRow(typeof(Entities.SalesOrderDetailRow))]
    public class SalesOrderDetailColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        //[EditLink]
        //public String OrderNoPosted { get; set; }
        public Decimal LineNo { get; set; }
        public String Posted { get; set; }
        public String Closed { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public Decimal Qty { get; set; }
        public Decimal Price { get; set; }
        public Decimal Ptax { get; set; }
        public Decimal NetPrice { get; set; }
        public Decimal ExtPrice { get; set; }
       // public Decimal LdiscPcent { get; set; }
        //public Decimal LdiscAmt { get; set; }
        //public Decimal AtaxAmt { get; set; }
        //public Decimal NetItemAmt { get; set; }
        //public Decimal PriceAmt { get; set; }
        //public Decimal PtaxAmt { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys3 { get; set; }
        //public String Anlys4 { get; set; }
        //public String Anlys5 { get; set; }
        //public String Anlys6 { get; set; }
        //public String CommisType { get; set; }
        //public String CommisRefNo { get; set; }
        //public String Configurable { get; set; }
        //public Decimal FirstShipQty { get; set; }
        //public Decimal OtherShipQty { get; set; }
        //public Decimal LastShipNo { get; set; }
        //public String Reserved { get; set; }
        //public String ResvStubNo { get; set; }
        //public String Waitlisted { get; set; }
        //public String WaitlistNo { get; set; }
        //public String WeightUom { get; set; }
        //public Decimal GrossWt { get; set; }
        //public Decimal NetWt { get; set; }
        //public String DimensionUom { get; set; }
        //public Decimal Flength { get; set; }
        //public Decimal Width { get; set; }
        //public Decimal Height { get; set; }
        //public Decimal UnitVolume { get; set; }
        //public Decimal Volume { get; set; }
        //public Decimal PriceCpd { get; set; }
        //public Decimal PtaxCpd { get; set; }
        //public Decimal AtaxCpd { get; set; }
        //public Decimal DiscCpd { get; set; }
        //public Decimal GrossWtCpd { get; set; }
        //public Decimal NetWtCpd { get; set; }
        //public Decimal VolumeCpd { get; set; }
        //public String InnerPkgType { get; set; }
        //public Decimal InnerQty { get; set; }
        //public Decimal InnerPkgs { get; set; }
        //public Decimal InnerExcsQty { get; set; }
        //public String OuterPkgType { get; set; }
        //public Decimal OuterQty { get; set; }
        //public Decimal OuterPkgs { get; set; }
        //public Decimal OuterExcsQty { get; set; }
        //public Decimal StartCtnNo { get; set; }
        //public Decimal QtyShipped { get; set; }
        //public String ItemTaxCode { get; set; }
        //public String CustItemNo { get; set; }
        //public String SpecNo { get; set; }
        //public String BomNo { get; set; }
        //public Decimal QtyPacked { get; set; }
        //public String JobNo { get; set; }
        //public String ProdBranch { get; set; }
        //public String AssemblyLine { get; set; }
        //public DateTime ProdDueDate { get; set; }
        //public String MakeIt { get; set; }
        //public DateTime ProdStartDate { get; set; }
        //public Decimal SchedCount { get; set; }
        //public String StdAssort { get; set; }
        //public String ExtDescription { get; set; }
        //public Decimal QtyPending { get; set; }
        //public String VendorNo { get; set; }
        //public Decimal VendorPrice { get; set; }
        //public String VendorPack { get; set; }
        //public String VendorCcy { get; set; }
        //public Decimal OriginQty { get; set; }
        //public Decimal SltaxPcent { get; set; }
        //public Decimal SltaxAmt { get; set; }
        //public Decimal ReorderQty { get; set; }
        //public String IncludeScrapRate { get; set; }
        //public Decimal MarkupPcent { get; set; }
        //public Decimal Markup { get; set; }
        //public String ItemCode { get; set; }
        //public String MoldBomNo { get; set; }
        //public String MoldFormulaCode { get; set; }
        //public Decimal MoldExpectedQty { get; set; }
        //public String Anlys15 { get; set; }
        //public String Anlys16 { get; set; }
        //public String Anlys17 { get; set; }
        //public String Anlys18 { get; set; }
        //public String Anlys19 { get; set; }
        //public String Anlys20 { get; set; }
        //public String ShipmarkRmk { get; set; }
        //public Decimal LotSizeCost { get; set; }
        //public Decimal ReleaseQty { get; set; }
        //public String BlanketRef { get; set; }
        //public Decimal BlanketLineNo { get; set; }
    }
}