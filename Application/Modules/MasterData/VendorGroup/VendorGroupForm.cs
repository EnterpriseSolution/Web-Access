#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorGroupForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Enterprise.VendorGroup")]
    [BasedOnRow(typeof(Entities.VendorGroupRow))]
    public class VendorGroupForm
    {
        public String VendorGroup { get; set; }

        public String Description { get; set; }

        public bool Suspended { get; set; }

        public bool  UseAltNames { get; set; }

        public String OrderCcy { get; set; }

        public String PayTerms { get; set; }

        public Decimal TradeDiscount { get; set; }

        public Decimal VendorCount { get; set; }
    }
}