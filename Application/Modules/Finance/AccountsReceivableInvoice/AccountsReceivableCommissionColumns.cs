#region Enterprise Solution
// Copyright © 2006-2018 Enterprise Solution Limited
// Solution:  Enterprise Solution
// Project:   Enterprise Edition/Application
// File:  AccountsReceivableCommissionColumns.cs
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

    [ColumnsScript("Finance.AccountsReceivableCommission")]
    [BasedOnRow(typeof(Entities.AccountsReceivableCommissionRow))]
    public class AccountsReceivableCommissionColumns
    {
        [EditLink, DisplayName("Id"), AlignRight]
        public String InvoiceNoDirectEntry { get; set; }
        public String Salesman { get; set; }
        public String SalesmanName { get; set; }
        public Decimal Rate { get; set; }
    }
}