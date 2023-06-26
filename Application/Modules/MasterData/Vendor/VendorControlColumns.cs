﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VendorControlColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Enterprise.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Enterprise.VendorControl")]
    [BasedOnRow(typeof(Entities.VendorRow))]
    public class VendorControlColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String VendorNo { get; set; }

        public String VendorName { get; set; }

        public bool Suspended { get; set; }
        [AlignRight]
        public Decimal LeadTime { get; set; }
        [AlignRight]
        public Decimal TradeDiscount { get; set; }
        public bool WithCrLimit { get; set; }

        [AlignRight]
        public Decimal CreditLimit { get; set; }
        public String PayTerms { get; set; }

        //public String VendorGroup { get; set; }
        //public String Address { get; set; }
        //public String Address2 { get; set; }
        //public String Address3 { get; set; }
        //public String Address4 { get; set; }
        //public String PostCode { get; set; }
        //public String TelNo { get; set; }
        //public String FaxNo { get; set; }
        //public String Email { get; set; }
    }
}