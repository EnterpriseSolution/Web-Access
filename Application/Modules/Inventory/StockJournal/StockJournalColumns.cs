#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  StockJournalColumns.cs
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

    [ColumnsScript("Inventory.StockJournal")]
    [BasedOnRow(typeof(Entities.StockJournalRow))]
    public class StockJournalColumns
    {
        [EditLink, DisplayName("LogNo"), AlignRight, Sortable(true)]
        //public Decimal Recnum { get; set; }
        public Decimal LogNo { get; set; }
        [Sortable(false)]
        [AlignRight]
        public Decimal LineNo { get; set; }

        [EditLink]
        public String Loc { get; set; }
        [EditLink]
        public String ItemNo { get; set; }

        public String Period { get; set; }
        public DateTime ValueDate { get; set; }
     

        //public String MoveIn { get; set; }
        //[Category("Cost")]
        public Decimal? Quantity { get; set; }
        [AlignRight]
        public Decimal UnitCost { get; set; }
        [AlignRight]
        public Decimal? Cost { get; set; }

        //public Decimal QtyIn { get; set; }
        //public Decimal QtyOut { get; set; }
        //public Decimal CostIn { get; set; }
        //public Decimal CostOut { get; set; }

        //[Category("Transaction")]
        public String RefNo { get; set; }
        public DateTime MoveDate { get; set; }
        public String LineRef { get; set; }
        public String Description { get; set; }
        public String Reference { get; set; }

        public String Transfer { get; set; }

        //public String MoveType { get; set; }
        //public String FromTo { get; set; }
        //public Decimal BalQty { get; set; }
        //public Decimal BalCost { get; set; }
        //public Decimal BalQtyItem { get; set; }
        //public Decimal BalCostItem { get; set; }
    }
}