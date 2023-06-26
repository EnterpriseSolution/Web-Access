#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryBalanceForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Inventory.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Inventory.InventoryBalance")]
    [BasedOnRow(typeof(Entities.InventoryBalanceRow))]
    public class InventoryBalanceForm
    {
        public String Loc { get; set; }
        public String ItemNo { get; set; }
        public String Loc2 { get; set; }
        public String ItemNo2 { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public DateTime LastDateIn { get; set; }
        public DateTime LastDateOut { get; set; }
        public String WithBalance { get; set; }
        [AlignRight]
        public Decimal QtyOnHand { get; set; }
        [AlignRight]
        public Decimal QtyWaitlisted { get; set; }
        [AlignRight]
        public Decimal QtyReserved { get; set; }
        [AlignRight]
        public Decimal QtyCommitted { get; set; }
        [AlignRight]
        public Decimal QtyAvailable { get; set; }
        [AlignRight]
        public Decimal QtyUnallocated { get; set; }
        [AlignRight]
        public Decimal InvtCostAvail { get; set; }
        [AlignRight]
        public Decimal InvtCostLdg { get; set; }
        [AlignRight]
        public String AverageCost { get; set; }
        [AlignRight]
        public Decimal LatestCost { get; set; }
        public DateTime LastCountDate { get; set; }
        public String DefaultBinNo { get; set; }
        [AlignRight]
        public Decimal QtyOnInspect { get; set; }
        [AlignRight]
        public Decimal QtyOnTransfer { get; set; }
    }
}