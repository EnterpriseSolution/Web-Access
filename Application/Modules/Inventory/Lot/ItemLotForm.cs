#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemLotForm.cs
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

    [FormScript("Inventory.ItemLot")]
    [BasedOnRow(typeof(Entities.ItemLotRow))]
    public class ItemLotForm
    {
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Loc { get; set; }
        public String BinNo { get; set; }
        public String LotNo { get; set; }
        public String Closed { get; set; }
        public String LocSummary { get; set; }
        public Decimal QtyShipped { get; set; }
        public Decimal QtyReceived { get; set; }
        public Decimal QtyIssued { get; set; }
        public Decimal QtyFinished { get; set; }
        public Decimal QtyBalance { get; set; }
        public DateTime ExpiryDate { get; set; }
        public String Uom { get; set; }
        public String Remarks { get; set; }
        public Decimal UnitCost { get; set; }
        public String UserDefinedField01 { get; set; }
        public String UserDefinedField02 { get; set; }
        public String UserDefinedField03 { get; set; }
        public String UserDefinedField04 { get; set; }
        public String UserDefinedField05 { get; set; }
        public Decimal FifoLogNo { get; set; }
        public Decimal FifoLineNo { get; set; }
    }
}