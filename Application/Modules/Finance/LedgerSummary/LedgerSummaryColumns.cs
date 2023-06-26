﻿#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  LedgerSummaryColumns.cs
// Date: 2018/04/03 20:51

#endregion

namespace Matrix.Finance.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Finance.LedgerSummary")]
    [BasedOnRow(typeof(Entities.LedgerSummaryRow))]
    public class LedgerSummaryColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String AcctNo{ get; set; }
        public String Period { get; set; }
        //public Decimal FiscalYear { get; set; }
        //public Decimal PeriodNo { get; set; }
        public Decimal BalBeg { get; set; }
        public Decimal TotalDebit { get; set; }
        public Decimal TotalCredit { get; set; }
        public Decimal BalEnd { get; set; }

        public String BalBegSign { get; set; }
        public String BalEndSign { get; set; }
        //public String OwnerBranch { get; set; }
        //public String SourceBranch { get; set; }
    }
}