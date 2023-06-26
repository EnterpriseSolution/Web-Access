#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockLedgerForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.Inventory.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventory.StockLedger")]
    [BasedOnRow(typeof(Entities.StockLedgerRow))]
    public class StockLedgerForm
    {
        public String Loc { get; set; }
        public String ItemNo { get; set; }
        public String Period { get; set; }
        //public String Loc2 { get; set; }
        //public String ItemNo2 { get; set; }
        //public String Period2 { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        [Category(CategoryName.Movement)]
        public Decimal QtyBeg { get; set; }
        public Decimal QtyIn { get; set; }
        public Decimal QtyOut { get; set; }
        public Decimal QtyEnd { get; set; }
        //public Decimal QtyOutAlloc { get; set; }
       
        [Category(CategoryName.Transfer)]
        public Decimal QtyInTrf { get; set; }
        public Decimal QtyOutTrf { get; set; }
        public Decimal CostInTrf { get; set; }
        public Decimal CostOutTrf { get; set; }

        [Category(CategoryName.Ledger)]
        public Decimal ValueBeg { get; set; }
        public Decimal CostIn { get; set; }
        public Decimal CostOut { get; set; }
        public Decimal ValueEnd { get; set; }
    }
}