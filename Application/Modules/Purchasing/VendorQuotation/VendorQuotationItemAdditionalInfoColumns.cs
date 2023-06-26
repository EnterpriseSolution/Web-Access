#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationItemAdditionalInfoColumns.cs
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

    [ColumnsScript("Purchasing.VendorQuotationItemAdditionalInfo")]
    [BasedOnRow(typeof(Entities.VendorQuotationItemAdditionalInfoRow))]
    public class VendorQuotationItemAdditionalInfoColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public Decimal Recnum { get; set; }
        [EditLink]
        public String OrderNo { get; set; }
        public Int32 LineNo { get; set; }
        public Int32 EntryNo { get; set; }
        public String Caption { get; set; }
        public String Description { get; set; }
        public String BitmapPath { get; set; }
    }
}