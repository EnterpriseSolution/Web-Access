#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  PurchaseRequisitionDetailColumns.cs
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

    [ColumnsScript("Purchasing.PurchaseRequisitionDetail")]
    [BasedOnRow(typeof(Entities.PurchaseRequisitionDetailRow))]
    public class PurchaseRequisitionDetailColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String ReqNoClosed { get; set; }
        public Decimal LineNo { get; set; }
        public String ItemNo { get; set; }
        public String Description { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public Decimal Qty { get; set; }
        public String ExtDescription { get; set; }
        public Decimal QtyAllocated { get; set; }
        public String Remark { get; set; }
        public Decimal QtyPreAllocated { get; set; }
    }
}