#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  FifoControlColumns.cs
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

    [ColumnsScript("Inventory.FifoControl")]
    [BasedOnRow(typeof(Entities.FifoControlRow))]
    public class FifoControlColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String Loc { get; set; }
        public String ItemNo { get; set; }
        public String Allocated { get; set; }
        public DateTime ValueDate { get; set; }
        [AlignRight]
        public Decimal LogNo { get; set; }
        [AlignRight]
        public Decimal LineNo { get; set; }
        [AlignRight]
        public Decimal LogNoOut { get; set; }
        [AlignRight]
        public Decimal LineNoOut { get; set; }
        [AlignRight]
        public Decimal Qty { get; set; }
        [AlignRight]
        public Decimal Cost { get; set; }
    }
}