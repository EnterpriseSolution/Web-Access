#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementDetailColumns.cs
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

    [ColumnsScript("Inventory.InventoryMovementDetail")]
    [BasedOnRow(typeof(Entities.InventoryMovementDetailRow))]
    public class InventoryMovementDetailColumns
    {
        [AlignRight]
        public Decimal LineNo { get; set; }
        [AlignRight]
        public String ItemNo { get; set; }
        [AlignRight]
        public String Description { get; set; }
        [AlignRight]
        public String Uom { get; set; }
        [AlignRight]
        public Decimal LotSize { get; set; }
        [AlignRight]
        public Decimal Qty { get; set; }
        [AlignRight]
        public Decimal UnitCost { get; set; }
        [AlignRight]
        public Decimal TotalCost { get; set; }
    }
}