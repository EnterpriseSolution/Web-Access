#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  SalesReturnForm.cs
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

    [FormScript("Sales.SalesReturn")]
    [BasedOnRow(typeof(Entities.SalesReturnRow))]
    public class SalesReturnForm
    {
        [Tab(TabName.GeneralInformation)]
        //[Category(CategoryName.BasicInformation)]
        public String RefNo { get; set; }
        //public String Posted { get; set; }
        public DateTime TranDate { get; set; }
        public String Loc { get; set; }

        public String ShipmentRef { get; set; }
        public String CustomerNo { get; set; }
        public String CustomerName { get; set; }

        public String Ccy { get; set; }
        public Decimal ExchRate { get; set; }
        [TextAreaEditor(Rows = 4)]
        public String Reason { get; set; }
        
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
        //public String Anlys1 { get; set; }
        //public String Anlys2 { get; set; }
        //public String Anlys7 { get; set; }
        //public String Anlys8 { get; set; }
        //public String ReturnOnly { get; set; }
        //public String Anlys9 { get; set; }
        //public String Anlys10 { get; set; }
        //public String Anlys11 { get; set; }
        //public String Anlys12 { get; set; }
        //public String Anlys13 { get; set; }
        //public String Anlys14 { get; set; }

        [Tab(TabName.ItemDetails)]
        [SalesReturnDetailEditor]
        public List<SalesReturnDetailRow> DetailList { get; set; }

        [Tab(TabName.CostSummary)]
        [Category(CategoryName.CostAdjustmentSummary)]
        [DisplayName("Total Item Amt")]
        public Decimal TotItemAmt { get; set; }
        [DisplayName("Item Refund Amt")]
        public Decimal TotRefundAmt { get; set; }
        [DisplayName("Trade Discount")]
        public Decimal TdiscPcent { get; set; }
        [DisplayName("Trade Discount Amt")]
        public Decimal TotLdiscAmt { get; set; }
        [DisplayName("Net Trade Amt")]
        public Decimal NetTradeAmt { get; set; }
        [DisplayName("Total Charges")]
        public Decimal TotChgsAmt { get; set; }

        [DisplayName("Net Refund Amt")]
        public Decimal NetPayAmt { get; set; }

        //public Decimal TotPriceAmt { get; set; }
        //public Decimal TotPtaxAmt { get; set; }
        //public Decimal TotExtPrice { get; set; }
        //public Decimal TotAtaxAmt { get; set; }


        //public Decimal TotVariaAmt { get; set; }
        //public Decimal TotTdiscAmt { get; set; }

        //public Decimal NetOrdrAmt { get; set; }
        //public Decimal TotGtaxAmt { get; set; }
        //
        //public Decimal LocPriceAmt { get; set; }
        //public Decimal LocPtaxAmt { get; set; }
        //public Decimal LocExtPrice { get; set; }
        //public Decimal LocLdiscAmt { get; set; }
        //public Decimal LocAtaxAmt { get; set; }
        //public Decimal LocItemAmt { get; set; }
        //public Decimal LocRefundAmt { get; set; }
        //public Decimal LocVariaAmt { get; set; }
        //public Decimal LocTdiscAmt { get; set; }
        //public Decimal LocChgsAmt { get; set; }
        //public Decimal LocGtaxAmt { get; set; }
        //public Decimal LocPayAmt { get; set; }
        //public Decimal TotTdiscCpd { get; set; }
        //public String AcctCustomer { get; set; }
        //public String AcctTdisc { get; set; }
        //public String AcctGtax { get; set; }
        //public DateTime CreatedDate { get; set; }
        //public String CreatedBy { get; set; }
        //public DateTime RevisedDate { get; set; }
        //public String RevisedBy { get; set; }
        //public DateTime PostedDate { get; set; }
        //public String PostedBy { get; set; }
        //public Decimal LogNo { get; set; }
        //public Decimal LastLogNo { get; set; }
        //public String GlLink { get; set; }
        //public String GlLinkType { get; set; }
        //public String GlLinkNo { get; set; }
    }
}