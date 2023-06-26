#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesOrderForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;
using Matrix.Sales.Entities;

namespace Matrix.Sales.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Sales.SalesOrder")]
    [BasedOnRow(typeof(Entities.SalesOrderRow))]
    public class SalesOrderForm
    {
        [Tab(TabName.GeneralInformation)]
        public String OrderNo { get; set; }
        public String CustomerNo { get; set; }
        public String CustomerName { get; set; }
        public String CustomerPo { get; set; }

        //public String Posted { get; set; }
        //public String Closed { get; set; }
       [DisplayName("Quotation Ref No.")]
        public String QuoRefNo { get; set; }

        [Category(CategoryName.Dates)]
        public DateTime OrderDate { get; set; }
        [DisplayName("Last Due Date")]
        public DateTime DueDate { get; set; }
        [DisplayName("First Sched Date")]
        public DateTime SchedDate { get; set; }

        [Category(CategoryName.Shipping)]
        [DisplayName("Port of Loading")]
        public String PortLoading { get; set; }
        public String ShipVia { get; set; }
        public String VesselName { get; set; }
        public String LcNo { get; set; }
        
        [DisplayName("Port of Discharge")]
        public String PortDischarge { get; set; }
        public String ShipmentTerms { get; set; }
        public String Forwarder { get; set; }
        [DisplayName("Country of Origin")]
        public String OriginCountry { get; set; }

        [Category(CategoryName.Control)]
        public String Salesman { get; set; }
        public String PriceCode { get; set; }
        public String ShipFrom { get; set; }

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

        [Category(CategoryName.AutomaticPODetails)]
        public String VendorNo { get; set; }
        [DisplayName("P.O. No.")]
        public String PoNo { get; set; }
        [DisplayName("Pay Terms")]
        public String PoPayTerms { get; set; }
        [DisplayName("Ship To")]
        public String PoShipTo { get; set; }
        [DisplayName("Buyer")]
        public String PoBuyer { get; set; }


        [Category(CategoryName.Options)]
        [DisplayName("Multiple Shipments")]
        public String MultiShip { get; set; }
        [DisplayName("Automatic Reservation")]
        public String AutoResv { get; set; }
        [DisplayName("Automatic P.O. Issuance")]
        public String AutoPo { get; set; }
        [DisplayName("Automatic J.O. Issuance")]
        public String AutoJob { get; set; }


        [Tab(TabName.OrderDetails)]
        [SalesOrderDetailEditor]
        public List<SalesOrderDetailRow> DetailList { get; set; }

        //public String ComputeTax { get; set; }
        //public String AutoWait { get; set; }



        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        [Tab(TabName.SalesSummary)]
        [DisplayName("Total Item Amt")]
        public Decimal TotItemAmt { get; set; }
        [DisplayName("Item Sales Tax Amt")]
        public Decimal TotPtaxAmt { get; set; }
        [DisplayName("Gross Sales Tax Amt")]
        public Decimal TotGtaxAmt { get; set; }
        [DisplayName("Trade Discount Amt")]
        public Decimal TotTdiscAmt { get; set; }

        [DisplayName("Gross Sales Tax %")]
        public Decimal TdiscPcent { get; set; }

        [DisplayName("Trade Discount %")]
        public Decimal TotLdiscAmt { get; set; }


        [Category(CategoryName.OrderDeposit)]

        [DisplayName("% to Pay Amt")]
        public Decimal DpsPcent { get; set; }
        [DisplayName("Deposit Amt")]
        public Decimal TotDpsAmt { get; set; }

        [DisplayName("Receipt No")]
        public String DpsReceiptNo { get; set; }
        [DisplayName("Receipt Date")]
        public DateTime DpsRcptDate { get; set; }
        [DisplayName("Fund Code")]
        public String DpsFundCode { get; set; }
        [DisplayName("Reference")]
        public String DpsReference { get; set; }

        [Category(CategoryName.CostBalance)]
        [DisplayName("Total Charges")]
        public Decimal TotChgsAmt { get; set; }
        [DisplayName("Net Pay Amt")]
        public Decimal NetPayAmt { get; set; }

        [DisplayName("Balance Payable")]
        public Decimal NetBalAmt { get; set; }


        //public Decimal TotPriceAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotAtaxAmt { get; set; }

      
        //public Decimal NetTradeAmt { get; set; }
        //public Decimal NetOrdrAmt { get; set; }
       

       

        //public Decimal TotTdiscCpd { get; set; }
        //public Decimal TotGtaxCpd { get; set; }
        //public Decimal TotDpsCpd { get; set; }

        //public Decimal LastSchedNo { get; set; }
        //public Decimal LastLineNo { get; set; }
        //public Decimal LastTextNo { get; set; }
        //public Decimal LastCtnNo { get; set; }
    
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public DateTime PrevisedDate { get; set; }
        //public String PrevisedBy { get; set; }
        //public String LockType { get; set; }
        //public String LockRefNo { get; set; }
        //public Decimal LastLogNo { get; set; }
        //public String VendTaxCode { get; set; }
        //public String CustTaxCode { get; set; }
        //public String PackingOk { get; set; }

        //public String WeightUom { get; set; }
        //public Decimal GrWt { get; set; }
        //public Decimal NtWt { get; set; }
        //public String DimensionUom { get; set; }
        //public Decimal Volume { get; set; }
        ////public String OwnerBranch { get; set; }
        ////public String SourceBranch { get; set; }


        //public String CheckCrlimit { get; set; }
        //public Decimal CheckCrbal { get; set; }
        //public String WebPublished { get; set; }
        //public String SendWebMsg { get; set; }
        //public String WebUserName { get; set; }
     
        //public String MrpExclude { get; set; }
        //public String SltaxType { get; set; }
        //public Decimal GsltaxPcent { get; set; }
        //public Decimal TotGsltaxAmt { get; set; }
        //public Decimal TotLsltaxAmt { get; set; }
        //public Decimal LastTextNo1 { get; set; }
       
        ////public String Anlys7 { get; set; }
        ////public String Anlys8 { get; set; }
        //public String Flag { get; set; }
        //public String HoldBy { get; set; }
        //public String BrandCode { get; set; }
        //public String ItemCode { get; set; }
        //public String PkgUnit { get; set; }
        //public String WeightUnit { get; set; }
        ////public String Anlys9 { get; set; }
        ////public String Anlys10 { get; set; }
        ////public String Anlys11 { get; set; }
        ////public String Anlys12 { get; set; }
        ////public String Anlys13 { get; set; }
        ////public String Anlys14 { get; set; }
        //public String OrderType { get; set; }
        //public String RefCompanyCode { get; set; }
        //public String RefPurchaseOrderNo { get; set; }

        [Tab(TabName.SpecialInstruments)]
        public String Comments1 { get; set; }
        public String Comments2 { get; set; }
        public String Comments3 { get; set; }
        public String Comments4 { get; set; }
        public String Comments5 { get; set; }
        public String Comments6 { get; set; }
        public String Comments7 { get; set; }
        public String Comments8 { get; set; }
    }
}