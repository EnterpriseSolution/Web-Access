#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockLedgerColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Inventory.StockLedger")]
    [BasedOnRow(typeof(Entities.StockLedgerRow))]
    public class StockLedgerColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String Loc { get; set; }
        public String ItemNo { get; set; }
        public String Period { get; set; }

        //public String Loc2 { get; set; }
        //public String ItemNo2 { get; set; }
        //public String Period2 { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        [AlignRight]
        public Decimal QtyBeg { get; set; }
        [AlignRight]
        public Decimal QtyIn { get; set; }
        [AlignRight]
        public Decimal QtyOut { get; set; }
        [AlignRight]
        public Decimal QtyEnd { get; set; }

        //public Decimal QtyOutAlloc { get; set; }
        [AlignRight]
        public Decimal ValueBeg { get; set; }
        [AlignRight]
        public Decimal CostIn { get; set; }
        [AlignRight]
        public Decimal CostOut { get; set; }

        [AlignRight]
        public Decimal ValueEnd { get; set; }

        //public Decimal QtyInTrf { get; set; }
        //public Decimal QtyOutTrf { get; set; }

        //public Decimal CostInTrf { get; set; }
        //public Decimal CostOutTrf { get; set; }
    }
}