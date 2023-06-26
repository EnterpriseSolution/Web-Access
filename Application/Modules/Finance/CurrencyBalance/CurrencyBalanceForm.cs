#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CurrencyBalanceForm.cs
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

    [FormScript("Finance.CurrencyBalance")]
    [BasedOnRow(typeof(Entities.CurrencyBalanceRow))]
    public class CurrencyBalanceForm
    {
        public String AcctNo { get; set; }
        public String AcctName { get; set; }
        public String Ccy { get; set; }
        public String Description { get; set; }

        public Decimal ForexBalance { get; set; }
        public String ForexSign { get; set; }
        public Decimal LocalBalance { get; set; }
        public String LocalSign { get; set; }
    }
}