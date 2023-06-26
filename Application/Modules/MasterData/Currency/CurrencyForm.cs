#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  CurrencyForm.cs
// Date: 2018/04/03 20:51

#endregion

using Matrix.MasterData.Entities;
using Matrix.Modules.Common.Enum;
using Matrix.Sales.Entities;

namespace Matrix.Enterprise.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Enterprise.Currency")]
    [BasedOnRow(typeof(Entities.CurrencyRow))]
    public class CurrencyForm
    {
        [Tab(TabName.GeneralInformation)]
        public String Ccy { get; set; }
        public String Description { get; set; }
        public bool Suspended { get; set; }
        public Decimal DefaultRate { get; set; }

        [Tab(TabName.Details), ExchangeRateEditorAttribute]
        public List<ExchangeRateRow> DetailList { get; set; }
    }
}