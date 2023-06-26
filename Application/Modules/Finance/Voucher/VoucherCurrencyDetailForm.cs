#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  VoucherCurrencyDetailForm.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.VoucherCurrencyDetail")]
    [BasedOnRow(typeof(Entities.VoucherCurrencyDetailRow))]
    public class VoucherCurrencyDetailForm
    {
        public String VoucherType { get; set; }
        public String VoucherNo { get; set; }
        public String Ccy { get; set; }
        public Decimal LastExchRate { get; set; }
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }
        public String OwnerBranch { get; set; }
        public String SourceBranch { get; set; }
    }
}