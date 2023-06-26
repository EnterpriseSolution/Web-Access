#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CurrencyLedgerForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.Modules.Common.Enum;

namespace Matrix.Finance.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Finance.CurrencyLedger")]
    [BasedOnRow(typeof(Entities.CurrencyLedgerRow))]
    public class CurrencyLedgerForm
    {
        public String AcctNo { get; set; }
        public String Ccy { get; set; }
        public String Period { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }

        [Category(CategoryName.Transaction)]
        public Decimal ForexBeg { get; set; }
        public String ForexBegSign { get; set; }
        public Decimal ForexDebit { get; set; }
        public Decimal ForexCredit { get; set; }
        public Decimal ForexEnd { get; set; }
        public String ForexEndSign { get; set; }

        [Category(CategoryName.Local)]
        public Decimal LocalBeg { get; set; }
        public String LocalBegSign { get; set; }
        public Decimal LocalDebit { get; set; }
        public Decimal LocalCredit { get; set; }
        public Decimal LocalEnd { get; set; }
        public String LocalEndSign { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}