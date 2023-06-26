#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationScheduleColumns.cs
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

    [ColumnsScript("Purchasing.VendorQuotationSchedule")]
    [BasedOnRow(typeof(Entities.VendorQuotationScheduleRow))]
    public class VendorQuotationScheduleColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String OrderNo { get; set; }
        public Int32 LineNo { get; set; }
        public Int16 ShipNo { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime SchedDate { get; set; }
        public String ShipVia { get; set; }
        public String ShipmentTerms { get; set; }
        public Decimal Qty { get; set; }
        public String ItemNo { get; set; }
        public String ShipTo { get; set; }
        public String Uom { get; set; }
        public Decimal LotSize { get; set; }
        public String VendorNo { get; set; }
        public String Buyer { get; set; }
        public String VendorName { get; set; }
    }
}