#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorQuotationRemarkForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Purchasing.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Purchasing.VendorQuotationRemark")]
    [BasedOnRow(typeof(Entities.VendorQuotationRemarkRow))]
    public class VendorQuotationRemarkForm
    {
        public String OrderNo { get; set; }
        public Int16 TextNo { get; set; }
        public String TextType { get; set; }
        public String Description { get; set; }
        public String Remarks { get; set; }
    }
}