#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationRemarkColumns.cs
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

    [ColumnsScript("Purchasing.VendorQuotationRemark")]
    [BasedOnRow(typeof(Entities.VendorQuotationRemarkRow))]
    public class VendorQuotationRemarkColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String OrderNoClosed { get; set; }
        public Int16 TextNo { get; set; }
        public String TextType { get; set; }
        public String Description { get; set; }
        public String Remarks { get; set; }
    }
}