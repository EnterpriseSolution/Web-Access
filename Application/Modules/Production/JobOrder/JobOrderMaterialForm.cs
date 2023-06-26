#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  JobOrderMaterialForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Production.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Production.JobOrderMaterial")]
    [BasedOnRow(typeof(Entities.JobOrderMaterialRow))]
    public class JobOrderMaterialForm
    {
        public String JobNo { get; set; }
        public Decimal LineNo { get; set; }
        public String PartItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal QtyPer { get; set; }
        public Decimal QtyRequired { get; set; }
        public Decimal QtyReserved { get; set; }
        public Decimal QtyWaitlisted { get; set; }
        public Decimal QtyPurchase { get; set; }
        public Decimal QtyProduce { get; set; }
        public String SubJobNo { get; set; }
        public String VendorNo { get; set; }
        public String OrderNo { get; set; }
        public DateTime OrderDate { get; set; }
        public String PurchaseUom { get; set; }
        public Decimal LotSize { get; set; }
        public String PriceCcy { get; set; }
        public Decimal ExpectedPrice { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime SchedDate { get; set; }
        public Decimal InvCost { get; set; }
        public Decimal StdCost { get; set; }
        public Decimal LatCost { get; set; }
        public Decimal UnitCost { get; set; }
        public Decimal CostMaterial { get; set; }
        public DateTime SubDueDate { get; set; }
        public DateTime SubStartDate { get; set; }
        public String SubBomNo { get; set; }
        public String Specifications { get; set; }
        public Decimal QtyNeeded { get; set; }
        public Decimal ScrapRate { get; set; }
        public Decimal ScrapQty { get; set; }
        public Decimal QtyAdjusted { get; set; }
        public Decimal SubQty { get; set; }
        public String IsAlternate { get; set; }
        public Decimal MainLineNo { get; set; }
        public Decimal UsageRate { get; set; }
        public String Loc { get; set; }
        public DateTime Eod { get; set; }
        public DateTime Edd { get; set; }
        public String Anlys1 { get; set; }
        public String Anlys2 { get; set; }
        public String SubBlowThru { get; set; }
        public Decimal BinQtyOut { get; set; }
        public String BuyMake { get; set; }
        public String IncludeScrapRate { get; set; }
        public String PoNo { get; set; }
        public String SubWcBackflush { get; set; }
        public String RunnerWaste { get; set; }
        public Decimal ReuseRate { get; set; }
        public Decimal RunnerWasteRate { get; set; }
        public String Anlys15 { get; set; }
        public String Anlys16 { get; set; }
        public String Anlys17 { get; set; }
        public String SubFormulaCode { get; set; }
        public Boolean IncludeJob { get; set; }
        public Decimal QuotationScrapQty { get; set; }
        public Decimal QuotationScrapRate { get; set; }
        public Boolean CustomerProvided { get; set; }
        public String OriginalItemNo { get; set; }
    }
}