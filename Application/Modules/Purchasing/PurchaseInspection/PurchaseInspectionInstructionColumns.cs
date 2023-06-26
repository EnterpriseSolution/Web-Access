#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseInspectionInstructionColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Purchasing.PurchaseInspectionInstruction")]
    [BasedOnRow(typeof(Entities.PurchaseInspectionInstructionRow))]
    public class PurchaseInspectionInstructionColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String RefNo { get; set; }
        public Decimal LineNo { get; set; }
        public Decimal EntryNo { get; set; }
        public String InspectCode { get; set; }
        public String Description { get; set; }
        public String Remarks { get; set; }
        public Decimal Qty { get; set; }
    }
}