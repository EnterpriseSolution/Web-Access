#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  ItemLotSerialColumns.cs
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

    [ColumnsScript("Inventory.ItemLotSerial")]
    [BasedOnRow(typeof(Entities.ItemLotSerialRow))]
    public class ItemLotSerialColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String ItemNo { get; set; }
        public String SerialNo { get; set; }
        public String Loc { get; set; }
        public String BinNo { get; set; }
        public String LotNo { get; set; }
        public String Closed { get; set; }
        public DateTime ExpiryDate { get; set; }
        public String SourceType { get; set; }
        public String SourceRef { get; set; }
        public Decimal SourceEntryNo { get; set; }
    }
}