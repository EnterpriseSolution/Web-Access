#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ShipmentColumns.cs
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

    [ColumnsScript("Sales.Shipment")]
    [BasedOnRow(typeof(Entities.ShipmentRow))]
    public class ShipmentColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String RefNo { get; set; }
        public DateTime ShipmentDate { get; set; }
        public String ShipFrom { get; set; }
        public String CustomerNo { get; set; }
        public String CustomerName { get; set; }
        public DateTime CutoffDate { get; set; }
        
        //public String Posted { get; set; }
        //public String Returned { get; set; }
        //public String Invoiced { get; set; }
        public String InvoiceNo { get; set; }

        //public String ShipTo { get; set; }
        //public String Address { get; set; }
        //public String Address2 { get; set; }
        //public String Address3 { get; set; }
        //public String Address4 { get; set; }
        //public String ShipVia { get; set; }
        //public String ShipmentTerms { get; set; }
        //public String VesselName { get; set; }
        //public DateTime Etd { get; set; }
        //public DateTime Eta { get; set; }
        //public String PayTerms { get; set; }
        //public Decimal DiscDays { get; set; }
        //public Decimal DiscPercent { get; set; }
        //public Decimal NetDays { get; set; }
        //public DateTime DiscountDate { get; set; }
        //public DateTime DueDate { get; set; }
        //public DateTime ExpectedDate { get; set; }
        //public String Ccy { get; set; }
        //public Decimal ExchRate { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String ComputeTax { get; set; }
        //public Decimal TotPriceAmt { get; set; }
        //public Decimal TotPtaxAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotLdiscAmt { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
        //public Decimal TotItemAmt { get; set; }
        //public Decimal TotTdiscAmt { get; set; }
        //public Decimal NetTradeAmt { get; set; }
        //public Decimal TotChgsAmt { get; set; }
        //public Decimal NetOrdrAmt { get; set; }
        //public Decimal TotGtaxAmt { get; set; }
        //public Decimal NetPayAmt { get; set; }
        //public Decimal DpsCover { get; set; }
        //public Decimal DpsApplied { get; set; }
        //public Decimal NetBalAmt { get; set; }
        //public Decimal CpdTdiscAmt { get; set; }
        //public Decimal CpdGtaxAmt { get; set; }
        //public Decimal CpdDpsAmt { get; set; }
        //public Decimal LocPriceAmt { get; set; }
        //public Decimal LocPtaxAmt { get; set; }
        //public Decimal LocExtPrice { get; set; }
        //public Decimal LocLdiscAmt { get; set; }
        //public Decimal LocAtaxAmt { get; set; }
        //public Decimal LocItemAmt { get; set; }
        //public Decimal LocTdiscAmt { get; set; }
        //public Decimal LocChgsAmt { get; set; }
        //public Decimal LocGtaxAmt { get; set; }
        //public Decimal LocPayAmt { get; set; }
        //public Decimal LocDpsApplied { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public DateTime PrevisedDate { get; set; }
        //public String PrevisedBy { get; set; }
        //public Decimal LastEntryNo { get; set; }
        //public Decimal LastChgsNo { get; set; }
        //public Decimal LastTextNo { get; set; }
        //public Decimal LastCtnNo { get; set; }
        //public String LockType { get; set; }
        //public String LockRefNo { get; set; }
        //public Decimal LastLogNo { get; set; }
        //public Decimal NewItemCount { get; set; }
        //public Decimal NewChgsCount { get; set; }
        //public String AcctCustomer { get; set; }
        //public String AcctTdisc { get; set; }
        //public String AcctGtax { get; set; }
        //public String DpsApplyRef { get; set; }
        //public String VendTaxCode { get; set; }
        //public String CustTaxCode { get; set; }
        //public Decimal RetPriceAmt { get; set; }
        //public Decimal RetPtaxAmt { get; set; }
        //public Decimal RetExtPrice { get; set; }
        //public Decimal RetLdiscAmt { get; set; }
        //public Decimal RetAtaxAmt { get; set; }
        //public Decimal RetItemAmt { get; set; }
        //public Decimal RetTdiscAmt { get; set; }
        //public Decimal RetGtaxAmt { get; set; }
        //public Decimal RetChgsAmt { get; set; }
        //public Decimal RetPayAmt { get; set; }
        //public Decimal LretPriceAmt { get; set; }
        //public Decimal LretPtaxAmt { get; set; }
        //public Decimal LretExtPrice { get; set; }
        //public Decimal LretLdiscAmt { get; set; }
        //public Decimal LretAtaxAmt { get; set; }
        //public Decimal LretItemAmt { get; set; }
        //public Decimal LretTdiscAmt { get; set; }
        //public Decimal LretGtaxAmt { get; set; }
        //public Decimal LretChgsAmt { get; set; }
        //public Decimal LretPayAmt { get; set; }
        //public String WeightUom { get; set; }
        //public Decimal GrWt { get; set; }
        //public Decimal NtWt { get; set; }
        //public String DimensionUom { get; set; }
        //public Decimal Volume { get; set; }
        //public String GlLink { get; set; }
        //public String GlLinkType { get; set; }
        //public String GlLinkNo { get; set; }
        //public String PackingOk { get; set; }
        //public String Comments1 { get; set; }
        //public String Comments2 { get; set; }
        //public String Comments3 { get; set; }
        //public String Comments4 { get; set; }
        //public String SettleAt { get; set; }
        //public String CheckCrlimit { get; set; }
        //public Decimal CheckCrbal { get; set; }
        //public String Attention { get; set; }
        //public String TelNo { get; set; }
        //public String FaxNo { get; set; }
        //public String PortLoading { get; set; }
        //public String PortDischarge { get; set; }
        //public String Forwarder { get; set; }
        //public String LcNo { get; set; }
        //public String OriginCountry { get; set; }
        //public String Comments5 { get; set; }
        //public String Comments6 { get; set; }
        //public String Comments7 { get; set; }
        //public String Comments8 { get; set; }
        //public String IssueBank { get; set; }
        //public DateTime IssueDate { get; set; }
        //public String SltaxType { get; set; }
        //public Decimal GsltaxPcent { get; set; }
        //public Decimal TotGsltaxAmt { get; set; }
        //public Decimal TotLsltaxAmt { get; set; }
        //public Decimal LocGsltaxAmt { get; set; }
        //public Decimal LocLsltaxAmt { get; set; }
        //public String SoSltaxType { get; set; }
        //public Decimal SoGsltaxPcent { get; set; }
        //public Decimal OrderCount { get; set; }
        //public String AcctSltax { get; set; }
        //public Decimal LastTextNo1 { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String DnOnly { get; set; }

        //public String Flag { get; set; }
        //public String HoldBy { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
        //public Boolean ManualShipmentDetail { get; set; }
        //public String RefCompanyCode { get; set; }
        //public String RefGrnNo { get; set; }
        //public String LcName { get; set; }
    }
}