#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryBalanceColumns.cs
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

    [ColumnsScript("Inventory.InventoryBalance")]
    [BasedOnRow(typeof(Entities.InventoryBalanceRow))]
    public class InventoryBalanceColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        [SortOrder(1, descending: false)]
        [QuickFilter]
        public String Loc { get; set; }

        [SortOrder(2, descending: false)]
        [QuickFilter]
        public String ItemNo { get; set; }

        [QuickFilter]
        public String Description { get; set; }

        //public String LocDescription { get; set; }
        //public String ItemNoDescription { get; set; }
       // public String Loc2 { get; set; }
        //public String ItemNo2 { get; set; }
        
        public String Uom { get; set; }
      
        public String WithBalance { get; set; }

        [Width(100), AlignRight]
        public Decimal QtyOnHand { get; set; }
        [Width(100), AlignRight]
        public Decimal QtyWaitlisted { get; set; }
        [Width(100), AlignRight]
        public Decimal QtyReserved { get; set; }
        [Width(100), AlignRight]
        public Decimal QtyCommitted { get; set; }
        [Width(100), AlignRight]
        public Decimal QtyAvailable { get; set; }
        [Width(120), AlignRight]
        public Decimal QtyUnallocated { get; set; }
        // public Decimal InvtCostAvail { get; set; }
        // public Decimal InvtCostLdg { get; set; }
        [Width(100), AlignRight]
        public String AverageCost { get; set; }
        [Width(100), AlignRight]
        public Decimal LatestCost { get; set; }

        //public DateTime LastCountDate { get; set; }
        //public String DefaultBinNo { get; set; }
        [Width(120),AlignRight]
        public Decimal QtyOnInspect { get; set; }
        [Width(100), AlignRight]
        public Decimal QtyOnTransfer { get; set; }

        [Width(100)]
        public DateTime LastDateIn { get; set; }
        [Width(100)]
        public DateTime LastDateOut { get; set; }
    }
}