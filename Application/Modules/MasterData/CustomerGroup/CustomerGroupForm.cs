#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CustomerGroupForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.Enterprise.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Enterprise.CustomerGroup")]
    [BasedOnRow(typeof(Entities.CustomerGroupRow))]
    public class CustomerGroupForm
    {
        public String CustomerGroup { get; set; }

        public String Description { get; set; }

        public String Suspended { get; set; }

        [Category(CategoryName.Control)]
        public bool UseAltNames { get; set; }
        public bool WithCrLimit { get; set; }

        [Category(CategoryName.Payment)]
        public String PaymentCcy { get; set; }

        public String PayTerms { get; set; }

        public String PriceCode { get; set; }

        public Decimal CreditLimit { get; set; }

        public Decimal TradeDiscount { get; set; }

        public Decimal CustomerCount { get; set; }
    }
}