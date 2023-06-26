#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CurrencyBalanceColumns.cs
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

    [ColumnsScript("Finance.CurrencyBalance")]
    [BasedOnRow(typeof(Entities.CurrencyBalanceRow))]
    public class CurrencyBalanceColumns
    {
        //[EditLink, DisplayName("Id"), AlignRight]
        //public Decimal Recnum { get; set; }
        [EditLink]
        public String AcctNo { get; set; }
        public String AcctName { get; set; }
        public String Ccy { get; set; }
        [DisplayName("Transaction Balance")]
        public Decimal ForexBalance { get; set; }
        [DisplayName("Transaction Sign")]
        public String ForexSign { get; set; }
        public Decimal LocalBalance { get; set; }
        public String LocalSign { get; set; }
    }
}