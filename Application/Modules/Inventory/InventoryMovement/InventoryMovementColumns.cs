#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  InventoryMovementColumns.cs
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

    [ColumnsScript("Inventory.InventoryMovement")]
    [BasedOnRow(typeof(Entities.InventoryMovementRow))]
    public class InventoryMovementColumns
    {
        [EditLink]
        public String RefNo { get; set; }

        public String TranType { get; set; }

        public DateTime MoveDate { get; set; }

        //public DateTime ValueDate { get; set; }

        public String Posted { get; set; }
        
        [QuickFilter]
        public String FlowType { get; set; }

        public String MoveType { get; set; }

        public String LocFrom { get; set; }

        public String LocTo { get; set; }

        public String Reference { get; set; }

        //public String ReceivedFrom { get; set; }

        //public String IssuedTo { get; set; }

        public String Dept { get; set; }

        [AlignRight]
        public Decimal TotalCost { get; set; }
        
        public String Period { get; set; }
    }
}