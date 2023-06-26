#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  QuotationForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;
using Matrix.Sales.Entities;
using Serenity.Data.Mapping;

namespace Matrix.Sales.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Sales.Quotation")]
    [BasedOnRow(typeof(Entities.QuotationRow))]
    public class QuotationForm
    {
        [Tab(TabName.GeneralInformation)]
        public String RefNo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ValidUntil { get; set; }
        //public String Closed { get; set; }
        public String CustomerNo { get; set; }
        public String CustomerName { get; set; }

        [Category(CategoryName.Shipping)]
        public String PortLoading { get; set; }
        public String PortDischarge { get; set; }
        public String ShipVia { get; set; }
        public String ShipmentTerms { get; set; }
        public String OriginCountry { get; set; }

        [Category(CategoryName.Destination)]
        public String ShipTo { get; set; }
        public String Attention { get; set; }
        public String Address { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String TelNo { get; set; }
        public String FaxNo { get; set; }

        [Category(CategoryName.Payment)]
        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        public String PayTerms { get; set; }


        [Category(CategoryName.Control)]
        public String Salesman { get; set; }
        public String PriceCode { get; set; }
        public String BaseLoc { get; set; }
        
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
       
        //public String ComputeTax { get; set; }
        //public Decimal LastLineNo { get; set; }
        //public Decimal LastMailNo { get; set; }
        //public Decimal LastTextNo { get; set; }
       
        ////public DateTime CreatedDate { get; set; }
        ////public String CreatedBy { get; set; }
        ////public DateTime RevisedDate { get; set; }
        ////public String RevisedBy { get; set; }
        //public Decimal TotTdiscCpd { get; set; }
        //public Decimal TotGtaxCpd { get; set; }
        //public Decimal TotDpsCpd { get; set; }
        //public DateTime ClosedDate { get; set; }
        //public String ClosedBy { get; set; }
      
        //public String WebPublished { get; set; }
        //public String Confirmed { get; set; }
        //public String RfqNo { get; set; }
        //public String WebUserName { get; set; }
       
     
        //public String SltaxType { get; set; }
        //public Decimal GsltaxPcent { get; set; }
        //public Decimal TotGsltaxAmt { get; set; }
        //public Decimal TotLsltaxAmt { get; set; }
        ////public String Anlys7 { get; set; }
        ////public String Anlys8 { get; set; }
        //public Decimal MarkupDecimal { get; set; }
        //public String PkgUnit { get; set; }
        //public String WeightUnit { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }
        //public String ItemCode { get; set; }
        //public String Transport { get; set; }

       // [Tab("Pricing")]
        [Category(CategoryName.CostSummary)]
        [DisplayName("Total Item Amt")]
        public Decimal TotItemAmt { get; set; }
        [DisplayName("Item Sales Tax Amt")]
        public Decimal TotPtaxAmt { get; set; }

        [DisplayName("Gross Sales Tax Amt")]
        public Decimal TotTdiscAmt { get; set; }

        [DisplayName("Trade Disc %")]
        public Decimal TdiscPcent { get; set; }
        [DisplayName("Trade Disc Amt")]
        public Decimal TotLdiscAmt { get; set; }
        [DisplayName("Net Trade Amt")]
        public Decimal NetTradeAmt { get; set; }

        [DisplayName("Total Charges")]
        public Decimal TotChgsAmt { get; set; }

        [DisplayName("Net Pay Amt")]
        public Decimal NetPayAmt { get; set; }

        [DisplayName("Deposit %")]
        public Decimal DpsPcent { get; set; }
        [DisplayName("Deposit Amt")]
        public Decimal TotDpsAmt { get; set; }


        //public Decimal TotPriceAmt { get; set; }
        
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotAtaxAmt { get; set; }
       
       
       
        //public Decimal NetOrdrAmt { get; set; }
        //public Decimal TotGtaxAmt { get; set; }
       
       

        [Tab(TabName.QuoteDetails), QuotationDetailEditor]
        public List<QuotationDetailRow> DetailList { get; set; }

        [Tab(TabName.SpecialInstruments)]
        public String Comments1 { get; set; }
        public String Comments2 { get; set; }
        public String Comments3 { get; set; }
        public String Comments4 { get; set; }
    }
}