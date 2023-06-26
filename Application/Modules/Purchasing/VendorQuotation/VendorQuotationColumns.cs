#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationColumns.cs
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

    [ColumnsScript("Purchasing.VendorQuotation")]
    [BasedOnRow(typeof(Entities.VendorQuotationRow))]
    public class VendorQuotationColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String OrderNo { get; set; }
        //public String Closed { get; set; }
        public String VendorNo { get; set; }
        //public String VendorName { get; set; }
        //public String VendorAddress { get; set; }
        //public String VendorAddress2 { get; set; }
        //public String VendorAddress3 { get; set; }
        //public String VendorAddress4 { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DueDate { get; set; }
        //public DateTime SchedDate { get; set; }
        //public String ShipTo { get; set; }
        //public String Address { get; set; }
        //public String Address2 { get; set; }
        //public String Address3 { get; set; }
        //public String Address4 { get; set; }
        //public String MultiShip { get; set; }
        //public String ComputeTax { get; set; }
        //public String ShipVia { get; set; }
        //public String ShipmentTerms { get; set; }
        //public String Buyer { get; set; }
        //public String PayTerms { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Ccy { get; set; }
        //public Decimal ExchRate { get; set; }
        //public String SourceType { get; set; }
        //public String SourceRefNo { get; set; }
        //public Int16 LastSchedNo { get; set; }
        //public Int32 LastLineNo { get; set; }
        //public Int32 LastTextNo { get; set; }
        //public Decimal TotPriceAmt { get; set; }
        //public Decimal TotPtaxAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotLdiscAmt { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
        //public Decimal TotItemAmt { get; set; }
        //public Decimal TdiscPcent { get; set; }
        //public Decimal TotTdiscAmt { get; set; }
        //public Decimal NetTradeAmt { get; set; }
        //public Decimal TotChgsAmt { get; set; }
        //public Decimal NetOrdrAmt { get; set; }
        //public Decimal TotGtaxAmt { get; set; }
        //public Decimal NetPayAmt { get; set; }
        //public Decimal DpsPcent { get; set; }
        //public Decimal TotDpsAmt { get; set; }
        //public Decimal NetBalAmt { get; set; }
        //public Decimal TotTdiscCpd { get; set; }
        //public Decimal TotGtaxCpd { get; set; }
        //public Decimal TotDpsCpd { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public String LockRefNo { get; set; }
        //public Int32 LastLogNo { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String Comments1 { get; set; }
        //public String Comments2 { get; set; }
        //public String Comments3 { get; set; }
        //public String Comments4 { get; set; }
        //public String PortLoading { get; set; }
        //public String PortDischarge { get; set; }
        //public String VesselName { get; set; }
        //public String Forwarder { get; set; }
        //public String LcNo { get; set; }
        //public String OriginCountry { get; set; }
        //public String PutaxType { get; set; }
        //public Decimal GputaxPcent { get; set; }
        //public Decimal TotGputaxAmt { get; set; }
        //public Decimal TotLputaxAmt { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        public String VendorRefNo { get; set; }
        public DateTime ValidUntil { get; set; }
        //public String ClosedBy { get; set; }
        //public DateTime ClosedDate { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
    }
}